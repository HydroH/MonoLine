using System;
using System.Collections.Generic;

namespace MonoLine
{
    class Expression
    {
        //M1-4初始化
        private string[] M = new string[5];
        public void MInit(string Mn, int i)
        {
            if (Mn == "") M[i] = "0";
            else M[i] = Mn;
        }

        //初始化
        private void ExpInit(ref string exp)
        {
            Operator op = new Operator();

            //全/半角&中/英文
            exp = exp.Replace('（', '(');
            exp = exp.Replace('）', ')');
            exp = exp.Replace('。', '.');
            exp = exp.Replace('，', '.');
            exp = exp.Replace(',', '.');
            exp = exp.Replace('[', '(');
            exp = exp.Replace(']', ')');
            exp = exp.Replace('{', '(');
            exp = exp.Replace('}', ')');
            exp = exp.Replace('【', '(');
            exp = exp.Replace('】', ')');
            exp = exp.Replace('『', '(');
            exp = exp.Replace('』', ')');
            exp = exp.Replace('_', '-');
            exp = exp.Replace('\\', '/');
            exp = exp.Replace('П', 'π');
            
            //在括号/数字/函数/常数间插入乘号
            bool afterBracket = false;
            bool afterNum = false;
            bool afterNumSpace = false;
            bool afterConst = false;
            for (int i = 0; i <= exp.Length - 1; i++)
            {
                if (op.FindFunc(exp, i) && (afterBracket || afterNum || afterNumSpace || afterConst)) //当前是函数,之前有括号/数字/常数
                {
                    exp = exp.Insert(i, "*");
                    i += 1;
                }
                
                if (op.FindConst(exp, i) && (afterBracket || afterNum || afterNumSpace || afterConst)) //当前是常数,之前有括号/数字/常数
                {
                    exp = exp.Insert(i, "*");
                    i += 1;
                }

                if ((exp[i] == '(') && (afterBracket || afterNum || afterNumSpace || afterConst)) //当前是括号,之前有括号/数字/常数
                    exp = exp.Insert(i, "*");

                if (IsDigit(exp[i]) && (afterBracket || afterNumSpace || afterConst)) //当前是数字,之前有括号/数字+空白/常数
                    exp = exp.Insert(i, "*");

                if (IsDigit(exp[i])) //在数字后
                {
                    afterBracket = false;
                    afterNum = true;
                    afterNumSpace = false;
                    afterConst = false;
                    continue;
                }

                if (exp[i] == ')') //在右括号后
                {
                    afterBracket = true;
                    afterNum = false;
                    afterNumSpace = false;
                    afterConst = false;
                    continue;
                }
                
                if (op.FindConst(exp, i)) //在常数后
                {
                    afterBracket = false;
                    afterNum = false;
                    afterNumSpace = false;
                    afterConst = true;
                    i += op.opStr.Length - 1;
                    continue;
                }

                afterNumSpace = afterNum || afterNumSpace;//在数字与空白符后
                if (op.FindWhole(exp, i) || (exp[i] == '(')) 
                {
                    afterBracket = false;
                    afterNum = false;
                    afterNumSpace = false;
                    afterConst = false;
                    if (op.FindWhole(exp, i)) i += op.opStr.Length - 1;
                    continue;
                }
            }

            //替换常数
            for (int i = 0; i <= exp.Length - 1; i++)
            {
                if (op.FindConst(exp, i)) 
                {
                    exp = exp.Remove(i, op.opStr.Length);
                    switch (op.opStr)
                    {
                        case "en":
                            exp = exp.Insert(i, Convert.ToString(Math.E));
                            break;
                        case "pi":
                        case "π":
                            exp = exp.Insert(i, Convert.ToString(Math.PI));
                            break;
                        case "m1":
                            exp = exp.Insert(i, M[1]);
                            break;
                        case "m2":
                            exp = exp.Insert(i, M[2]);
                            break;
                        case "m3":
                            exp = exp.Insert(i, M[3]);
                            break;
                        case "m4":
                            exp = exp.Insert(i, M[4]);
                            break;
                    }
                }
            }

            //预处理正负号
            char[] tempExp = exp.ToCharArray();
            bool afterOp = true;
            bool foundOp;
            for (int i = 0; i <= exp.Length - 1; i++)
            {
                if ((exp[i] == '+') && afterOp) tempExp[i] = '~';
                if ((exp[i] == '-') && afterOp) tempExp[i] = '_';
                foundOp = false;
                if (op.FindWhole(exp, i) || (exp[i] == '(')) 
                {
                    afterOp = true;
                    foundOp = true;
                    if (op.FindWhole(exp, i)) i += op.opStr.Length - 1;
                }
                if (!foundOp) afterOp = false;
            }
            exp = new string(tempExp);
        }

