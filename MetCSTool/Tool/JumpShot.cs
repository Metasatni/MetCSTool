using System.Runtime.InteropServices;

namespace MetCSTool.Tool
{
    internal class JumpShot
    {
        private readonly KeyboardHook _hook;
        private const int JUMPSHOT_LATENCY_MS = 336;

        public bool Enabled { get; set; } = false;
        public bool InEnabled { get; set; } = true;
        public Keys ToggleKey { get; set; }
        public Keys BindKey { get; set; }
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);
        public const int LEFTDOWN = 0x02;
        public const int LEFTUP = 0x04;

        public JumpShot(KeyboardHook hook, Keys togglekey, Keys bindkey)
        {
            _hook = hook;
            this.ToggleKey = togglekey;
            this.BindKey = bindkey;

            _hook.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == this.BindKey) JumpShotActivate();
            };
        }

        private async void JumpShotActivate()
        {
            if(!this.InEnabled) return;
            if(!this.Enabled) return;
            await Task.Run( () => Thread.Sleep(JUMPSHOT_LATENCY_MS));
            PerformLeftClick();

        }

        private void PerformLeftClick()
        {
            mouse_event(LEFTDOWN, 0, 0, 0, 0);
            mouse_event(LEFTUP, 0, 0, 0, 0);
        }

    }
}
