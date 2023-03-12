using System.ComponentModel;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MetCSTool.Tool
{
    internal class TriggerBot
    {
        public bool Enabled { get; set; }
        public int LatencyInMs { get; set; }
        public int ResolutionWidth { get; set; }
        public int ResolutionHeight { get; set; }
        public Keys Key { get; set; }
        private Color _color { get; set; }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);

        public const int LEFTDOWN = 0x02;
        public const int LEFTUP = 0x04;
        KeyboardHook hook = new KeyboardHook();


        private void Triggering(object? sender, DoWorkEventArgs e)
        {
            if (!Enabled) return;
            BackgroundWorker bg = (BackgroundWorker)sender;
            while (true)
            {
                TriggerBotTriggering();
                if (bg.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }
        private bool ColorCheck(Color color, Color color2)
        {
            if (Math.Abs((color.R - color2.R)) > 10) return true;
            if (Math.Abs((color.G - color2.G)) > 10) return true;
            if (Math.Abs((color.B - color2.B)) > 10) return true;
            return false;
        }
        public TriggerBot(Keys key)
        {
            this.Enabled = false;
            this.LatencyInMs = 200;
            this.Key = key;
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += Triggering;
            worker.WorkerSupportsCancellation = true;
            hook.KeyDown += (sender, e) => { if (e.KeyCode == this.Key) { worker.RunWorkerAsync(); } };
            hook.KeyUp += (sender, e) => { if (e.KeyCode == this.Key) { worker.CancelAsync(); } };
        }

        public void TriggerBotTriggering()
        {
            _color = GetColor(GetPoint());
            Color color = GetColor(GetPoint());
            if (ColorCheck(color, _color))
            {
                Thread.Sleep(LatencyInMs);
                _color = color;
                PerformLeftClick();
                Thread.Sleep(200);
            }
        }

        public Point GetPoint()
        {
            Point lpPoint;
            lpPoint = new Point();
            lpPoint.X = ResolutionWidth / 2;
            lpPoint.Y = ResolutionHeight / 2;
            return lpPoint;
        }

        public Color GetColor(Point point)
        {
            int centerX = this.ResolutionWidth / 2 + 2;
            int centerY = this.ResolutionHeight / 2 + 2;

            Bitmap screenshot = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
            Graphics gfx = Graphics.FromImage(screenshot);
            gfx.CopyFromScreen(centerX, centerY, 0, 0, new Size(1, 1), CopyPixelOperation.SourceCopy);

            Color color = screenshot.GetPixel(0,0);
            screenshot.Dispose();
            gfx.Dispose();
            return color;
        }
        private void PerformLeftClick()
        {
            mouse_event(LEFTDOWN, 0, 0, 0, 0);
            mouse_event(LEFTUP, 0, 0, 0, 0);
        }

    }
}
