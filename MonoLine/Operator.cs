using System;
using System.Collections;
using System.Collections.Generic;

namespace MonoLine
{
    class Operator
    {
        //运算符集合
        private readonly string[] WholeSet =
        {
            "+",
            "-",
            "*",
            "/",
            "^",
            "e",
            "sqrt",
            "sin",
            "cos",
            "tan",
            "cot",
            "sec",
            "csc",
            "deg",
            "log",
            "ln",
            "°",
            "~",
            "_"
        };
        private readonly string[] FuncSet = 
        {
            "sqrt",
            "sin",
            "cos",
            "tan",
            "cot",
            "sec",
            "csc",
            "log",
            "ln"
        };
        private readonly string[] ConstSet = 
        {
            "en",
            "pi",
            "π"
        };

        //字符串对应单字符
        private static Hashtable Hash = new Hashtable();
        private void HashInit()
        {
            Hash.Add("+", '+');
            Hash.Add("-", '-');
            Hash.Add("*", '*');
            Hash.Add("/", '/');
            Hash.Add("^", '^');
            Hash.Add("e", 'e');//科学记数法
            Hash.Add("~", '~');//正号
            Hash.Add("_", '_');//负号
            Hash.Add("sqrt", '√');//根号
            Hash.Add("sin", 'α');
            Hash.Add("cos", 'β');
            Hash.Add("tan", 'γ');
            Hash.Add("cot", 'δ');
            Hash.Add("sec", 'ε');
            Hash.Add("csc", 'ζ');
            Hash.Add("deg", '°');
            Hash.Add("°", '°');
            Hash.Add("log", 'λ');
            Hash.Add("ln", 'μ');
        }

        //优先级
        private static Hashtable Prior = new Hashtable();
        private void PriorInit()
        {
            //数字越小优先级越高
            Prior.Add('°', -1);
            Prior.Add('√', 0);//根号
            Prior.Add('α', 0);
            Prior.Add('β', 0);
            Prior.Add('γ', 0);
            Prior.Add('δ', 0);
            Prior.Add('ε', 0);
            Prior.Add('ζ', 0);
            Prior.Add('λ', 0);
            Prior.Add('μ', 0);
            Prior.Add('^', 0);
            Prior.Add('e', 0);//科学记数法
            Prior.Add('*', 1);
            Prior.Add('/', 1);
            Prior.Add('~', 2);//正号
            Prior.Add('_', 2);//负号
            Prior.Add('+', 2);
            Prior.Add('-', 2);
            Prior.Add('(', int.MaxValue);
        }

        //结合律
        private static HashSet<char> RComb = new HashSet<char>();
        private void RCombInit()
        {
            //true为右结合，false为左结合
            RComb.Add('~');//正号
            RComb.Add('_');//负号
            RComb.Add('√');//根号
            RComb.Add('α');
            RComb.Add('β');
            RComb.Add('γ');
            RComb.Add('δ');
            RComb.Add('ε');
            RComb.Add('ζ');
            RComb.Add('λ');
            RComb.Add('μ');
            RComb.Add('^');
            RComb.Add('e');//科学记数法
        }

        //操作数数量
        private static HashSet<char> Single = new HashSet<char>();
        private void SingleInit()
        {
            Single.Add('°');
            Single.Add('√');
            Single.Add('α');
            Single.Add('β');
            Single.Add('γ');
            Single.Add('δ');
            Single.Add('ε');
            Single.Add('ζ');
            Single.Add('λ');
            Single.Add('μ');
            Single.Add('~');
            Single.Add('_');
        }

        //数学计算
        //双目运算符重载
        public double Parse(double x, double y)
        {
            switch (opChar)
            {
                case '+': return (x + y);
                case '-': return (x - y);
                case '*': return (x * y);
                case '/': return (x / y);
                case '^': return (Math.Pow(x, y));
                case 'e': return (x * Math.Pow(10, y));
            }
            return double.NaN;
        }
        //单目运算符重载
        public double Parse(double x)
        {
            switch (opChar)
            {
                case '√': return Math.Sqrt(x);
                case 'α': return Math.Sin(x);
                case 'β': return Math.Cos(x);
                case 'γ': return Math.Tan(x);
                case 'δ': return (1 / Math.Tan(x));
                case 'ε': return (1 / Math.Cos(x));
                case 'ζ': return (1 / Math.Sin(x));
                case 'λ': return Math.Log10(x);
                case 'μ': return Math.Log(x);
                case '°': return (x * Math.PI / 180);
                case '~': return x;
                case '_': return -x;
            }
            return double.NaN;
        }

        //******添加运算符时修改以上部分即可******

        //运算符参数
        public string opStr;
        public char opChar;
        public int priorLvl;//优先级
        public bool isRComb;//右结合
        public bool isSingle;//单目

        //初始化
        public Operator()
        {
            Hash.Clear();
            Prior.Clear();
            RComb.Clear();
            Single.Clear();
            HashInit();
            PriorInit();
            RCombInit();
            SingleInit();
        }
        public Operator(char op)
        {
            Hash.Clear();
            Prior.Clear();
            RComb.Clear();
            Single.Clear();
            HashInit();
            PriorInit();
            RCombInit();
            SingleInit();
            opChar = op;
            priorLvl = Convert.ToInt32(Prior[op]);
            isRComb = RComb.Contains(op);
            isSingle = Single.Contains(op);
        }

        //在pos位置查找运算符
        public bool FindWhole(string exp, int pos)
        {
            for (int i = 0; i <= WholeSet.Length - 1; i++)
                if (exp.IndexOf(WholeSet[i], pos) == pos)
                {
                    opStr = WholeSet[i];
                    opChar = Convert.ToChar(Hash[opStr]);
                    priorLvl = Convert.ToInt32(Prior[opChar]);
                    isRComb = RComb.Contains(opChar);
                    isSingle = Single.Contains(opChar);
                    return true;
                }
            return false;
        }
        public bool FindFunc(string exp, int pos)
        {
            for (int i = 0; i <= FuncSet.Length - 1; i++)
                if (exp.IndexOf(FuncSet[i], pos) == pos)
                {
                    opStr = FuncSet[i];
                    opChar = Convert.ToChar(Hash[opStr]);
                    priorLvl = Convert.ToInt32(Prior[opChar]);
                    isRComb = RComb.Contains(opChar);
                    isSingle = Single.Contains(opChar);
                    return true;
                }
            return false;
        }
        public bool FindConst(string exp, int pos)
        {
            for (int i = 0; i <= ConstSet.Length - 1; i++)
                if (exp.IndexOf(ConstSet[i], pos) == pos)
                {
                    opStr = ConstSet[i];
                    opChar = Convert.ToChar(Hash[opStr]);
                    priorLvl = Convert.ToInt32(Prior[opChar]);
                    isRComb = RComb.Contains(opChar);
                    isSingle = Single.Contains(opChar);
                    return true;
                }
            return false;
        }
    }
}
