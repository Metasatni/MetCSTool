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
            BunnyHopKey = new Button();
            JumpShotCheckBox = new CheckBox();
            MainTabs = new TabControl();
            TriggerBotPage = new TabPage();
            BunnyHopPage = new TabPage();
            JumpShotPage = new TabPage();
            JumpShotInEnabled = new CheckBox();
            JumpBindLabel = new Label();
            JumpBind = new Button();
            label3 = new Label();
            JumpShotKey = new Button();
            ((System.ComponentModel.ISupportInitialize)TriggerLatency).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ResolutionWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ResolutionHeight).BeginInit();
            MainTabs.SuspendLayout();
            TriggerBotPage.SuspendLayout();
            BunnyHopPage.SuspendLayout();
            JumpShotPage.SuspendLayout();
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
            TriggerBotKey.Text = "F";
            TriggerBotKey.UseVisualStyleBackColor = true;
            TriggerBotKey.Click += TriggerBotKey_Click;
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
            label1.Click += label1_Click;
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
            BunnyHopCheckBox.Size = new Size(100, 24);
            BunnyHopCheckBox.TabIndex = 11;
            BunnyHopCheckBox.Text = "BunnyHop";
            BunnyHopCheckBox.UseVisualStyleBackColor = true;
            BunnyHopCheckBox.CheckedChanged += BunnyHopCheckBox_CheckedChanged;
            // 
            // BunnyHopKey
            // 
            BunnyHopKey.Location = new Point(136, 14);
            BunnyHopKey.Name = "BunnyHopKey";
            BunnyHopKey.Size = new Size(94, 29);
            BunnyHopKey.TabIndex = 12;
            BunnyHopKey.Text = "Space";
            BunnyHopKey.UseVisualStyleBackColor = true;
            BunnyHopKey.KeyDown += BunnyHopPick;
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
            MainTabs.Controls.Add(BunnyHopPage);
            MainTabs.Controls.Add(JumpShotPage);
            MainTabs.Location = new Point(12, 77);
            MainTabs.Name = "MainTabs";
            MainTabs.SelectedIndex = 0;
            MainTabs.Size = new Size(771, 290);
            MainTabs.TabIndex = 14;
            // 
            // TriggerBotPage
            // 
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
            // BunnyHopPage
            // 
            BunnyHopPage.Controls.Add(BunnyHopCheckBox);
            BunnyHopPage.Controls.Add(BunnyHopKey);
            BunnyHopPage.Location = new Point(4, 29);
            BunnyHopPage.Name = "BunnyHopPage";
            BunnyHopPage.Padding = new Padding(3);
            BunnyHopPage.Size = new Size(763, 257);
            BunnyHopPage.TabIndex = 1;
            BunnyHopPage.Text = "BunnyHop";
            BunnyHopPage.UseVisualStyleBackColor = true;
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
            BunnyHopPage.ResumeLayout(false);
            BunnyHopPage.PerformLayout();
            JumpShotPage.ResumeLayout(false);
            JumpShotPage.PerformLayout();
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
        private Button BunnyHopKey;
        private CheckBox JumpShotCheckBox;
        private TabControl MainTabs;
        private TabPage TriggerBotPage;
        private TabPage BunnyHopPage;
        private TabPage JumpShotPage;
        private Label JumpBindLabel;
        private Button JumpBind;
        private Label label3;
        private Button JumpShotKey;
        private CheckBox JumpShotInEnabled;
    }
}