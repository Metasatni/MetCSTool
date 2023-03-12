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
            ((System.ComponentModel.ISupportInitialize)TriggerLatency).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ResolutionWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ResolutionHeight).BeginInit();
            SuspendLayout();
            // 
            // TriggerBotCheckbox
            // 
            TriggerBotCheckbox.AutoSize = true;
            TriggerBotCheckbox.Location = new Point(16, 80);
            TriggerBotCheckbox.Name = "TriggerBotCheckbox";
            TriggerBotCheckbox.Size = new Size(101, 24);
            TriggerBotCheckbox.TabIndex = 0;
            TriggerBotCheckbox.Text = "TriggetBot";
            TriggerBotCheckbox.UseVisualStyleBackColor = true;
            TriggerBotCheckbox.CheckedChanged += TriggerBotCheckbox_CheckedChanged;
            // 
            // TriggerBotKey
            // 
            TriggerBotKey.Location = new Point(256, 77);
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
            label1.Location = new Point(123, 81);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 4;
            label1.Text = "Latency";
            label1.Click += label1_Click;
            // 
            // TriggerLatency
            // 
            TriggerLatency.Location = new Point(188, 77);
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
            BunnyHopCheckBox.Location = new Point(16, 110);
            BunnyHopCheckBox.Name = "BunnyHopCheckBox";
            BunnyHopCheckBox.Size = new Size(100, 24);
            BunnyHopCheckBox.TabIndex = 11;
            BunnyHopCheckBox.Text = "BunnyHop";
            BunnyHopCheckBox.UseVisualStyleBackColor = true;
            BunnyHopCheckBox.CheckedChanged += BunnyHopCheckBox_CheckedChanged;
            // 
            // BunnyHopKey
            // 
            BunnyHopKey.Location = new Point(123, 110);
            BunnyHopKey.Name = "BunnyHopKey";
            BunnyHopKey.Size = new Size(94, 29);
            BunnyHopKey.TabIndex = 12;
            BunnyHopKey.Text = "Space";
            BunnyHopKey.UseVisualStyleBackColor = true;
            BunnyHopKey.KeyDown += BunnyHopPick;
            // 
            // MetCSTool
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BunnyHopKey);
            Controls.Add(BunnyHopCheckBox);
            Controls.Add(ResolutionList);
            Controls.Add(label2);
            Controls.Add(ScreenResLabel);
            Controls.Add(ResolutionHeight);
            Controls.Add(ResolutionWidth);
            Controls.Add(TriggerLatency);
            Controls.Add(label1);
            Controls.Add(StartButton);
            Controls.Add(TriggerBotKey);
            Controls.Add(TriggerBotCheckbox);
            Name = "MetCSTool";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)TriggerLatency).EndInit();
            ((System.ComponentModel.ISupportInitialize)ResolutionWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)ResolutionHeight).EndInit();
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
    }
}