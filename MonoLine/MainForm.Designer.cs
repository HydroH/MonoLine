namespace MonoLine
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.buttonEvaluate = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.information = new System.Windows.Forms.Label();
            this.panelDrag = new System.Windows.Forms.Panel();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.logoPicBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.buttonBin = new System.Windows.Forms.Button();
            this.buttonOct = new System.Windows.Forms.Button();
            this.buttonDec = new System.Windows.Forms.Button();
            this.buttonHex = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonDeg = new System.Windows.Forms.Button();
            this.buttonCos = new System.Windows.Forms.Button();
            this.buttonSin = new System.Windows.Forms.Button();
            this.buttonLn = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonCot = new System.Windows.Forms.Button();
            this.buttonTan = new System.Windows.Forms.Button();
            this.buttonEn = new System.Windows.Forms.Button();
            this.buttonPi = new System.Windows.Forms.Button();
            this.buttonCsc = new System.Windows.Forms.Button();
            this.buttonSec = new System.Windows.Forms.Button();
            this.buttonExpand = new System.Windows.Forms.Button();
            this.buttonM4 = new System.Windows.Forms.Button();
            this.buttonM3 = new System.Windows.Forms.Button();
            this.buttonM2 = new System.Windows.Forms.Button();
            this.buttonM1 = new System.Windows.Forms.Button();
            this.textBoxM1 = new System.Windows.Forms.TextBox();
            this.textBoxM2 = new System.Windows.Forms.TextBox();
            this.textBoxM3 = new System.Windows.Forms.TextBox();
            this.textBoxM4 = new System.Windows.Forms.TextBox();
            this.buttonIm4 = new System.Windows.Forms.Button();
            this.buttonIm3 = new System.Windows.Forms.Button();
            this.buttonIm2 = new System.Windows.Forms.Button();
            this.buttonIm1 = new System.Windows.Forms.Button();
            this.panelDrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEvaluate
            // 
            this.buttonEvaluate.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonEvaluate.FlatAppearance.BorderSize = 0;
            this.buttonEvaluate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEvaluate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonEvaluate.ForeColor = System.Drawing.Color.White;
            this.buttonEvaluate.Location = new System.Drawing.Point(545, 108);
            this.buttonEvaluate.Name = "buttonEvaluate";
            this.buttonEvaluate.Size = new System.Drawing.Size(75, 23);
            this.buttonEvaluate.TabIndex = 0;
            this.buttonEvaluate.TabStop = false;
            this.buttonEvaluate.Text = "Evaluate";
            this.buttonEvaluate.UseVisualStyleBackColor = false;
            this.buttonEvaluate.Click += new System.EventHandler(this.buttonEvaluate_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox.Location = new System.Drawing.Point(155, 108);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(390, 23);
            this.textBox.TabIndex = 0;
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // messageLabel
            // 
            this.messageLabel.BackColor = System.Drawing.Color.Transparent;
            this.messageLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.messageLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.messageLabel.Location = new System.Drawing.Point(374, 131);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.messageLabel.Size = new System.Drawing.Size(249, 23);
            this.messageLabel.TabIndex = 1;
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // information
            // 
            this.information.AutoSize = true;
            this.information.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.information.Location = new System.Drawing.Point(409, 83);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(194, 17);
            this.information.TabIndex = 2;
            this.information.Text = "V2.7β by Iodizon  Copyleft 2015";
            // 
            // panelDrag
            // 
            this.panelDrag.BackColor = System.Drawing.Color.Transparent;
            this.panelDrag.Controls.Add(this.buttonMin);
            this.panelDrag.Controls.Add(this.buttonClose);
            this.panelDrag.Location = new System.Drawing.Point(0, 0);
            this.panelDrag.Name = "panelDrag";
            this.panelDrag.Size = new System.Drawing.Size(1500, 30);
            this.panelDrag.TabIndex = 4;
            this.panelDrag.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDrag_Paint);
            this.panelDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gPanelTitleBack_MouseDown);
            // 
            // buttonMin
            // 
            this.buttonMin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonMin.FlatAppearance.BorderSize = 0;
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.Location = new System.Drawing.Point(0, 0);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(1500, 30);
            this.buttonMin.TabIndex = 7;
            this.buttonMin.TabStop = false;
            this.buttonMin.UseVisualStyleBackColor = false;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            this.buttonMin.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonMin_Paint);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.DarkRed;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(0, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(1500, 30);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.TabStop = false;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonClose_Paint);
            // 
            // logoPicBox
            // 
            this.logoPicBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPicBox.Image = global::MonoLine.Properties.Resources.LogoPic;
            this.logoPicBox.Location = new System.Drawing.Point(13, 10);
            this.logoPicBox.Name = "logoPicBox";
            this.logoPicBox.Size = new System.Drawing.Size(132, 132);
            this.logoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicBox.TabIndex = 5;
            this.logoPicBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("微软雅黑 Light", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.titleLabel.Location = new System.Drawing.Point(142, 33);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(275, 70);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "MonoLine";
            // 
            // buttonBin
            // 
            this.buttonBin.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonBin.FlatAppearance.BorderSize = 0;
            this.buttonBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonBin.ForeColor = System.Drawing.Color.White;
            this.buttonBin.Location = new System.Drawing.Point(19, 160);
            this.buttonBin.Name = "buttonBin";
            this.buttonBin.Size = new System.Drawing.Size(75, 23);
            this.buttonBin.TabIndex = 7;
            this.buttonBin.Text = "Bin";
            this.buttonBin.UseVisualStyleBackColor = false;
            // 
            // buttonOct
            // 
            this.buttonOct.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOct.FlatAppearance.BorderSize = 0;
            this.buttonOct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOct.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOct.ForeColor = System.Drawing.Color.White;
            this.buttonOct.Location = new System.Drawing.Point(100, 160);
            this.buttonOct.Name = "buttonOct";
            this.buttonOct.Size = new System.Drawing.Size(75, 23);
            this.buttonOct.TabIndex = 8;
            this.buttonOct.Text = "Oct";
            this.buttonOct.UseVisualStyleBackColor = false;
            // 
            // buttonDec
            // 
            this.buttonDec.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonDec.FlatAppearance.BorderSize = 0;
            this.buttonDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDec.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDec.ForeColor = System.Drawing.Color.White;
            this.buttonDec.Location = new System.Drawing.Point(181, 160);
            this.buttonDec.Name = "buttonDec";
            this.buttonDec.Size = new System.Drawing.Size(75, 23);
            this.buttonDec.TabIndex = 9;
            this.buttonDec.Text = "Dec";
            this.buttonDec.UseVisualStyleBackColor = false;
            // 
            // buttonHex
            // 
            this.buttonHex.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHex.FlatAppearance.BorderSize = 0;
            this.buttonHex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHex.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonHex.ForeColor = System.Drawing.Color.White;
            this.buttonHex.Location = new System.Drawing.Point(262, 160);
            this.buttonHex.Name = "buttonHex";
            this.buttonHex.Size = new System.Drawing.Size(75, 23);
            this.buttonHex.TabIndex = 10;
            this.buttonHex.Text = "Hex";
            this.buttonHex.UseVisualStyleBackColor = false;
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSqrt.FlatAppearance.BorderSize = 0;
            this.buttonSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSqrt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSqrt.ForeColor = System.Drawing.Color.White;
            this.buttonSqrt.Location = new System.Drawing.Point(262, 189);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(75, 23);
            this.buttonSqrt.TabIndex = 14;
            this.buttonSqrt.Text = "√";
            this.buttonSqrt.UseVisualStyleBackColor = false;
            this.buttonSqrt.Click += new System.EventHandler(this.buttonSqrt_Click);
            // 
            // buttonDeg
            // 
            this.buttonDeg.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonDeg.FlatAppearance.BorderSize = 0;
            this.buttonDeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeg.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDeg.ForeColor = System.Drawing.Color.White;
            this.buttonDeg.Location = new System.Drawing.Point(181, 189);
            this.buttonDeg.Name = "buttonDeg";
            this.buttonDeg.Size = new System.Drawing.Size(75, 23);
            this.buttonDeg.TabIndex = 13;
            this.buttonDeg.Text = "°";
            this.buttonDeg.UseVisualStyleBackColor = false;
            this.buttonDeg.Click += new System.EventHandler(this.buttonDeg_Click);
            // 
            // buttonCos
            // 
            this.buttonCos.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonCos.FlatAppearance.BorderSize = 0;
            this.buttonCos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCos.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCos.ForeColor = System.Drawing.Color.White;
            this.buttonCos.Location = new System.Drawing.Point(100, 189);
            this.buttonCos.Name = "buttonCos";
            this.buttonCos.Size = new System.Drawing.Size(75, 23);
            this.buttonCos.TabIndex = 12;
            this.buttonCos.Text = "Cos";
            this.buttonCos.UseVisualStyleBackColor = false;
            this.buttonCos.Click += new System.EventHandler(this.buttonCos_Click);
            // 
            // buttonSin
            // 
            this.buttonSin.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSin.FlatAppearance.BorderSize = 0;
            this.buttonSin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSin.ForeColor = System.Drawing.Color.White;
            this.buttonSin.Location = new System.Drawing.Point(19, 189);
            this.buttonSin.Name = "buttonSin";
            this.buttonSin.Size = new System.Drawing.Size(75, 23);
            this.buttonSin.TabIndex = 11;
            this.buttonSin.Text = "Sin";
            this.buttonSin.UseVisualStyleBackColor = false;
            this.buttonSin.Click += new System.EventHandler(this.buttonSin_Click);
            // 
            // buttonLn
            // 
            this.buttonLn.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonLn.FlatAppearance.BorderSize = 0;
            this.buttonLn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLn.ForeColor = System.Drawing.Color.White;
            this.buttonLn.Location = new System.Drawing.Point(262, 218);
            this.buttonLn.Name = "buttonLn";
            this.buttonLn.Size = new System.Drawing.Size(75, 23);
            this.buttonLn.TabIndex = 18;
            this.buttonLn.Text = "Ln";
            this.buttonLn.UseVisualStyleBackColor = false;
            this.buttonLn.Click += new System.EventHandler(this.buttonLn_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonLog.FlatAppearance.BorderSize = 0;
            this.buttonLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLog.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLog.ForeColor = System.Drawing.Color.White;
            this.buttonLog.Location = new System.Drawing.Point(181, 218);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(75, 23);
            this.buttonLog.TabIndex = 17;
            this.buttonLog.Text = "Log";
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // buttonCot
            // 
            this.buttonCot.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonCot.FlatAppearance.BorderSize = 0;
            this.buttonCot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCot.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCot.ForeColor = System.Drawing.Color.White;
            this.buttonCot.Location = new System.Drawing.Point(100, 218);
            this.buttonCot.Name = "buttonCot";
            this.buttonCot.Size = new System.Drawing.Size(75, 23);
            this.buttonCot.TabIndex = 16;
            this.buttonCot.Text = "Cot";
            this.buttonCot.UseVisualStyleBackColor = false;
            this.buttonCot.Click += new System.EventHandler(this.buttonCot_Click);
            // 
            // buttonTan
            // 
            this.buttonTan.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonTan.FlatAppearance.BorderSize = 0;
            this.buttonTan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTan.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTan.ForeColor = System.Drawing.Color.White;
            this.buttonTan.Location = new System.Drawing.Point(19, 218);
            this.buttonTan.Name = "buttonTan";
            this.buttonTan.Size = new System.Drawing.Size(75, 23);
            this.buttonTan.TabIndex = 15;
            this.buttonTan.Text = "Tan";
            this.buttonTan.UseVisualStyleBackColor = false;
            this.buttonTan.Click += new System.EventHandler(this.buttonTan_Click);
            // 
            // buttonEn
            // 
            this.buttonEn.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonEn.FlatAppearance.BorderSize = 0;
            this.buttonEn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonEn.ForeColor = System.Drawing.Color.White;
            this.buttonEn.Location = new System.Drawing.Point(262, 247);
            this.buttonEn.Name = "buttonEn";
            this.buttonEn.Size = new System.Drawing.Size(75, 23);
            this.buttonEn.TabIndex = 22;
            this.buttonEn.Text = "e";
            this.buttonEn.UseVisualStyleBackColor = false;
            this.buttonEn.Click += new System.EventHandler(this.buttonEn_Click);
            // 
            // buttonPi
            // 
            this.buttonPi.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonPi.FlatAppearance.BorderSize = 0;
            this.buttonPi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPi.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPi.ForeColor = System.Drawing.Color.White;
            this.buttonPi.Location = new System.Drawing.Point(181, 247);
            this.buttonPi.Name = "buttonPi";
            this.buttonPi.Size = new System.Drawing.Size(75, 23);
            this.buttonPi.TabIndex = 21;
            this.buttonPi.Text = "π";
            this.buttonPi.UseVisualStyleBackColor = false;
            this.buttonPi.Click += new System.EventHandler(this.buttonPi_Click);
            // 
            // buttonCsc
            // 
            this.buttonCsc.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonCsc.FlatAppearance.BorderSize = 0;
            this.buttonCsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCsc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCsc.ForeColor = System.Drawing.Color.White;
            this.buttonCsc.Location = new System.Drawing.Point(100, 247);
            this.buttonCsc.Name = "buttonCsc";
            this.buttonCsc.Size = new System.Drawing.Size(75, 23);
            this.buttonCsc.TabIndex = 20;
            this.buttonCsc.Text = "Csc";
            this.buttonCsc.UseVisualStyleBackColor = false;
            this.buttonCsc.Click += new System.EventHandler(this.buttonCsc_Click);
            // 
            // buttonSec
            // 
            this.buttonSec.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSec.FlatAppearance.BorderSize = 0;
            this.buttonSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSec.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSec.ForeColor = System.Drawing.Color.White;
            this.buttonSec.Location = new System.Drawing.Point(19, 247);
            this.buttonSec.Name = "buttonSec";
            this.buttonSec.Size = new System.Drawing.Size(75, 23);
            this.buttonSec.TabIndex = 19;
            this.buttonSec.Text = "Sec";
            this.buttonSec.UseVisualStyleBackColor = false;
            this.buttonSec.Click += new System.EventHandler(this.buttonSec_Click);
            // 
            // buttonExpand
            // 
            this.buttonExpand.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonExpand.FlatAppearance.BorderSize = 0;
            this.buttonExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExpand.ForeColor = System.Drawing.Color.White;
            this.buttonExpand.Location = new System.Drawing.Point(0, 0);
            this.buttonExpand.Name = "buttonExpand";
            this.buttonExpand.Size = new System.Drawing.Size(650, 400);
            this.buttonExpand.TabIndex = 23;
            this.buttonExpand.TabStop = false;
            this.buttonExpand.UseVisualStyleBackColor = false;
            this.buttonExpand.Click += new System.EventHandler(this.buttonExpand_Click);
            this.buttonExpand.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonExpand_Paint);
            // 
            // buttonM4
            // 
            this.buttonM4.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonM4.FlatAppearance.BorderSize = 0;
            this.buttonM4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonM4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonM4.ForeColor = System.Drawing.Color.White;
            this.buttonM4.Location = new System.Drawing.Point(360, 247);
            this.buttonM4.Name = "buttonM4";
            this.buttonM4.Size = new System.Drawing.Size(51, 23);
            this.buttonM4.TabIndex = 27;
            this.buttonM4.Text = "M4";
            this.buttonM4.UseVisualStyleBackColor = false;
            this.buttonM4.Click += new System.EventHandler(this.buttonM4_Click);
            // 
            // buttonM3
            // 
            this.buttonM3.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonM3.FlatAppearance.BorderSize = 0;
            this.buttonM3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonM3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonM3.ForeColor = System.Drawing.Color.White;
            this.buttonM3.Location = new System.Drawing.Point(360, 218);
            this.buttonM3.Name = "buttonM3";
            this.buttonM3.Size = new System.Drawing.Size(51, 23);
            this.buttonM3.TabIndex = 26;
            this.buttonM3.Text = "M3";
            this.buttonM3.UseVisualStyleBackColor = false;
            this.buttonM3.Click += new System.EventHandler(this.buttonM3_Click);
            // 
            // buttonM2
            // 
            this.buttonM2.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonM2.FlatAppearance.BorderSize = 0;
            this.buttonM2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonM2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonM2.ForeColor = System.Drawing.Color.White;
            this.buttonM2.Location = new System.Drawing.Point(360, 189);
            this.buttonM2.Name = "buttonM2";
            this.buttonM2.Size = new System.Drawing.Size(51, 23);
            this.buttonM2.TabIndex = 25;
            this.buttonM2.Text = "M2";
            this.buttonM2.UseVisualStyleBackColor = false;
            this.buttonM2.Click += new System.EventHandler(this.buttonM2_Click);
            // 
            // buttonM1
            // 
            this.buttonM1.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonM1.FlatAppearance.BorderSize = 0;
            this.buttonM1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonM1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonM1.ForeColor = System.Drawing.Color.White;
            this.buttonM1.Location = new System.Drawing.Point(360, 160);
            this.buttonM1.Name = "buttonM1";
            this.buttonM1.Size = new System.Drawing.Size(51, 23);
            this.buttonM1.TabIndex = 24;
            this.buttonM1.Text = "M1";
            this.buttonM1.UseVisualStyleBackColor = false;
            this.buttonM1.Click += new System.EventHandler(this.buttonM1_Click);
            // 
            // textBoxM1
            // 
            this.textBoxM1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxM1.Location = new System.Drawing.Point(411, 160);
            this.textBoxM1.Name = "textBoxM1";
            this.textBoxM1.Size = new System.Drawing.Size(180, 23);
            this.textBoxM1.TabIndex = 28;
            // 
            // textBoxM2
            // 
            this.textBoxM2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxM2.Location = new System.Drawing.Point(411, 189);
            this.textBoxM2.Name = "textBoxM2";
            this.textBoxM2.Size = new System.Drawing.Size(180, 23);
            this.textBoxM2.TabIndex = 29;
            // 
            // textBoxM3
            // 
            this.textBoxM3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxM3.Location = new System.Drawing.Point(411, 218);
            this.textBoxM3.Name = "textBoxM3";
            this.textBoxM3.Size = new System.Drawing.Size(180, 23);
            this.textBoxM3.TabIndex = 30;
            // 
            // textBoxM4
            // 
            this.textBoxM4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxM4.Location = new System.Drawing.Point(411, 247);
            this.textBoxM4.Name = "textBoxM4";
            this.textBoxM4.Size = new System.Drawing.Size(180, 23);
            this.textBoxM4.TabIndex = 31;
            // 
            // buttonIm4
            // 
            this.buttonIm4.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonIm4.FlatAppearance.BorderSize = 0;
            this.buttonIm4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIm4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonIm4.ForeColor = System.Drawing.Color.White;
            this.buttonIm4.Location = new System.Drawing.Point(591, 247);
            this.buttonIm4.Name = "buttonIm4";
            this.buttonIm4.Size = new System.Drawing.Size(38, 23);
            this.buttonIm4.TabIndex = 35;
            this.buttonIm4.Text = "←";
            this.buttonIm4.UseVisualStyleBackColor = false;
            this.buttonIm4.Click += new System.EventHandler(this.buttonIm4_Click);
            // 
            // buttonIm3
            // 
            this.buttonIm3.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonIm3.FlatAppearance.BorderSize = 0;
            this.buttonIm3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIm3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonIm3.ForeColor = System.Drawing.Color.White;
            this.buttonIm3.Location = new System.Drawing.Point(591, 218);
            this.buttonIm3.Name = "buttonIm3";
            this.buttonIm3.Size = new System.Drawing.Size(38, 23);
            this.buttonIm3.TabIndex = 34;
            this.buttonIm3.Text = "←";
            this.buttonIm3.UseVisualStyleBackColor = false;
            this.buttonIm3.Click += new System.EventHandler(this.buttonIm3_Click);
            // 
            // buttonIm2
            // 
            this.buttonIm2.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonIm2.FlatAppearance.BorderSize = 0;
            this.buttonIm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIm2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonIm2.ForeColor = System.Drawing.Color.White;
            this.buttonIm2.Location = new System.Drawing.Point(591, 189);
            this.buttonIm2.Name = "buttonIm2";
            this.buttonIm2.Size = new System.Drawing.Size(38, 23);
            this.buttonIm2.TabIndex = 33;
            this.buttonIm2.Text = "←";
            this.buttonIm2.UseVisualStyleBackColor = false;
            this.buttonIm2.Click += new System.EventHandler(this.buttonIm2_Click);
            // 
            // buttonIm1
            // 
            this.buttonIm1.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonIm1.FlatAppearance.BorderSize = 0;
            this.buttonIm1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIm1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonIm1.ForeColor = System.Drawing.Color.White;
            this.buttonIm1.Location = new System.Drawing.Point(591, 160);
            this.buttonIm1.Name = "buttonIm1";
            this.buttonIm1.Size = new System.Drawing.Size(38, 23);
            this.buttonIm1.TabIndex = 32;
            this.buttonIm1.Text = "←";
            this.buttonIm1.UseVisualStyleBackColor = false;
            this.buttonIm1.Click += new System.EventHandler(this.buttonIm1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(650, 155);
            this.Controls.Add(this.buttonIm4);
            this.Controls.Add(this.buttonIm3);
            this.Controls.Add(this.buttonIm2);
            this.Controls.Add(this.buttonIm1);
            this.Controls.Add(this.textBoxM4);
            this.Controls.Add(this.textBoxM3);
            this.Controls.Add(this.textBoxM2);
            this.Controls.Add(this.textBoxM1);
            this.Controls.Add(this.buttonM4);
            this.Controls.Add(this.buttonM3);
            this.Controls.Add(this.buttonM2);
            this.Controls.Add(this.buttonM1);
            this.Controls.Add(this.buttonEn);
            this.Controls.Add(this.buttonPi);
            this.Controls.Add(this.buttonCsc);
            this.Controls.Add(this.buttonSec);
            this.Controls.Add(this.buttonLn);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonCot);
            this.Controls.Add(this.buttonTan);
            this.Controls.Add(this.buttonSqrt);
            this.Controls.Add(this.buttonDeg);
            this.Controls.Add(this.buttonCos);
            this.Controls.Add(this.buttonSin);
            this.Controls.Add(this.buttonHex);
            this.Controls.Add(this.buttonDec);
            this.Controls.Add(this.buttonOct);
            this.Controls.Add(this.buttonBin);
            this.Controls.Add(this.buttonEvaluate);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.panelDrag);
            this.Controls.Add(this.information);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.logoPicBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.buttonExpand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "MonoLine";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panelDrag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEvaluate;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label information;
        private System.Windows.Forms.Panel panelDrag;
        private System.Windows.Forms.PictureBox logoPicBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonBin;
        private System.Windows.Forms.Button buttonOct;
        private System.Windows.Forms.Button buttonDec;
        private System.Windows.Forms.Button buttonHex;
        private System.Windows.Forms.Button buttonSqrt;
        private System.Windows.Forms.Button buttonDeg;
        private System.Windows.Forms.Button buttonCos;
        private System.Windows.Forms.Button buttonSin;
        private System.Windows.Forms.Button buttonLn;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonCot;
        private System.Windows.Forms.Button buttonTan;
        private System.Windows.Forms.Button buttonEn;
        private System.Windows.Forms.Button buttonPi;
        private System.Windows.Forms.Button buttonCsc;
        private System.Windows.Forms.Button buttonSec;
        private System.Windows.Forms.Button buttonExpand;
        private System.Windows.Forms.Button buttonM4;
        private System.Windows.Forms.Button buttonM3;
        private System.Windows.Forms.Button buttonM2;
        private System.Windows.Forms.Button buttonM1;
        private System.Windows.Forms.TextBox textBoxM1;
        private System.Windows.Forms.TextBox textBoxM2;
        private System.Windows.Forms.TextBox textBoxM3;
        private System.Windows.Forms.TextBox textBoxM4;
        private System.Windows.Forms.Button buttonIm4;
        private System.Windows.Forms.Button buttonIm3;
        private System.Windows.Forms.Button buttonIm2;
        private System.Windows.Forms.Button buttonIm1;
    }
}

