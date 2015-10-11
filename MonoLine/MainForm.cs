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
        static int formWidth = 650;
        static int formHeight = 155;
        const int titleMargin = 120;
        const int titleHeight = 30;
        const int buttonWidth = 50;
        Point[] frame =
        {
            new Point(1, 1),
            new Point(formWidth - 1, 1),
            new Point(formWidth - 1, formHeight - 1),
            new Point(1, formHeight - 1)
        };
        Point[] titleBar =
        {
            new Point(titleMargin, 0),
            new Point(formWidth, 0),
            new Point(formWidth, titleHeight),
            new Point(titleMargin + titleHeight, titleHeight)
        };
        Point[] closeButton =
        {
            new Point(formWidth - buttonWidth - titleHeight / 2, 0),
            new Point(formWidth, 0),
            new Point(formWidth, titleHeight),
            new Point(formWidth - buttonWidth + titleHeight / 2, 30)
        };
        Point[] minButton =
        {
            new Point(formWidth - buttonWidth*2 - titleHeight / 2, 0),
            new Point(formWidth - buttonWidth - titleHeight / 2, 0),
            new Point(formWidth - buttonWidth + titleHeight / 2, titleHeight),
            new Point(formWidth - buttonWidth * 2 + titleHeight / 2,titleHeight)
        };

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush royalBlue = new SolidBrush(Color.RoyalBlue);
            g.DrawPolygon(new Pen(Color.RoyalBlue, 2), frame);
            g.FillPolygon(royalBlue, titleBar);
        }

        private void panelDrag_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddPolygon(titleBar);
            panelDrag.Region = new Region(gp);
        }

        //绘制关闭标志
        Point[] crossLeft =
        {
            new Point(formWidth - buttonWidth / 2 - 3, titleHeight * 1 / 3),
            new Point(formWidth - buttonWidth / 2 - 1, titleHeight * 1 / 3),
            new Point(formWidth - buttonWidth / 2 + 9, titleHeight * 2 / 3),
            new Point(formWidth - buttonWidth / 2 + 7, titleHeight * 2 / 3)
        };
        Point[] crossRight =
        {
            new Point(formWidth - buttonWidth / 2 + 6, titleHeight * 1 / 3),
            new Point(formWidth - buttonWidth / 2 + 8, titleHeight * 1 / 3),
            new Point(formWidth - buttonWidth / 2 - 2, titleHeight * 2 / 3),
            new Point(formWidth - buttonWidth / 2 - 4, titleHeight * 2 / 3)
        };
        private void buttonClose_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddPolygon(closeButton);
            buttonClose.Region = new Region(gp);
            Graphics g = e.Graphics;
            Brush white = new SolidBrush(Color.White);
            g.FillPolygon(white, crossLeft);
            g.FillPolygon(white, crossRight);
        }

        //绘制最小化标志
        Point[] minIcon = 
        {
            new Point(formWidth - buttonWidth * 3 / 2 - 2, titleHeight * 2 / 3 - 2),
            new Point(formWidth - buttonWidth * 3 / 2 + 10, titleHeight * 2 / 3 - 2),
            new Point(formWidth - buttonWidth * 3 / 2 + 10, titleHeight * 2 / 3),
            new Point(formWidth - buttonWidth * 3 / 2 - 2, titleHeight * 2 / 3)
        };
        private void buttonMin_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddPolygon(minButton);
            buttonMin.Region = new Region(gp);
            Graphics g = e.Graphics;
            Brush white = new SolidBrush(Color.White);
            g.FillPolygon(white, minIcon);
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
    }
}
