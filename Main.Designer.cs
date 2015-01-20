namespace ArduinoPinControl
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtIncoming = new System.Windows.Forms.TextBox();
            this.gbAnalogPins = new System.Windows.Forms.GroupBox();
            this.cbLineA5 = new System.Windows.Forms.CheckBox();
            this.cbLineA4 = new System.Windows.Forms.CheckBox();
            this.cbLineA0 = new System.Windows.Forms.CheckBox();
            this.cbLineA1 = new System.Windows.Forms.CheckBox();
            this.cbLineA2 = new System.Windows.Forms.CheckBox();
            this.cbLineA3 = new System.Windows.Forms.CheckBox();
            this.gbDigitalPins = new System.Windows.Forms.GroupBox();
            this.cbLine2 = new System.Windows.Forms.CheckBox();
            this.cbLine3 = new System.Windows.Forms.CheckBox();
            this.cbLine13 = new System.Windows.Forms.CheckBox();
            this.cbLine6 = new System.Windows.Forms.CheckBox();
            this.cbLine12 = new System.Windows.Forms.CheckBox();
            this.cbLine7 = new System.Windows.Forms.CheckBox();
            this.cbLine11 = new System.Windows.Forms.CheckBox();
            this.cbLine8 = new System.Windows.Forms.CheckBox();
            this.cbLine10 = new System.Windows.Forms.CheckBox();
            this.cbLine9 = new System.Windows.Forms.CheckBox();
            this.cbLine5 = new System.Windows.Forms.CheckBox();
            this.cbLine4 = new System.Windows.Forms.CheckBox();
            this.pnlRs232 = new System.Windows.Forms.Panel();
            this.lblStopBits = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblParity = new System.Windows.Forms.Label();
            this.cmbSerialPorts = new System.Windows.Forms.ComboBox();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.lblBaud = new System.Windows.Forms.Label();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.cmbBaud = new System.Windows.Forms.ComboBox();
            this.lblCharBits = new System.Windows.Forms.Label();
            this.cmbCharBits = new System.Windows.Forms.ComboBox();
            this.cmdConnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbAnalogPins.SuspendLayout();
            this.gbDigitalPins.SuspendLayout();
            this.pnlRs232.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(1, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtIncoming);
            this.splitContainer1.Panel1.Controls.Add(this.gbAnalogPins);
            this.splitContainer1.Panel1.Controls.Add(this.gbDigitalPins);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlRs232);
            this.splitContainer1.Panel2.Controls.Add(this.cmdConnect);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(690, 298);
            this.splitContainer1.SplitterDistance = 491;
            this.splitContainer1.TabIndex = 18;
            // 
            // txtIncoming
            // 
            this.txtIncoming.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIncoming.Location = new System.Drawing.Point(261, 6);
            this.txtIncoming.Multiline = true;
            this.txtIncoming.Name = "txtIncoming";
            this.txtIncoming.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtIncoming.Size = new System.Drawing.Size(224, 289);
            this.txtIncoming.TabIndex = 19;
            this.txtIncoming.TextChanged += new System.EventHandler(this.txtIncoming_TextChanged);
            // 
            // gbAnalogPins
            // 
            this.gbAnalogPins.Controls.Add(this.cbLineA5);
            this.gbAnalogPins.Controls.Add(this.cbLineA4);
            this.gbAnalogPins.Controls.Add(this.cbLineA0);
            this.gbAnalogPins.Controls.Add(this.cbLineA1);
            this.gbAnalogPins.Controls.Add(this.cbLineA2);
            this.gbAnalogPins.Controls.Add(this.cbLineA3);
            this.gbAnalogPins.Location = new System.Drawing.Point(109, 3);
            this.gbAnalogPins.Name = "gbAnalogPins";
            this.gbAnalogPins.Size = new System.Drawing.Size(146, 152);
            this.gbAnalogPins.TabIndex = 18;
            this.gbAnalogPins.TabStop = false;
            this.gbAnalogPins.Text = "Uno Analog Pins (Unused)";
            // 
            // cbLineA5
            // 
            this.cbLineA5.AutoSize = true;
            this.cbLineA5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbLineA5.Location = new System.Drawing.Point(6, 130);
            this.cbLineA5.Name = "cbLineA5";
            this.cbLineA5.Size = new System.Drawing.Size(39, 17);
            this.cbLineA5.TabIndex = 17;
            this.cbLineA5.Text = "A5";
            this.cbLineA5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbLineA5.UseVisualStyleBackColor = true;
            this.cbLineA5.CheckedChanged += new System.EventHandler(this.cbLine_CheckedChanged);
            // 
            // cbLineA4
            // 
            this.cbLineA4.AutoSize = true;
            this.cbLineA4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbLineA4.Location = new System.Drawing.Point(6, 107);
            this.cbLineA4.Name = "cbLineA4";
            this.cbLineA4.Size = new System.Drawing.Size(39, 17);
            this.cbLineA4.TabIndex = 16;
            this.cbLineA4.Text = "A4";
            this.cbLineA4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbLineA4.UseVisualStyleBackColor = true;
            this.cbLineA4.CheckedChanged += new System.EventHandler(this.cbLine_CheckedChanged);
            // 
            // cbLineA0
            // 
            this.cbLineA0.AutoSize = true;
            this.cbLineA0.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbLineA0.Location = new System.Drawing.Point(6, 15);
            this.cbLineA0.Name = "cbLineA0";
            this.cbLineA0.Size = new System.Drawing.Size(39, 17);
            this.cbLineA0.TabIndex = 12;
            this.cbLineA0.Text = "A0";
            this.cbLineA0.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbLineA0.UseVisualStyleBackColor = true;
            this.cbLineA0.CheckedChanged += new System.EventHandler(this.cbLine_CheckedChanged);
            // 
            // cbLineA1
            // 
            this.cbLineA1.AutoSize = true;
            this.cbLineA1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbLineA1.Location = new System.Drawing.Point(6, 38);
            this.cbLineA1.Name = "cbLineA1";
            this.cbLineA1.Size = new System.Drawing.Size(39, 17);
            this.cbLineA1.TabIndex = 13;
            this.cbLineA1.Text = "A1";
            this.cbLineA1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbLineA1.UseVisualStyleBackColor = true;
            this.cbLineA1.CheckedChanged += new System.EventHandler(this.cbLine_CheckedChanged);
            // 
            // cbLineA2
            // 
            this.cbLineA2.AutoSize = true;
            this.cbLineA2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbLineA2.Location = new System.Drawing.Point(6, 61);
            this.cbLineA2.Name = "cbLineA2";
            this.cbLineA2.Size = new System.Drawing.Size(39, 17);
            this.cbLineA2.TabIndex = 14;
            this.cbLineA2.Text = "A2";
            this.cbLineA2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbLineA2.UseVisualStyleBackColor = true;
            this.cbLineA2.CheckedChanged += new System.EventHandler(this.cbLine_CheckedChanged);
            // 
            // cbLineA3
            // 
            this.cbLineA3.AutoSize = true;
            this.cbLineA3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbLineA3.Location = new System.Drawing.Point(6, 84);
            this.cbLineA3.Name = "cbLineA3";
            this.cbLineA3.Size = new System.Drawing.Size(39, 17);
            this.cbLineA3.TabIndex = 15;
            this.cbLineA3.Text = "A3";
            this.cbLineA3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbLineA3.UseVisualStyleBackColor = true;
            this.cbLineA3.CheckedChanged += new System.EventHandler(this.cbLine_CheckedChanged);
            // 
            // gbDigitalPins
            // 
            this.gbDigitalPins.Controls.Add(this.cbLine2);
            this.gbDigitalPins.Controls.Add(this.cbLine3);
            this.gbDigitalPins.Controls.Add(this.cbLine13);
            this.gbDigitalPins.Controls.Add(this.cbLine6);
            this.gbDigitalPins.Controls.Add(this.cbLine12);
            this.gbDigitalPins.Controls.Add(this.cbLine7);
            this.gbDigitalPins.Controls.Add(this.cbLine11);
            this.gbDigitalPins.Controls.Add(this.cbLine8);
            this.gbDigitalPins.Controls.Add(this.cbLine10);
            this.gbDigitalPins.Controls.Add(this.cbLine9);
            this.gbDigitalPins.Controls.Add(this.cbLine5);
            this.gbDigitalPins.Controls.Add(this.cbLine4);
            this.gbDigitalPins.Location = new System.Drawing.Point(3, 3);
            this.gbDigitalPins.Name = "gbDigitalPins";
            this.gbDigitalPins.Size = new System.Drawing.Size(100, 288);
            this.gbDigitalPins.TabIndex = 17;
            this.gbDigitalPins.TabStop = false;
            this.gbDigitalPins.Text = "Uno Digital Pins";
            // 
            // cbLine2
            // 
            this.cbLine2.AutoSize = true;
            this.cbLine2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbLine2.Location = new System.Drawing.Point(6, 15);
            this.cbLine2.Name = "cbLine2";
            this.cbLine2.Size = new System.Drawing.Size(32, 17);
            this.cbLine2.TabIndex = 0;
            this.cbLine2.Text = "2";
            this.cbLine2.UseVisualStyleBackColor = true;
            this.cbLine2.CheckedChanged += new System.EventHandler(this.cbLine_CheckedChanged);
            // 
            // cbLine3
            // 
            this.cbLine3.AutoSize = true;
            this.cbLine3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbLine3.Location = new System.Drawing.Point(6, 38);
            this.cbLine3.Name = "cbLine3";
            this.cbLine3.Size = new System.Drawing.Size(68, 17);
            this.cbLine3.TabIndex = 1;
            this.cbLine3.Text = "3 (PWM)";
            this.cbLine3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbLine3.UseVisualStyleBackColor = true;
            this.cbLine3.CheckedChanged += new System.EventHandler(this.cbLine_CheckedChanged);
            // 
            // cbLine13
            // 
            this.cbLine13.AutoSize = true;
            this.cbLine13.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbLine13.Location = new System.Drawing.Point(0, 268);
            this.cbLine13.Name = "cbLine13";
            this.cbLine13.Size = new System.Drawing.Size(38, 17);
            this.cbLine13.TabIndex = 11;
            this.cbLine13.Text = "13";
            this.cbLine13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbLine13.UseVisualStyleBackColor = true;
            this.cbLine13.CheckedChanged += new System.EventHandler(this.cbLine_CheckedChanged);
            // 
            // cbLine6
            // 
            this.cbLine6.AutoSize = true;
            this.cbLine6.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbLine6.Location = new System.Drawing.Point(6, 107);
            this.cbLine6.Name = "cbLine6";
            this.cbLine6.Size = new System.Drawing.Size(68, 17);
            this.cbLine6.TabIndex = 4;
            this.cbLine6.Text = "6 (PWM)";
            this.cbLine6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbLine6.UseVisualStyleBackColor = true;
            this.cbLine6.CheckedChanged += new System.EventHandler(this.cbLine_CheckedChanged);
            // 
            // cbLine12
            // 
            this.cbLine12.AutoSize = true;
            this.cbLine12.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbLine12.Location = new System.Drawing.Point(0, 245);
            this.cbLine12.Name = "cbLine12";
            this.cbLine12.Size = new System.Drawing.Size(38, 17);
            this.cbLine12.TabIndex = 10;
            this.cbLine12.Text = "12";
            this.cbLine12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbLine12.UseVisualStyleBackColor = true;
            this.cbLine12.CheckedChanged += new System.EventHandler(this.cbLine_CheckedChanged);
            // 
            // cbLine7
            // 
            this.cbLine7.AutoSize = true;
            this.cbLine7.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbLine7.Location = new System.Drawing.Point(6, 130);
            this.cbLine7.Name = "cbLine7";
            this.cbLine7.Size = new System.Drawing.Size(32, 17);
            this.cbLine7.TabIndex = 5;
            this.cbLine7.Text = "7";
            this.cbLine7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbLine7.UseVisualStyleBackColor = true;
            this.cbLine7.CheckedChanged += new System.EventHandler(this.cbLine_CheckedChanged);
            // 
            // cbLine11
            // 
            this.cbLine11.AutoSize = true;
            this.cbLine11.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbLine11.Location = new System.Drawing.Point(0, 222);
            this.cbLine11.Name = "cbLine11";
            this.cbLine11.Size = new System.Drawing.Size(74, 17);
            this.cbLine11.TabIndex = 9;
            this.cbLine11.Text = "11 (PWM)";
            this.cbLine11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbLine11.UseVisualStyleBackColor = true;
            this.cbLine11.CheckedChanged += new System.EventHandler(this.cbLine_CheckedChanged);
            // 
            // cbLine8
            // 
            this.cbLine8.AutoSize = true;
            this.cbLine8.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbLine8.Location = new System.Drawing.Point(6, 153);
            this.cbLine8.Name = "cbLine8";
            this.cbLine8.Size = new System.Drawing.Size(32, 17);
            this.cbLine8.TabIndex = 6;
            this.cbLine8.Text = "8";
            this.cbLine8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbLine8.UseVisualStyleBackColor = true;
            this.cbLine8.CheckedChanged += new System.EventHandler(this.cbLine_CheckedChanged);
            // 
            // cbLine10
            // 
            this.cbLine10.AutoSize = true;
            this.cbLine10.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbLine10.Location = new System.Drawing.Point(0, 199);
            this.cbLine10.Name = "cbLine10";
            this.cbLine10.Size = new System.Drawing.Size(74, 17);
            this.cbLine10.TabIndex = 8;
            this.cbLine10.Text = "10 (PWM)";
            this.cbLine10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbLine10.UseVisualStyleBackColor = true;
            this.cbLine10.CheckedChanged += new System.EventHandler(this.cbLine_CheckedChanged);
            // 
            // cbLine9
            // 
            this.cbLine9.AutoSize = true;
            this.cbLine9.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbLine9.Location = new System.Drawing.Point(6, 176);
            this.cbLine9.Name = "cbLine9";
            this.cbLine9.Size = new System.Drawing.Size(68, 17);
            this.cbLine9.TabIndex = 7;
            this.cbLine9.Text = "9 (PWM)";
            this.cbLine9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbLine9.UseVisualStyleBackColor = true;
            this.cbLine9.CheckedChanged += new System.EventHandler(this.cbLine_CheckedChanged);
            // 
            // cbLine5
            // 
            this.cbLine5.AutoSize = true;
            this.cbLine5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbLine5.Location = new System.Drawing.Point(6, 84);
            this.cbLine5.Name = "cbLine5";
            this.cbLine5.Size = new System.Drawing.Size(68, 17);
            this.cbLine5.TabIndex = 3;
            this.cbLine5.Text = "5 (PWM)";
            this.cbLine5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbLine5.UseVisualStyleBackColor = true;
            this.cbLine5.CheckedChanged += new System.EventHandler(this.cbLine_CheckedChanged);
            // 
            // cbLine4
            // 
            this.cbLine4.AutoSize = true;
            this.cbLine4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbLine4.Location = new System.Drawing.Point(6, 61);
            this.cbLine4.Name = "cbLine4";
            this.cbLine4.Size = new System.Drawing.Size(32, 17);
            this.cbLine4.TabIndex = 2;
            this.cbLine4.Text = "4";
            this.cbLine4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbLine4.UseVisualStyleBackColor = true;
            this.cbLine4.CheckedChanged += new System.EventHandler(this.cbLine_CheckedChanged);
            // 
            // pnlRs232
            // 
            this.pnlRs232.Controls.Add(this.lblStopBits);
            this.pnlRs232.Controls.Add(this.lblPort);
            this.pnlRs232.Controls.Add(this.lblParity);
            this.pnlRs232.Controls.Add(this.cmbSerialPorts);
            this.pnlRs232.Controls.Add(this.cmbStopBits);
            this.pnlRs232.Controls.Add(this.lblBaud);
            this.pnlRs232.Controls.Add(this.cmbParity);
            this.pnlRs232.Controls.Add(this.cmbBaud);
            this.pnlRs232.Controls.Add(this.lblCharBits);
            this.pnlRs232.Controls.Add(this.cmbCharBits);
            this.pnlRs232.Location = new System.Drawing.Point(1, 3);
            this.pnlRs232.Name = "pnlRs232";
            this.pnlRs232.Size = new System.Drawing.Size(152, 143);
            this.pnlRs232.TabIndex = 16;
            // 
            // lblStopBits
            // 
            this.lblStopBits.AutoSize = true;
            this.lblStopBits.Location = new System.Drawing.Point(3, 119);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(49, 13);
            this.lblStopBits.TabIndex = 26;
            this.lblStopBits.Text = "Stop Bits";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(3, 6);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(55, 13);
            this.lblPort.TabIndex = 17;
            this.lblPort.Text = "Serial Port";
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Location = new System.Drawing.Point(3, 92);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(33, 13);
            this.lblParity.TabIndex = 25;
            this.lblParity.Text = "Parity";
            // 
            // cmbSerialPorts
            // 
            this.cmbSerialPorts.FormattingEnabled = true;
            this.cmbSerialPorts.Location = new System.Drawing.Point(71, 3);
            this.cmbSerialPorts.Name = "cmbSerialPorts";
            this.cmbSerialPorts.Size = new System.Drawing.Size(75, 21);
            this.cmbSerialPorts.TabIndex = 16;
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Location = new System.Drawing.Point(71, 111);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(75, 21);
            this.cmbStopBits.TabIndex = 20;
            // 
            // lblBaud
            // 
            this.lblBaud.AutoSize = true;
            this.lblBaud.Location = new System.Drawing.Point(3, 33);
            this.lblBaud.Name = "lblBaud";
            this.lblBaud.Size = new System.Drawing.Size(32, 13);
            this.lblBaud.TabIndex = 19;
            this.lblBaud.Text = "Baud";
            // 
            // cmbParity
            // 
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Location = new System.Drawing.Point(71, 84);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(75, 21);
            this.cmbParity.TabIndex = 19;
            // 
            // cmbBaud
            // 
            this.cmbBaud.FormattingEnabled = true;
            this.cmbBaud.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.cmbBaud.Location = new System.Drawing.Point(71, 30);
            this.cmbBaud.Name = "cmbBaud";
            this.cmbBaud.Size = new System.Drawing.Size(75, 21);
            this.cmbBaud.TabIndex = 17;
            // 
            // lblCharBits
            // 
            this.lblCharBits.AutoSize = true;
            this.lblCharBits.Location = new System.Drawing.Point(3, 65);
            this.lblCharBits.Name = "lblCharBits";
            this.lblCharBits.Size = new System.Drawing.Size(49, 13);
            this.lblCharBits.TabIndex = 22;
            this.lblCharBits.Text = "Char Bits";
            // 
            // cmbCharBits
            // 
            this.cmbCharBits.FormattingEnabled = true;
            this.cmbCharBits.Location = new System.Drawing.Point(71, 57);
            this.cmbCharBits.Name = "cmbCharBits";
            this.cmbCharBits.Size = new System.Drawing.Size(75, 21);
            this.cmbCharBits.TabIndex = 18;
            // 
            // cmdConnect
            // 
            this.cmdConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdConnect.Location = new System.Drawing.Point(42, 266);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(150, 29);
            this.cmdConnect.TabIndex = 21;
            this.cmdConnect.Text = "Connect";
            this.cmdConnect.UseVisualStyleBackColor = true;
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 301);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Main";
            this.Text = "Arduino Pin Control";
            this.Load += new System.EventHandler(this.Main_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbAnalogPins.ResumeLayout(false);
            this.gbAnalogPins.PerformLayout();
            this.gbDigitalPins.ResumeLayout(false);
            this.gbDigitalPins.PerformLayout();
            this.pnlRs232.ResumeLayout(false);
            this.pnlRs232.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbAnalogPins;
        private System.Windows.Forms.CheckBox cbLineA5;
        private System.Windows.Forms.CheckBox cbLineA4;
        private System.Windows.Forms.CheckBox cbLineA0;
        private System.Windows.Forms.CheckBox cbLineA1;
        private System.Windows.Forms.CheckBox cbLineA2;
        private System.Windows.Forms.CheckBox cbLineA3;
        private System.Windows.Forms.GroupBox gbDigitalPins;
        private System.Windows.Forms.CheckBox cbLine2;
        private System.Windows.Forms.CheckBox cbLine3;
        private System.Windows.Forms.CheckBox cbLine13;
        private System.Windows.Forms.CheckBox cbLine6;
        private System.Windows.Forms.CheckBox cbLine12;
        private System.Windows.Forms.CheckBox cbLine7;
        private System.Windows.Forms.CheckBox cbLine11;
        private System.Windows.Forms.CheckBox cbLine8;
        private System.Windows.Forms.CheckBox cbLine10;
        private System.Windows.Forms.CheckBox cbLine9;
        private System.Windows.Forms.CheckBox cbLine5;
        private System.Windows.Forms.CheckBox cbLine4;
        private System.Windows.Forms.Panel pnlRs232;
        private System.Windows.Forms.Label lblStopBits;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.ComboBox cmbSerialPorts;
        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.Label lblBaud;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.ComboBox cmbBaud;
        private System.Windows.Forms.Label lblCharBits;
        private System.Windows.Forms.ComboBox cmbCharBits;
        private System.Windows.Forms.Button cmdConnect;
        private System.Windows.Forms.TextBox txtIncoming;
    }
}

