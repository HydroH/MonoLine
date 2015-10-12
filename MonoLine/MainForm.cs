using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MonoLine
{
    public partial class mainForm : Form
    {
        //可拖动标题栏
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        private void gPanelTitleBack_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        //点击任务栏实现最小化
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_MINIMIZEBOX = 0x00020000;  // Winuser.h中定义
                CreateParams cp = base.CreateParams;
                cp.Style = cp.Style | WS_MINIMIZEBOX;   // 允许最小化操作
                return cp;
            }
        }

        //GDI+ 绘制标题栏、按钮

        //参数初始化
        static int formWidth;
        static int formHeight;
        const int titleMargin = 120;
        const int titleHeight = 30;
        const int buttonWidth = 50;
        const int buttonLength = 23;
        Point[] frame;
        Point[] titleBar;
        Point[] closeButton;
        Point[] crossLeft;
        Point[] crossRight;
        Point[] minButton;
        Point[] minIcon;
        Point[] expandButton;
        private void InitPaintParam()
        {
            if (null != ActiveForm)
            {
                formWidth = ActiveForm.Width;
                formHeight = ActiveForm.Height;
            }
            frame = new Point[]
            {
                new Point(1, 1),
                new Point(formWidth - 1, 1),
                new Point(formWidth - 1, formHeight - 1),
                new Point(1, formHeight - 1)
            };
            titleBar = new Point[]
            {
                new Point(titleMargin, 0),
                new Point(formWidth, 0),
                new Point(formWidth, titleHeight),
                new Point(titleMargin + titleHeight, titleHeight)
            };
            closeButton = new Point[]
            {
                new Point(formWidth - buttonWidth - titleHeight / 2, 0),
                new Point(formWidth, 0),
                new Point(formWidth, titleHeight),
                new Point(formWidth - buttonWidth + titleHeight / 2, 30)
            };
            crossLeft = new Point[]
            {
                new Point(formWidth - buttonWidth / 2 - 3, titleHeight * 1 / 3),
                new Point(formWidth - buttonWidth / 2 - 1, titleHeight * 1 / 3),
                new Point(formWidth - buttonWidth / 2 + 9, titleHeight * 2 / 3),
                new Point(formWidth - buttonWidth / 2 + 7, titleHeight * 2 / 3)
            };
            crossRight = new Point[]
            {
                new Point(formWidth - buttonWidth / 2 + 6, titleHeight * 1 / 3),
                new Point(formWidth - buttonWidth / 2 + 8, titleHeight * 1 / 3),
                new Point(formWidth - buttonWidth / 2 - 2, titleHeight * 2 / 3),
                new Point(formWidth - buttonWidth / 2 - 4, titleHeight * 2 / 3)
            };
            minButton = new Point[]
            {
                new Point(formWidth - buttonWidth*2 - titleHeight / 2, 0),
                new Point(formWidth - buttonWidth - titleHeight / 2, 0),
                new Point(formWidth - buttonWidth + titleHeight / 2, titleHeight),
                new Point(formWidth - buttonWidth * 2 + titleHeight / 2,titleHeight)
            };
            minIcon = new Point[]
            {
                new Point(formWidth - buttonWidth * 3 / 2 - 2, titleHeight * 2 / 3 - 2),
                new Point(formWidth - buttonWidth * 3 / 2 + 10, titleHeight * 2 / 3 - 2),
                new Point(formWidth - buttonWidth * 3 / 2 + 10, titleHeight * 2 / 3),
                new Point(formWidth - buttonWidth * 3 / 2 - 2, titleHeight * 2 / 3)
            };
            expandButton = new Point[] 
            {
                new Point(formWidth - buttonLength, formHeight),
                new Point(formWidth, formHeight),
                new Point(formWidth, formHeight - buttonLength)
            };
        }
        
        //绘制边框
        protected override void OnPaint(PaintEventArgs e)
        {
            InitPaintParam();
            Graphics g = e.Graphics;
            Brush royalBlue = new SolidBrush(Color.RoyalBlue);
            g.DrawPolygon(new Pen(Color.RoyalBlue, 2), frame);
            g.FillPolygon(royalBlue, titleBar);
        }

        //绘制标题栏
        private void panelDrag_Paint(object sender, PaintEventArgs e)
        {
            InitPaintParam();
            GraphicsPath gp = new GraphicsPath();
            gp.AddPolygon(titleBar);
            panelDrag.Region = new Region(gp);
        }

        //绘制关闭按钮
        private void buttonClose_Paint(object sender, PaintEventArgs e)
        {
            InitPaintParam();
            GraphicsPath gp = new GraphicsPath();
            gp.AddPolygon(closeButton);
            buttonClose.Region = new Region(gp);
            Graphics g = e.Graphics;
            Brush white = new SolidBrush(Color.White);
            g.FillPolygon(white, crossLeft);
            g.FillPolygon(white, crossRight);
        }

        //绘制最小化按钮
        private void buttonMin_Paint(object sender, PaintEventArgs e)
        {
            InitPaintParam();
            GraphicsPath gp = new GraphicsPath();
            gp.AddPolygon(minButton);
            buttonMin.Region = new Region(gp);
            Graphics g = e.Graphics;
            Brush white = new SolidBrush(Color.White);
            g.FillPolygon(white, minIcon);
        }

        //绘制扩展按钮
        private void buttonExpand_Paint(object sender, PaintEventArgs e)
        {
            InitPaintParam();
            GraphicsPath gp = new GraphicsPath();
            gp.AddPolygon(expandButton);
            buttonExpand.Region = new Region(gp);
        }

        public mainForm()
        {
            InitializeComponent();
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            textBox.Focus();
        }

        Backlog textLog = new Backlog();
        private void buttonEvaluate_Click(object sender, EventArgs e)
        {
            textLog.AddLog(textBox.Text);
            Expression textExp = new Expression();
            Expression mExp = new Expression();
            textExp.MInit(mExp.Evaluate(textBoxM1.Text), 1);
            if ((mExp.errorMessage != "") || (textBoxM1.Text == "")) 
            {
                messageLabel.Text = "错误：M1表达式无效";
                return;
            }
            textExp.MInit(mExp.Evaluate(textBoxM2.Text), 2);
            if ((mExp.errorMessage != "") || (textBoxM2.Text == ""))
            {
                messageLabel.Text = "错误：M2表达式无效";
                return;
            }
            textExp.MInit(mExp.Evaluate(textBoxM3.Text), 3);
            if ((mExp.errorMessage != "") || (textBoxM3.Text == ""))
            {
                messageLabel.Text = "错误：M3表达式无效";
                return;
            }
            textExp.MInit(mExp.Evaluate(textBoxM4.Text), 4);
            if ((mExp.errorMessage != "") || (textBoxM4.Text == ""))
            {
                messageLabel.Text = "错误：M4表达式无效";
                return;
            }
            textBox.Text = textExp.Evaluate(textBox.Text);
            messageLabel.Text = textExp.errorMessage;
            textBox.SelectionStart = textBox.TextLength;
            textLog.AddLog(textBox.Text);
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonEvaluate_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                textBox.Text = textLog.ReturnLog(textBox.Text);
                textBox.SelectionStart = textBox.TextLength;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                textBox.Text = textLog.ForwardLog(textBox.Text);
                textBox.SelectionStart = textBox.TextLength;
                e.SuppressKeyPress = true;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //扩展按钮
        bool expanded = false;
        private void buttonExpand_Click(object sender, EventArgs e)
        {
            if (expanded)
            {
                for (int i = 0; i <= (290 - 155) / (buttonLength - 3); i++)
                {
                    ActiveForm.Height -= buttonLength - 3;
                    buttonExpand.Refresh();
                }
                messageLabel.Location = new Point(messageLabel.Location.X, messageLabel.Location.Y - 3);
                ActiveForm.Height = 155;
                buttonExpand.Refresh();
                ActiveForm.Invalidate();
                expanded = false;
            }
            else
            {
                for (int i = 0; i <= (290 - 155) / (buttonLength - 3); i++) 
                {
                    ActiveForm.Height += buttonLength - 3;
                    buttonExpand.Refresh();
                }
                messageLabel.Location = new Point(messageLabel.Location.X, messageLabel.Location.Y + 3);
                ActiveForm.Height = 290;
                buttonExpand.Refresh();
                ActiveForm.Invalidate();
                expanded = true;
            }
        }

        //按钮插入函数
        private void InsertFunc(string op)
        {
            string str = textBox.Text;
            int seleStart = textBox.SelectionStart;
            int seleLeng = textBox.SelectionLength;
            str = str.Remove(seleStart, seleLeng);
            str = str.Insert(seleStart, op+"()");
            textBox.Text = str;
            textBox.SelectionStart = seleStart + op.Length + 1;
            textBox.SelectionLength = 0;
            textBox.Focus();
        }
        private void buttonSin_Click(object sender, EventArgs e)
        {
            InsertFunc("sin");
        }
        private void buttonCos_Click(object sender, EventArgs e)
        {
            InsertFunc("cos");
        }
        private void buttonTan_Click(object sender, EventArgs e)
        {
            InsertFunc("tan");
        }
        private void buttonCot_Click(object sender, EventArgs e)
        {
            InsertFunc("cot");
        }
        private void buttonSec_Click(object sender, EventArgs e)
        {
            InsertFunc("sec");
        }
        private void buttonCsc_Click(object sender, EventArgs e)
        {
            InsertFunc("csc");
        }
        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            InsertFunc("sqrt");
        }
        private void buttonLog_Click(object sender, EventArgs e)
        {
            InsertFunc("log");
        }
        private void buttonLn_Click(object sender, EventArgs e)
        {
            InsertFunc("ln");
        }

        //按钮插入常数
        private void InsertConst(string op)
        {
            string str = textBox.Text;
            int seleStart = textBox.SelectionStart;
            int seleLeng = textBox.SelectionLength;
            str = str.Remove(seleStart, seleLeng);
            str = str.Insert(seleStart, op);
            textBox.Text = str;
            textBox.SelectionStart = seleStart + op.Length;
            textBox.SelectionLength = 0;
            textBox.Focus();
        }
        private void buttonDeg_Click(object sender, EventArgs e)
        {
            InsertConst("deg");
        }
        private void buttonPi_Click(object sender, EventArgs e)
        {
            InsertConst("pi");
        }
        private void buttonEn_Click(object sender, EventArgs e)
        {
            InsertConst("en");
        }

        //M1-4
        private void buttonIm1_Click(object sender, EventArgs e)
        {
            textBoxM1.Text = textBox.Text;
        }
        private void buttonIm2_Click(object sender, EventArgs e)
        {
            textBoxM2.Text = textBox.Text;
        }
        private void buttonIm3_Click(object sender, EventArgs e)
        {
            textBoxM3.Text = textBox.Text;
        }
        private void buttonIm4_Click(object sender, EventArgs e)
        {
            textBoxM4.Text = textBox.Text;
        }

        private void buttonM1_Click(object sender, EventArgs e)
        {
            InsertConst("M1");
        }
        private void buttonM2_Click(object sender, EventArgs e)
        {
            InsertConst("M2");
        }
        private void buttonM3_Click(object sender, EventArgs e)
        {
            InsertConst("M3");
        }
        private void buttonM4_Click(object sender, EventArgs e)
        {
            InsertConst("M4");
        }
    }
}
