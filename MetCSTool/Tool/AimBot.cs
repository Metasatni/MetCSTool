using MetCSTool.CSEvents;
using MetCSTool.Inputs;
using MetCSTool.Others;
using System.ComponentModel;

namespace MetCSTool.Tool
{
    internal class AimBot
    {
        private readonly BackgroundWorker _worker;
        private readonly KeyboardHook _hook;
        private Bitmap _previousScreenshot;

        public bool Enabled { get; set; } = false;
        public bool Fluency { get; set; } = false;
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

            e.Cancel = true;
        }
        public void AimBotAiming()
        {
            int width = 300;
            int height = 400;
            if (_previousScreenshot is null) _previousScreenshot = ScreenFunc.TakeScreenshot(this.ResolutionWidth, this.ResolutionHeight, width, height);
            Bitmap screenshot = ScreenFunc.TakeScreenshot(this.ResolutionWidth, this.ResolutionHeight, width, height);

            bool characterCheck = CharacterCheck.Check(screenshot, out Direction direction, out int distanceX, out int distanceY);


            if (characterCheck)
            {
                if (direction == Direction.Left)
                {
                    if (Fluency)
                    {
                        MouseInput.FluencyMouseMoveLeft(Convert.ToInt32(distanceX * 2.3));
                        MouseInput.FluencyMouseMoveTop(Convert.ToInt32(distanceY * 2.3));
                        MouseInput.FluencyMouseMoveDown(Convert.ToInt32(distanceY * 2.3));
                    }
                    else
                    {
                        MouseInput.MouseMove(Convert.ToInt32(-distanceX * 2.3),  Convert.ToInt32(distanceY * 2.3) * -1);
                    }
                }
                if (direction == Direction.Right)
                {
                    if (Fluency)
                    {
                        MouseInput.FluencyMouseMoveRight(Convert.ToInt32(distanceX * 2.3));
                        MouseInput.FluencyMouseMoveTop(Convert.ToInt32(distanceY * 2.3));
                        MouseInput.FluencyMouseMoveDown(Convert.ToInt32(distanceY * 2.3));
                    }
                    else
                    {
                        MouseInput.MouseMove(Convert.ToInt32(distanceX * 2.3), - Convert.ToInt32(distanceY * 2.3) * -1);
                    }
                }
                if (direction == Direction.Middle)
                {
                    MouseInput.MouseClick();
                }
            }

            _previousScreenshot = screenshot;

        }
    }
}