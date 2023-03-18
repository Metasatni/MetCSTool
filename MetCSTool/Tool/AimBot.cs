using MetCSTool.CSEvents;
using MetCSTool.Others;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetCSTool.Tool
{
    internal class AimBot
    {
        private readonly BackgroundWorker _worker;
        private readonly KeyboardHook _hook;
        private Bitmap _previousScreenshot;

        public bool Enabled { get; set; } = false;
        public int LatencyInMs { get; set; } = 200;
        public int ResolutionWidth { get; set; }
        public int ResolutionHeight { get; set; }
        public int AimField { get; set; } = 100;
        public Keys Key { get; set; }

        public AimBot(KeyboardHook hook, Keys key)
        {
            _hook = hook;
            this.Key = key;

            _worker = new BackgroundWorker();
            _worker.WorkerSupportsCancellation = true;
            _worker.DoWork += Aiming;

            _hook.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == this.Key && _worker.IsBusy == false)
                {
                    _worker.RunWorkerAsync();
                }
            };

            _hook.KeyUp += (sender, e) =>
            {
                if (e.KeyCode == this.Key)
                {
                    _worker.CancelAsync();
                    _worker.Dispose();
                }
            };

        }
        private void Aiming(object? sender, DoWorkEventArgs e)
        {
            if (this.Enabled == false) return;

            while (_worker.CancellationPending == false)
            {
                AimBotAiming();
            }

            _previousScreenshot = null;
            e.Cancel = true;
        }
        public void AimBotAiming()
        {

            if (_previousScreenshot is null) _previousScreenshot = ScreenFunc.TakeScreenshot(this.ResolutionWidth,this.ResolutionHeight,10,10);

            Bitmap screenshot = ScreenFunc.TakeScreenshot(this.ResolutionWidth,this.ResolutionHeight,10,10);

            bool characterCheck = CharacterCheck.Check(_previousScreenshot, screenshot);


            if (characterCheck)
            {
                Debug.WriteLine("jest character");
                _worker.CancelAsync();
                _worker.Dispose();
            }

            _previousScreenshot = screenshot;

        }
    }
}
