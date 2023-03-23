namespace MetCSTool
{
    partial class MetCSTool
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TriggerBotCheckbox = new CheckBox();
            TriggerBotKey = new Button();
            MainLoop = new System.ComponentModel.BackgroundWorker();
            StartButton = new Button();
            label1 = new Label();
            TriggerLatency = new NumericUpDown();
            ResolutionWidth = new NumericUpDown();
            ResolutionHeight = new NumericUpDown();
            ScreenResLabel = new Label();
            label2 = new Label();
            ResolutionList = new ComboBox();
            BunnyHopCheckBox = new CheckBox();
            JumpShotCheckBox = new CheckBox();
            MainTabs = new TabControl();
            TriggerBotPage = new TabPage();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            TrigCheck8 = new RadioButton();
            TrigCheck5 = new RadioButton();
            TrigCheck2 = new RadioButton();
            TrigCheck7 = new RadioButton();
            TrigCheck4 = new RadioButton();
            TrigCheck1 = new RadioButton();
            TrigCheck6 = new RadioButton();
            TrigCheck3 = new RadioButton();
            TrigCheck0 = new RadioButton();
            AutoAcceptPage = new TabPage();
            JumpShotPage = new TabPage();
            JumpShotInEnabled = new CheckBox();
            JumpBindLabel = new Label();
            JumpBind = new Button();
            label3 = new Label();
            JumpShotKey = new Button();
            SpinBotPage = new TabPage();
            button1 = new Button();
            FakeSpinBotCheckBox = new CheckBox();
            AimBotPage = new TabPage();
            FluencyAimCheckBox = new CheckBox();
            AimBotKey = new Button();
            AimBotCheckBox = new CheckBox();
            label7 = new Label();
            AimBotLatency = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)TriggerLatency).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ResolutionWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ResolutionHeight).BeginInit();
            MainTabs.SuspendLayout();
            TriggerBotPage.SuspendLayout();
            panel1.SuspendLayout();
            AutoAcceptPage.SuspendLayout();
            JumpShotPage.SuspendLayout();
            SpinBotPage.SuspendLayout();
            AimBotPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AimBotLatency).BeginInit();
            SuspendLayout();
            // 
            // TriggerBotCheckbox
            // 
            TriggerBotCheckbox.AutoSize = true;
            TriggerBotCheckbox.Location = new Point(30, 17);
            TriggerBotCheckbox.Name = "TriggerBotCheckbox";
            TriggerBotCheckbox.Size = new Size(101, 24);
            TriggerBotCheckbox.TabIndex = 0;
            TriggerBotCheckbox.Text = "TriggetBot";
            TriggerBotCheckbox.UseVisualStyleBackColor = true;
            TriggerBotCheckbox.CheckedChanged += TriggerBotCheckbox_CheckedChanged;
            // 
            // TriggerBotKey
            // 
            TriggerBotKey.Location = new Point(274, 14);
            TriggerBotKey.Name = "TriggerBotKey";
            TriggerBotKey.Size = new Size(94, 29);
            TriggerBotKey.TabIndex = 2;
            TriggerBotKey.Text = "C";
            TriggerBotKey.UseVisualStyleBackColor = true;
            TriggerBotKey.KeyDown += TriggerBotKeyPick;
            // 
            // MainLoop
            // 
            MainLoop.DoWork += MainLoop_DoWork;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(694, 409);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(94, 29);
            StartButton.TabIndex = 3;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 17);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 4;
            label1.Text = "Latency";
            // 
            // TriggerLatency
            // 
            TriggerLatency.Location = new Point(206, 13);
            TriggerLatency.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            TriggerLatency.Name = "TriggerLatency";
            TriggerLatency.Size = new Size(62, 27);
            TriggerLatency.TabIndex = 5;
            TriggerLatency.Value = new decimal(new int[] { 200, 0, 0, 0 });
            TriggerLatency.ValueChanged += TriggerLatency_ValueChanged;
            // 
            // ResolutionWidth
            // 
            ResolutionWidth.Location = new Point(17, 30);
            ResolutionWidth.Maximum = new decimal(new int[] { 6000, 0, 0, 0 });
            ResolutionWidth.Name = "ResolutionWidth";
            ResolutionWidth.Size = new Size(76, 27);
            ResolutionWidth.TabIndex = 6;
            ResolutionWidth.ValueChanged += ResolutionWidth_ValueChanged;
            // 
            // ResolutionHeight
            // 
            ResolutionHeight.Location = new Point(123, 30);
            ResolutionHeight.Maximum = new decimal(new int[] { 6000, 0, 0, 0 });
            ResolutionHeight.Name = "ResolutionHeight";
            ResolutionHeight.Size = new Size(76, 27);
            ResolutionHeight.TabIndex = 7;
            ResolutionHeight.ValueChanged += ResolutionHeight_ValueChanged;
            // 
            // ScreenResLabel
            // 
            ScreenResLabel.AutoSize = true;
            ScreenResLabel.Location = new Point(46, 7);
            ScreenResLabel.Name = "ScreenResLabel";
            ScreenResLabel.Size = new Size(123, 20);
            ScreenResLabel.TabIndex = 8;
            ScreenResLabel.Text = "Screen resolution";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 32);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 9;
            label2.Text = "X";
            // 
            // ResolutionList
            // 
            ResolutionList.FormattingEnabled = true;
            ResolutionList.Location = new Point(205, 29);
            ResolutionList.Name = "ResolutionList";
            ResolutionList.Size = new Size(151, 28);
            ResolutionList.TabIndex = 10;
            ResolutionList.SelectedIndexChanged += ResolutionList_SelectedIndexChanged;
            // 
            // BunnyHopCheckBox
            // 
            BunnyHopCheckBox.AutoSize = true;
            BunnyHopCheckBox.Location = new Point(30, 17);
            BunnyHopCheckBox.Name = "BunnyHopCheckBox";
            BunnyHopCheckBox.Size = new Size(109, 24);
            BunnyHopCheckBox.TabIndex = 11;
            BunnyHopCheckBox.Text = "AutoAccept";
            BunnyHopCheckBox.UseVisualStyleBackColor = true;
            BunnyHopCheckBox.CheckedChanged += AutoAcceptCheckBox_CheckedChanged;
            // 
            // JumpShotCheckBox
            // 
            JumpShotCheckBox.AutoSize = true;
            JumpShotCheckBox.Location = new Point(30, 17);
            JumpShotCheckBox.Name = "JumpShotCheckBox";
            JumpShotCheckBox.Size = new Size(96, 24);
            JumpShotCheckBox.TabIndex = 13;
            JumpShotCheckBox.Text = "JumpShot";
            JumpShotCheckBox.UseVisualStyleBackColor = true;
            JumpShotCheckBox.CheckedChanged += JumpShotCheckBox_CheckedChanged;
            // 
            // MainTabs
            // 
            MainTabs.Controls.Add(TriggerBotPage);
            MainTabs.Controls.Add(AutoAcceptPage);
            MainTabs.Controls.Add(JumpShotPage);
            MainTabs.Controls.Add(SpinBotPage);
            MainTabs.Controls.Add(AimBotPage);
            MainTabs.Location = new Point(12, 77);
            MainTabs.Name = "MainTabs";
            MainTabs.SelectedIndex = 0;
            MainTabs.Size = new Size(771, 290);
            MainTabs.TabIndex = 14;
            // 
            // TriggerBotPage
            // 
            TriggerBotPage.Controls.Add(label6);
            TriggerBotPage.Controls.Add(label5);
            TriggerBotPage.Controls.Add(label4);
            TriggerBotPage.Controls.Add(panel1);
            TriggerBotPage.Controls.Add(TriggerBotKey);
            TriggerBotPage.Controls.Add(TriggerBotCheckbox);
            TriggerBotPage.Controls.Add(label1);
            TriggerBotPage.Controls.Add(TriggerLatency);
            TriggerBotPage.Location = new Point(4, 29);
            TriggerBotPage.Name = "TriggerBotPage";
            TriggerBotPage.Padding = new Padding(3);
            TriggerBotPage.Size = new Size(763, 257);
            TriggerBotPage.TabIndex = 0;
            TriggerBotPage.Text = "TriggerBot";
            TriggerBotPage.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(500, 65);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 9;
            label6.Text = "Trigger point";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(417, 166);
            label5.Name = "label5";
            label5.Size = new Size(282, 20);
            label5.TabIndex = 8;
            label5.Text = "Your sniper crosshair should be 1px width";
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.AutoSize = true;
            label4.Location = new Point(372, 146);
            label4.Name = "label4";
            label4.Size = new Size(379, 20);
            label4.TabIndex = 7;
            label4.Text = "Take note your crosshair can have always the same color";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.crosshair1;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(TrigCheck8);
            panel1.Controls.Add(TrigCheck5);
            panel1.Controls.Add(TrigCheck2);
            panel1.Controls.Add(TrigCheck7);
            panel1.Controls.Add(TrigCheck4);
            panel1.Controls.Add(TrigCheck1);
            panel1.Controls.Add(TrigCheck6);
            panel1.Controls.Add(TrigCheck3);
            panel1.Controls.Add(TrigCheck0);
            panel1.Location = new Point(601, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 130);
            panel1.TabIndex = 6;
            // 
            // TrigCheck8
            // 
            TrigCheck8.AutoSize = true;
            TrigCheck8.ForeColor = SystemColors.ActiveCaptionText;
            TrigCheck8.Location = new Point(113, 102);
            TrigCheck8.Name = "TrigCheck8";
            TrigCheck8.Size = new Size(17, 16);
            TrigCheck8.TabIndex = 8;
            TrigCheck8.UseVisualStyleBackColor = true;
            TrigCheck8.CheckedChanged += TriggerPlace_CheckedChanged;
            // 
            // TrigCheck5
            // 
            TrigCheck5.AutoSize = true;
            TrigCheck5.ForeColor = SystemColors.ActiveCaptionText;
            TrigCheck5.Location = new Point(113, 56);
            TrigCheck5.Name = "TrigCheck5";
            TrigCheck5.Size = new Size(17, 16);
            TrigCheck5.TabIndex = 7;
            TrigCheck5.UseVisualStyleBackColor = true;
            TrigCheck5.CheckedChanged += TriggerPlace_CheckedChanged;
            // 
            // TrigCheck2
            // 
            TrigCheck2.AutoSize = true;
            TrigCheck2.Checked = true;
            TrigCheck2.ForeColor = SystemColors.ActiveCaptionText;
            TrigCheck2.Location = new Point(113, 12);
            TrigCheck2.Name = "TrigCheck2";
            TrigCheck2.Size = new Size(17, 16);
            TrigCheck2.TabIndex = 6;
            TrigCheck2.TabStop = true;
            TrigCheck2.UseVisualStyleBackColor = true;
            TrigCheck2.CheckedChanged += TriggerPlace_CheckedChanged;
            // 
            // TrigCheck7
            // 
            TrigCheck7.AutoSize = true;
            TrigCheck7.ForeColor = SystemColors.ActiveCaptionText;
            TrigCheck7.Location = new Point(67, 102);
            TrigCheck7.Name = "TrigCheck7";
            TrigCheck7.Size = new Size(17, 16);
            TrigCheck7.TabIndex = 5;
            TrigCheck7.UseVisualStyleBackColor = true;
            TrigCheck7.CheckedChanged += TriggerPlace_CheckedChanged;
            // 
            // TrigCheck4
            // 
            TrigCheck4.AutoSize = true;
            TrigCheck4.ForeColor = SystemColors.ActiveCaptionText;
            TrigCheck4.Location = new Point(67, 56);
            TrigCheck4.Name = "TrigCheck4";
            TrigCheck4.Size = new Size(17, 16);
            TrigCheck4.TabIndex = 4;
            TrigCheck4.UseVisualStyleBackColor = true;
            TrigCheck4.CheckedChanged += TriggerPlace_CheckedChanged;
            // 
            // TrigCheck1
            // 
            TrigCheck1.AutoSize = true;
            TrigCheck1.ForeColor = SystemColors.ActiveCaptionText;
            TrigCheck1.Location = new Point(67, 12);
            TrigCheck1.Name = "TrigCheck1";
            TrigCheck1.Size = new Size(17, 16);
            TrigCheck1.TabIndex = 3;
            TrigCheck1.UseVisualStyleBackColor = true;
            TrigCheck1.CheckedChanged += TriggerPlace_CheckedChanged;
            // 
            // TrigCheck6
            // 
            TrigCheck6.AutoSize = true;
            TrigCheck6.ForeColor = SystemColors.ActiveCaptionText;
            TrigCheck6.Location = new Point(16, 102);
            TrigCheck6.Name = "TrigCheck6";
            TrigCheck6.Size = new Size(17, 16);
            TrigCheck6.TabIndex = 2;
            TrigCheck6.UseVisualStyleBackColor = true;
            TrigCheck6.CheckedChanged += TriggerPlace_CheckedChanged;
            // 
            // TrigCheck3
            // 
            TrigCheck3.AutoSize = true;
            TrigCheck3.ForeColor = SystemColors.ActiveCaptionText;
            TrigCheck3.Location = new Point(16, 56);
            TrigCheck3.Name = "TrigCheck3";
            TrigCheck3.Size = new Size(17, 16);
            TrigCheck3.TabIndex = 1;
            TrigCheck3.UseVisualStyleBackColor = true;
            TrigCheck3.CheckedChanged += TriggerPlace_CheckedChanged;
            // 
            // TrigCheck0
            // 
            TrigCheck0.AutoSize = true;
            TrigCheck0.ForeColor = SystemColors.ActiveCaptionText;
            TrigCheck0.Location = new Point(16, 12);
            TrigCheck0.Name = "TrigCheck0";
            TrigCheck0.Size = new Size(17, 16);
            TrigCheck0.TabIndex = 0;
            TrigCheck0.UseVisualStyleBackColor = true;
            TrigCheck0.CheckedChanged += TriggerPlace_CheckedChanged;
            // 
            // AutoAcceptPage
            // 
            AutoAcceptPage.Controls.Add(BunnyHopCheckBox);
            AutoAcceptPage.Location = new Point(4, 29);
            AutoAcceptPage.Name = "AutoAcceptPage";
            AutoAcceptPage.Padding = new Padding(3);
            AutoAcceptPage.Size = new Size(763, 257);
            AutoAcceptPage.TabIndex = 1;
            AutoAcceptPage.Text = "AutoAccept";
            AutoAcceptPage.UseVisualStyleBackColor = true;
            // 
            // JumpShotPage
            // 
            JumpShotPage.Controls.Add(JumpShotInEnabled);
            JumpShotPage.Controls.Add(JumpBindLabel);
            JumpShotPage.Controls.Add(JumpBind);
            JumpShotPage.Controls.Add(label3);
            JumpShotPage.Controls.Add(JumpShotKey);
            JumpShotPage.Controls.Add(JumpShotCheckBox);
            JumpShotPage.Location = new Point(4, 29);
            JumpShotPage.Name = "JumpShotPage";
            JumpShotPage.Size = new Size(763, 257);
            JumpShotPage.TabIndex = 2;
            JumpShotPage.Text = "JumpShot";
            JumpShotPage.UseVisualStyleBackColor = true;
            // 
            // JumpShotInEnabled
            // 
            JumpShotInEnabled.AutoSize = true;
            JumpShotInEnabled.Checked = true;
            JumpShotInEnabled.CheckState = CheckState.Checked;
            JumpShotInEnabled.Enabled = false;
            JumpShotInEnabled.Location = new Point(30, 47);
            JumpShotInEnabled.Name = "JumpShotInEnabled";
            JumpShotInEnabled.Size = new Size(85, 24);
            JumpShotInEnabled.TabIndex = 18;
            JumpShotInEnabled.Text = "Enabled";
            JumpShotInEnabled.UseVisualStyleBackColor = true;
            JumpShotInEnabled.CheckedChanged += JumpShotInEnabled_CheckedChanged;
            // 
            // JumpBindLabel
            // 
            JumpBindLabel.AutoSize = true;
            JumpBindLabel.Location = new Point(376, 17);
            JumpBindLabel.Name = "JumpBindLabel";
            JumpBindLabel.Size = new Size(143, 20);
            JumpBindLabel.TabIndex = 17;
            JumpBindLabel.Text = "Your jump bind in cs";
            // 
            // JumpBind
            // 
            JumpBind.Location = new Point(525, 14);
            JumpBind.Name = "JumpBind";
            JumpBind.Size = new Size(94, 29);
            JumpBind.TabIndex = 16;
            JumpBind.Text = "Space";
            JumpBind.UseVisualStyleBackColor = true;
            JumpBind.KeyDown += JumpBindPick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 17);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 15;
            label3.Text = "Toggle ON/OFF";
            // 
            // JumpShotKey
            // 
            JumpShotKey.Location = new Point(265, 14);
            JumpShotKey.Name = "JumpShotKey";
            JumpShotKey.Size = new Size(94, 29);
            JumpShotKey.TabIndex = 14;
            JumpShotKey.Text = "V";
            JumpShotKey.UseVisualStyleBackColor = true;
            JumpShotKey.KeyDown += JumpTogglePick;
            // 
            // SpinBotPage
            // 
            SpinBotPage.Controls.Add(button1);
            SpinBotPage.Controls.Add(FakeSpinBotCheckBox);
            SpinBotPage.Location = new Point(4, 29);
            SpinBotPage.Name = "SpinBotPage";
            SpinBotPage.Size = new Size(763, 257);
            SpinBotPage.TabIndex = 3;
            SpinBotPage.Text = "Fake SpinBot";
            SpinBotPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(121, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Z";
            button1.UseVisualStyleBackColor = true;
            button1.KeyDown += FakeSpinBotKeyPick;
            // 
            // FakeSpinBotCheckBox
            // 
            FakeSpinBotCheckBox.AutoSize = true;
            FakeSpinBotCheckBox.Location = new Point(30, 17);
            FakeSpinBotCheckBox.Name = "FakeSpinBotCheckBox";
            FakeSpinBotCheckBox.Size = new Size(85, 24);
            FakeSpinBotCheckBox.TabIndex = 0;
            FakeSpinBotCheckBox.Text = "Enabled";
            FakeSpinBotCheckBox.UseVisualStyleBackColor = true;
            FakeSpinBotCheckBox.CheckedChanged += FakeSpinBotCheckBox_CheckedChanged;
            // 
            // AimBotPage
            // 
            AimBotPage.Controls.Add(FluencyAimCheckBox);
            AimBotPage.Controls.Add(AimBotKey);
            AimBotPage.Controls.Add(AimBotCheckBox);
            AimBotPage.Controls.Add(label7);
            AimBotPage.Controls.Add(AimBotLatency);
            AimBotPage.Location = new Point(4, 29);
            AimBotPage.Name = "AimBotPage";
            AimBotPage.Size = new Size(763, 257);
            AimBotPage.TabIndex = 4;
            AimBotPage.Text = "AimBot";
            AimBotPage.UseVisualStyleBackColor = true;
            // 
            // FluencyAimCheckBox
            // 
            FluencyAimCheckBox.AutoSize = true;
            FluencyAimCheckBox.Location = new Point(384, 18);
            FluencyAimCheckBox.Name = "FluencyAimCheckBox";
            FluencyAimCheckBox.Size = new Size(107, 24);
            FluencyAimCheckBox.TabIndex = 10;
            FluencyAimCheckBox.Text = "FluencyAim";
            FluencyAimCheckBox.UseVisualStyleBackColor = true;
            FluencyAimCheckBox.CheckedChanged += FluencyAimCheckedChanged;
            // 
            // AimBotKey
            // 
            AimBotKey.Location = new Point(274, 15);
            AimBotKey.Name = "AimBotKey";
            AimBotKey.Size = new Size(94, 29);
            AimBotKey.TabIndex = 7;
            AimBotKey.Text = "M";
            AimBotKey.UseVisualStyleBackColor = true;
            AimBotKey.KeyDown += AimBotKeyPick;
            // 
            // AimBotCheckBox
            // 
            AimBotCheckBox.AutoSize = true;
            AimBotCheckBox.Location = new Point(30, 18);
            AimBotCheckBox.Name = "AimBotCheckBox";
            AimBotCheckBox.Size = new Size(81, 24);
            AimBotCheckBox.TabIndex = 6;
            AimBotCheckBox.Text = "AimBot";
            AimBotCheckBox.UseVisualStyleBackColor = true;
            AimBotCheckBox.CheckedChanged += AimBotCheckbox_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(141, 18);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 8;
            label7.Text = "Latency";
            // 
            // AimBotLatency
            // 
            AimBotLatency.Location = new Point(206, 14);
            AimBotLatency.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            AimBotLatency.Name = "AimBotLatency";
            AimBotLatency.Size = new Size(62, 27);
            AimBotLatency.TabIndex = 9;
            AimBotLatency.Value = new decimal(new int[] { 200, 0, 0, 0 });
            AimBotLatency.ValueChanged += AimLatency_ValueChanged;
            // 
            // MetCSTool
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainTabs);
            Controls.Add(ResolutionList);
            Controls.Add(label2);
            Controls.Add(ScreenResLabel);
            Controls.Add(ResolutionHeight);
            Controls.Add(ResolutionWidth);
            Controls.Add(StartButton);
            Name = "MetCSTool";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)TriggerLatency).EndInit();
            ((System.ComponentModel.ISupportInitialize)ResolutionWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)ResolutionHeight).EndInit();
            MainTabs.ResumeLayout(false);
            TriggerBotPage.ResumeLayout(false);
            TriggerBotPage.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            AutoAcceptPage.ResumeLayout(false);
            AutoAcceptPage.PerformLayout();
            JumpShotPage.ResumeLayout(false);
            JumpShotPage.PerformLayout();
            SpinBotPage.ResumeLayout(false);
            SpinBotPage.PerformLayout();
            AimBotPage.ResumeLayout(false);
            AimBotPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AimBotLatency).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox TriggerBotCheckbox;
        private Button TriggerBotKey;
        private System.ComponentModel.BackgroundWorker MainLoop;
        private Button StartButton;
        private Label label1;
        private NumericUpDown TriggerLatency;
        private NumericUpDown ResolutionWidth;
        private NumericUpDown ResolutionHeight;
        private Label ScreenResLabel;
        private Label label2;
        private ComboBox ResolutionList;
        private CheckBox BunnyHopCheckBox;
        private CheckBox JumpShotCheckBox;
        private TabControl MainTabs;
        private TabPage TriggerBotPage;
        private TabPage AutoAcceptPage;
        private TabPage JumpShotPage;
        private Label JumpBindLabel;
        private Button JumpBind;
        private Label label3;
        private Button JumpShotKey;
        private CheckBox JumpShotInEnabled;
        private Panel panel1;
        private RadioButton TrigCheck0;
        private RadioButton TrigCheck8;
        private RadioButton TrigCheck5;
        private RadioButton TrigCheck2;
        private RadioButton TrigCheck7;
        private RadioButton TrigCheck4;
        private RadioButton TrigCheck1;
        private RadioButton TrigCheck6;
        private RadioButton TrigCheck3;
        private Label label4;
        private Label label6;
        private Label label5;
        private TabPage SpinBotPage;
        private CheckBox FakeSpinBotCheckBox;
        private TabPage AimBotPage;
        private Button AimBotKey;
        private CheckBox AimBotCheckBox;
        private Label label7;
        private NumericUpDown AimBotLatency;
        private Button button1;
        private CheckBox FluencyAimCheckBox;
    }
}