        //检测是否为数字
        private bool IsDigit(char digit)
        {
            if ((digit >= '0') && (digit <= '9')) return true;
            return (digit == '.');
        }

        //中序转后序
        private string InfixToPostfix(string exp)
        {
            string postExp = "";
            Stack<char> operatorStack = new Stack<char>();
            for (int i = 0; i <= exp.Length - 1; i++) 
            {
                //数字添加至结果字符串
                if (IsDigit(exp[i]))
                {
                    postExp += exp[i];
                    continue;
                }
                if (exp[i] == '(')
                {
                    operatorStack.Push('(');
                    continue;
                }
                if (exp[i] == ')')
                {
                    while (operatorStack.Count > 0)
                    {
                        char topOp = operatorStack.Pop();
                        if (topOp == '(') break;
                        else postExp += topOp;
                    }
                    continue;
                }
                Operator nowOp = new Operator();
                if (nowOp.FindWhole(exp, i))
                {
                    while (operatorStack.Count > 0)
                    {
                        Operator topOp = new Operator(operatorStack.Pop());
                        //弹出优先级更高的运算符并添加至结果字符串
                        if ((topOp.priorLvl > nowOp.priorLvl) || nowOp.isRComb)
                        {
                            operatorStack.Push(topOp.opChar);
                            break;
                        }
                        else postExp += topOp.opChar;
                    }
                    //压入当前运算符
                    operatorStack.Push(nowOp.opChar);
                    postExp += ' ';
                    i += nowOp.opStr.Length - 1;
                }
            }
            //弹出所有运算符
            while (operatorStack.Count > 0) postExp += operatorStack.Pop();
            return postExp;
        }

        //后序表达式求值
        private string PostfixEval(string postExp)
        {
            Stack<double> result = new Stack<double>();
            double x, y;
            for (int i = 0; i <= postExp.Length - 1; i++)
            {
                Operator op = new Operator(postExp[i]);
                if (IsDigit(postExp[i]))
                {
                    string operand = "";
                    while ((i <= postExp.Length - 1) && IsDigit(postExp[i]))  
                    {
                        operand += postExp[i];
                        i++;
                    }
                    i--;
                    result.Push(Convert.ToDouble(operand));
                    continue;
                }
                if (postExp[i] == ' ') continue;
                if (op.isSingle)
                {
                    y = result.Pop();
                    result.Push(op.Parse(y));
                }
                else
                {
                    y = result.Pop();
                    x = result.Pop();
                    result.Push(op.Parse(x, y));
                }
            }
            return Convert.ToString(result.Peek());
        }

        //报错信息
        public string errorMessage;

        //主函数
        public string Evaluate(string rawExp)
        {
            errorMessage = "";
            if (rawExp == "") return "";
            string exp = rawExp.ToLower();
            string postExp;
            //Easter Egg :P
            if ((exp.IndexOf("life") >= 0) && (exp.IndexOf("universe") >= 0) && (exp.IndexOf("everything") >= 0))
                return "42";
            try
            {
                ExpInit(ref exp);
                postExp = InfixToPostfix(exp);
                postExp = PostfixEval(postExp);
            }
            catch
            {
                errorMessage = "Error: Invalid Expression";
                postExp = rawExp;
            }
            return postExp;
        }
    }
}
