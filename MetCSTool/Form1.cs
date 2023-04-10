using MetCSTool.Tool;
using System.Runtime.CompilerServices;

namespace MetCSTool
{
    public partial class MetCSTool : Form
    {
        private readonly KeyboardHook _hook;
        private readonly TriggerBot _triggerBot;
        private readonly AutoAccept _autoaccept;
        private readonly JumpShot _jumpShot;
        private readonly FakeSpinBot _fakeSpinBot;
        private readonly AimBot _aimBot;
        private System.Windows.Forms.Timer timer1;

        public MetCSTool()
        {
            _hook = new KeyboardHook();
            _triggerBot = new TriggerBot(_hook, Keys.C);
            _autoaccept = new AutoAccept();
            _jumpShot = new JumpShot(_hook, Keys.V, Keys.Space);
            _fakeSpinBot = new FakeSpinBot(_hook, Keys.Z);
            _aimBot = new AimBot(_hook, Keys.M);

            InitializeComponent();
            InitTimer();
            CreateResolutions();

            _hook.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == _jumpShot.ToggleKey)
                {
                    if (!this.JumpShotCheckBox.Checked) { return; }
                    if (JumpShotInEnabled.Checked) { JumpShotInEnabled.Checked = false; }
                    else { JumpShotInEnabled.Checked = true; }
                }
            };
        }
        public void InitTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 5000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetRes();
        }
        private void GetRes()
        {
            this.ResolutionWidth.Value = Screen.PrimaryScreen.Bounds.Width;
            this.ResolutionHeight.Value = Screen.PrimaryScreen.Bounds.Height;
        }

        private void MainLoop_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e) { }

        private void TriggerBotCheckbox_CheckedChanged(object sender, EventArgs e)
        {

            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked) { this._triggerBot.Enabled = true; } else { this._triggerBot.Enabled = false; }
        }

        private void TriggerBotKeyPick(object sender, KeyEventArgs e)
        {
            Button button = sender as Button;
            if (button == null) { return; }
            string key = e.KeyCode.ToString();
            button.Text = key;
            this._triggerBot.Key = e.KeyCode;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            MainLoop.RunWorkerAsync();
        }

        private void TriggerLatency_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            this._triggerBot.LatencyInMs = Convert.ToInt32(numericUpDown.Value);
        }

        private void ResolutionWidth_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            _triggerBot.ResolutionWidth = Convert.ToInt32(numericUpDown.Value);
            _aimBot.ResolutionWidth = Convert.ToInt32(numericUpDown.Value);
            _autoaccept.ResolutionWidth = Convert.ToInt32(numericUpDown.Value);
        }

        private void ResolutionHeight_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            this._triggerBot.ResolutionHeight = Convert.ToInt32(numericUpDown.Value);
            this._aimBot.ResolutionHeight = Convert.ToInt32(numericUpDown.Value);
            this._autoaccept.ResolutionHeight = Convert.ToInt32(numericUpDown.Value);
        }
        private void CreateResolutions()
        {
            ResolutionList.Items.Add("4:3");
            ResolutionList.Items.Add("640x480");
            ResolutionList.Items.Add("800x600");
            ResolutionList.Items.Add("960x720");
            ResolutionList.Items.Add("1024x768");
            ResolutionList.Items.Add("1152x864");
            ResolutionList.Items.Add("1280x1024");
            ResolutionList.Items.Add("1400x1050");
            ResolutionList.Items.Add("1440x1080");
            ResolutionList.Items.Add("1600x1200");
            ResolutionList.Items.Add("1856x1392");
            ResolutionList.Items.Add("1920x1440");
            ResolutionList.Items.Add("2048x1536");
            ResolutionList.Items.Add("2560x1920");
            ResolutionList.Items.Add("2880x2160");
            ResolutionList.Items.Add("");
            ResolutionList.Items.Add("16:9");
            ResolutionList.Items.Add("640x360");
            ResolutionList.Items.Add("896x504");
            ResolutionList.Items.Add("1280x720");
            ResolutionList.Items.Add("1920x1080");
            ResolutionList.Items.Add("2048x1152");
            ResolutionList.Items.Add("2176x1224");
            ResolutionList.Items.Add("2304x1296");
            ResolutionList.Items.Add("2560x1440");
            ResolutionList.Items.Add("3840x2160");
            ResolutionList.Items.Add("3968x2232");
            ResolutionList.Items.Add("");
            ResolutionList.Items.Add("16:10");
            ResolutionList.Items.Add("3840x2400");
            ResolutionList.Items.Add("4096x2560");
        }

        private void ResolutionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox list = (ComboBox)sender;
            string[] resolution = list.SelectedItem.ToString().Split('x');
            if (resolution.Length != 2) return;
            ResolutionWidth.Value = Convert.ToDecimal(resolution[0]);
            ResolutionHeight.Value = Convert.ToDecimal(resolution[1]);
        }

        
       
        private void JumpShotCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked) { this._jumpShot.Enabled = true; this.JumpShotInEnabled.Enabled = true; }
            else { this._jumpShot.Enabled = false; this.JumpShotInEnabled.Enabled = false; }
        }

        private void JumpBindPick(object sender, KeyEventArgs e)
        {
            Button button = sender as Button;
            if (button == null) { return; }
            string key = e.KeyCode.ToString();
            button.Text = key;
            this._jumpShot.BindKey = e.KeyCode;

        }

        private void JumpTogglePick(object sender, KeyEventArgs e)
        {
            if (sender is not Button button) return;
            string key = e.KeyCode.ToString();
            button.Text = key;
            this._jumpShot.ToggleKey = e.KeyCode;

        }

        private void JumpShotInEnabled_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked) { this._jumpShot.InEnabled = true; }
            else { this._jumpShot.InEnabled = false; }
        }

        private void TriggerPlace_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton checkBox = sender as RadioButton;
            if (!checkBox.Checked) return;
            _triggerBot.TriggerPlace = checkBox.Name[checkBox.Name.Length - 1] - 48;
        }

        private void FakeSpinBotCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked) { this._fakeSpinBot.Enabled = true; } else { this._fakeSpinBot.Enabled = false; }
        }

        private void AimLatency_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            this._aimBot.LatencyInMs = Convert.ToInt32(numericUpDown.Value);
        }

        private void AimBotCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked) { this._aimBot.Enabled = true; } else { this._aimBot.Enabled = false; }

        }

        private void AimBotKeyPick(object sender, KeyEventArgs e)
        {
            Button button = sender as Button;
            if (button == null) { return; }
            string key = e.KeyCode.ToString();
            button.Text = key;
            this._aimBot.Key = e.KeyCode;

        }

        private void FakeSpinBotKeyPick(object sender, KeyEventArgs e)
        {
            Button button = sender as Button;
            if (button == null) { return; }
            string key = e.KeyCode.ToString();
            button.Text = key;
            this._fakeSpinBot.Key = e.KeyCode;

        }

        private void FluencyAimCheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked) { this._aimBot.Fluency = true; } else { this._aimBot.Fluency = false; }

        }

        private void AutoAcceptCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked) { this._autoaccept.Enabled = true; this._autoaccept.SearchAccept(); } else { this._autoaccept.Enabled = false; }
        }
    }
}