using MetCSTool.CSEvents;
using MetCSTool.Inputs;
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
        private readonly BackgroundWorker _worker;
        private readonly KeyboardHook _hook;
        private Color _color;

        public bool Enabled { get; set; } = false;
        public int LatencyInMs { get; set; } = 200;
        public int ResolutionWidth { get; set; }
        public int ResolutionHeight { get; set; }
        public int TriggerPlace { get; set; } = 2;
        public Keys Key { get; set; }

        public TriggerBot(KeyboardHook hook, Keys key)
        {
            _hook = hook;
            this.Key = key;

            _worker = new BackgroundWorker();
            _worker.WorkerSupportsCancellation = true;
            _worker.DoWork += Triggering;

            _hook.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == this.Key && _worker.IsBusy == false)
                {
                    _worker.RunWorkerAsync();
                }
            };

            _hook.KeyUp += (sender, e) => {
              if (e.KeyCode == this.Key) {
                _worker.CancelAsync();
                _worker.Dispose();
              }
            };

        }

        private void Triggering(object? sender, DoWorkEventArgs e)
        {
            if (this.Enabled == false) return;

            while (_worker.CancellationPending == false)
            {
                TriggerBotTriggering();
            }

            e.Cancel = true;

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

            _color = GetColor();
            Color color = GetColor();
            Bitmap ss1 = TookScreenshot();
            Bitmap ss2 = TookScreenshot();

            if (FlashCheck.Check(ss1, ss2)) { 
                return;
            }
            if (ColorCheck(color, _color))
            {
                _color = color;
                MouseInput.MouseClick();
                _worker.CancelAsync();
                _worker.Dispose();
                return;
            }
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

        public Color GetColor()
        {
            int centerX = this.ResolutionWidth / 2 + TriggerPlacePixel(this.TriggerPlace).Item1;
            int centerY = this.ResolutionHeight / 2 + TriggerPlacePixel(this.TriggerPlace).Item2;

            Bitmap screenshot = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
            Graphics gfx = Graphics.FromImage(screenshot);
            gfx.CopyFromScreen(centerX, centerY, 0, 0, new Size(1, 1), CopyPixelOperation.SourceCopy);

            Color color = screenshot.GetPixel(0, 0);
            screenshot.Dispose();
            gfx.Dispose();
            return color;
        }

        private (int, int) TriggerPlacePixel(int place)
        {
            return place switch {
                0 => (-1, -1),
                1 => (-1, 0),
                2 => (-1, 1),
                3 => (0, -1),
                4 => (0, 0),
                5 => (0, 1),
                6 => (1, -1),
                7 => (1, 0),
                8 => (1, 1),
                _ => (-1, 1),
            };
        }

    }
}
