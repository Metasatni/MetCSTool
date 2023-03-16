using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing.Imaging;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace MetCSTool.Tool
{
    internal class TriggerBot
    {
        public bool Enabled { get; set; }
        public int LatencyInMs { get; set; }
        public int ResolutionWidth { get; set; }
        public int ResolutionHeight { get; set; }
        public int TriggerPlace { get; set; }
        public Keys Key { get; set; }
        private Color _color { get; set; }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);

        public const int LEFTDOWN = 0x02;
        public const int LEFTUP = 0x04;
        KeyboardHook hook = new KeyboardHook();

        public TriggerBot(Keys key)
        {
            this.Enabled = false;
            this.LatencyInMs = 200;
            this.Key = key;
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += Triggering;
            worker.WorkerSupportsCancellation = true;
            this.TriggerPlace = 2;
            hook.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == this.Key)
                {
                    if (worker.IsBusy) return;
                    worker.RunWorkerAsync();
                }
            };

            hook.KeyUp += (sender, e) => { if (e.KeyCode == this.Key) { worker.CancelAsync(); } };
        }

        private void Triggering(object? sender, DoWorkEventArgs e)
        {
            if (!Enabled) return;
            BackgroundWorker bg = (BackgroundWorker)sender;
            while (true)
            {
                TriggerBotTriggering();
                if (bg.CancellationPending)
                {
                    bg.Dispose();
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

        public void TriggerBotTriggering()
        {
            _color = GetColor(GetPoint());
            Thread.Sleep(3);
            Color color = GetColor(GetPoint());
            Bitmap ss1 = TookScreenshot();
            Thread.Sleep(3);
            Bitmap ss2 = TookScreenshot();

            if (FlashCheck(ss1, ss2)) { 
                return;
            }
            if (ColorCheck(color, _color))
            {
                Thread.Sleep(LatencyInMs);
                _color = color;
                PerformLeftClick();
                Thread.Sleep(500);
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
        private bool FlashCheck(Bitmap screenshot, Bitmap screenshot2)
        {
            List<int> rgbs1 = new List<int>();
            List<int> rgbs2 = new List<int>();
            int counter = 0;
            

           for(int i = 0; i < screenshot.Width; i++)
            {
                for (int j = 0; j < screenshot.Height; j++)
                {
                    rgbs1.Add(screenshot.GetPixel(i, j).R);
                    rgbs1.Add(screenshot.GetPixel(i, j).G);
                    rgbs1.Add(screenshot.GetPixel(i, j).B);
                }
            } 
            for(int i = 0; i < screenshot2.Width; i++)
            {
                for (int j = 0; j < screenshot2.Height; j++)
                {
                    rgbs2.Add(screenshot2.GetPixel(i, j).R);
                    rgbs2.Add(screenshot2.GetPixel(i, j).G);
                    rgbs2.Add(screenshot2.GetPixel(i, j).B);
                }
            } 
            for(int i = 0; i < rgbs1.Count; i++)
            {
                if(rgbs2[i] > rgbs1[i] ) {
                    counter++;
                }
            }
            if (counter / rgbs1.Count > 0.99)
                return true;
            return false;

        }
        private Bitmap TookScreenshot()
        {
            int centerX = this.ResolutionWidth / 2;
            int centerY = this.ResolutionHeight / 2;

            Bitmap screenshot = new Bitmap(10, 10, PixelFormat.Format32bppArgb);
            Graphics gfx = Graphics.FromImage(screenshot);
            gfx.CopyFromScreen(centerX - 5, centerY - 5, 0, 0, new Size(10, 10), CopyPixelOperation.SourceCopy);

            return screenshot;

        }

        public Color GetColor(Point point)
        {
            int centerX = this.ResolutionWidth / 2 + TriggerPlacePixel(TriggerPlace)[0];
            int centerY = this.ResolutionHeight / 2 + TriggerPlacePixel(TriggerPlace)[1];

            Bitmap screenshot = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
            Graphics gfx = Graphics.FromImage(screenshot);
            gfx.CopyFromScreen(centerX, centerY, 0, 0, new Size(1, 1), CopyPixelOperation.SourceCopy);

            Color color = screenshot.GetPixel(0, 0);
            screenshot.Dispose();
            gfx.Dispose();
            return color;
        }
        private void PerformLeftClick()
        {
            mouse_event(LEFTDOWN, 0, 0, 0, 0);
            mouse_event(LEFTUP, 0, 0, 0, 0);
        }
        private int[] TriggerPlacePixel(int place)
        {
            switch (place)
            {
                case 0:
                    return new int[] { -1, -1 };
                case 1:
                    return new int[] { -1, 0 };
                case 2:
                    return new int[] { -1, 1 };
                case 3:
                    return new int[] { 0, -1 };
                case 4:
                    return new int[] { 0, 0 };
                case 5:
                    return new int[] { 0, 1 };
                case 6:
                    return new int[] { 1, -1 };
                case 7:
                    return new int[] { 1, 0 };
                case 8:
                    return new int[] { 1, 1 };
            }
            return new int[] { -1, 1 };
        }

    }
}
