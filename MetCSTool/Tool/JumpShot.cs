using System.Runtime.InteropServices;

namespace MetCSTool.Tool
{
    internal class JumpShot
    {
        public bool Enabled { get; set; }
        public bool InEnabled { get; set; }
        public int LatencyInMs { get; set; }
        public Keys ToggleKey { get; set; }
        public Keys BindKey { get; set; }
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);
        public const int LEFTDOWN = 0x02;
        public const int LEFTUP = 0x04;

        KeyboardHook hook = new KeyboardHook();


        public JumpShot(Keys togglekey, Keys bindkey)
        {
            this.Enabled = false;
            this.InEnabled = true;
            this.LatencyInMs = 336;
            this.ToggleKey = togglekey;
            this.BindKey = bindkey;
            hook.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == this.BindKey) { JumpShotActivate(); } 
            };
        }
        private async void JumpShotActivate()
        {
            if(!this.InEnabled) return;
            if(!this.Enabled) return;
            await Task.Run( () => Thread.Sleep(LatencyInMs));
            PerformLeftClick();

        }
        private void PerformLeftClick()
        {
            mouse_event(LEFTDOWN, 0, 0, 0, 0);
            mouse_event(LEFTUP, 0, 0, 0, 0);
        }
    }
}
