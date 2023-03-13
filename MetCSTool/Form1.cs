using MetCSTool.Tool;
using System.Runtime.CompilerServices;

namespace MetCSTool
{
    public partial class MetCSTool : Form
    {
        KeyboardHook hook = new KeyboardHook();
        TriggerBot TriggerBot = new TriggerBot(Keys.F);
        BunnyHop BunnyHop = new BunnyHop(Keys.Space);
        JumpShot JumpShot = new JumpShot(Keys.V, Keys.Space);
        public MetCSTool()
        {
            InitializeComponent();
            this.ResolutionWidth.Value = Screen.PrimaryScreen.Bounds.Width;
            this.ResolutionHeight.Value = Screen.PrimaryScreen.Bounds.Height;
            AddResolutions();

            KeyboardHook hook = new KeyboardHook();

            hook.KeyDown += (sender, e) => { if (e.KeyCode == this.JumpShot.ToggleKey) { 
                    if(!this.JumpShotCheckBox.Checked) { return; }
                    if(JumpShotInEnabled.Checked) { JumpShotInEnabled.Checked = false; }
                    else { JumpShotInEnabled.Checked = true; }
                } };
        }

        private void MainLoop_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
        }
        private void TriggerBotCheckbox_CheckedChanged(object sender, EventArgs e)
        {

            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked) { this.TriggerBot.Enabled = true; } else { this.TriggerBot.Enabled = false; }
        }

        private void TriggerBotKeyPick(object sender, KeyEventArgs e)
        {
            Button button = sender as Button;
            if (button == null) { return; }
            string key = e.KeyCode.ToString();
            button.Text = key;
            this.TriggerBot.Key = e.KeyCode;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            MainLoop.RunWorkerAsync();
        }

        private void TriggerBotKey_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TriggerLatency_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            this.TriggerBot.LatencyInMs = Convert.ToInt32(numericUpDown.Value);
        }

        private void ResolutionWidth_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            this.TriggerBot.ResolutionWidth = Convert.ToInt32(numericUpDown.Value);
        }

        private void ResolutionHeight_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            this.TriggerBot.ResolutionHeight = Convert.ToInt32(numericUpDown.Value);
        }
        private void AddResolutions()
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

        private void BunnyHopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked) { this.BunnyHop.Enabled = true; } else { this.BunnyHop.Enabled = false; }
        }

        private void BunnyHopPick(object sender, KeyEventArgs e)
        {
            Button button = sender as Button;
            if (button == null) { return; }
            string key = e.KeyCode.ToString();
            button.Text = key;
            this.BunnyHop.Key = e.KeyCode;
        }

        private void JumpShotCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked) { this.JumpShot.Enabled = true; this.JumpShotInEnabled.Enabled = true; }
            else { this.JumpShot.Enabled = false; this.JumpShotInEnabled.Enabled = false; }
        }

        private void JumpBindPick(object sender, KeyEventArgs e)
        {
            Button button = sender as Button;
            if (button == null) { return; }
            string key = e.KeyCode.ToString();
            button.Text = key;
            this.JumpShot.BindKey = e.KeyCode;

        }

        private void JumpTogglePick(object sender, KeyEventArgs e)
        {
            Button button = sender as Button;
            if (button == null) { return; }
            string key = e.KeyCode.ToString();
            button.Text = key;
            this.JumpShot.ToggleKey = e.KeyCode;

        }

        private void JumpShotInEnabled_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked) { this.JumpShot.InEnabled = true; }
            else { this.JumpShot.InEnabled = false; }
        }
    }
}