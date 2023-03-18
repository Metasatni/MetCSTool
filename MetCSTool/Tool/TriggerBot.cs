using MetCSTool.CSEvents;
using MetCSTool.Inputs;
using MetCSTool.Others;
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
        private Color _previousPixel;
        private Bitmap _previousScreenshot;

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

            _previousPixel = Color.Empty;
            _previousScreenshot = null;
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

            if (_previousScreenshot is null) _previousScreenshot = ScreenFunc.TakeScreenshot(this.ResolutionWidth, this.ResolutionHeight,10,10);
            if (_previousPixel.IsEmpty) _previousPixel = 
                ScreenFunc.GetSinglePixel(_previousScreenshot,TriggerPlacePixel(TriggerPlace).Item1,TriggerPlacePixel(TriggerPlace).Item2);

            Bitmap screenshot = ScreenFunc.TakeScreenshot(this.ResolutionWidth, this.ResolutionHeight, 10, 10);

            Color pixel = 
                ScreenFunc.GetSinglePixel(_previousScreenshot,TriggerPlacePixel(TriggerPlace).Item1,TriggerPlacePixel(TriggerPlace).Item2);

            bool flashCheck = FlashCheck.Check(_previousScreenshot, screenshot);
            bool colorCheck = ColorCheck(_previousPixel, pixel);

            if (!flashCheck && colorCheck) {
                Thread.Sleep(LatencyInMs);
                MouseInput.MouseClick();
                _worker.CancelAsync();
                _worker.Dispose();
            }

            _previousPixel = pixel;
            _previousScreenshot = screenshot;

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
