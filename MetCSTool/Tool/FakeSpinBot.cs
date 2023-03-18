using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MetCSTool.Tool
{
    internal class FakeSpinBot
    {
        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        private readonly KeyboardHook _hook;
        private readonly BackgroundWorker _worker;

        public bool Enabled { get; set; } = false;
        public Keys Key { get; set; }

        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        public FakeSpinBot(KeyboardHook hook,Keys key)
        {
            _hook = hook;
            this.Key = key;

            _worker = new BackgroundWorker();
            _worker.DoWork += Spinning;
            _worker.WorkerSupportsCancellation = true;

            hook.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == this.Key && _worker.IsBusy == false) _worker.RunWorkerAsync();
            };

            hook.KeyUp += (sender, e) =>
            {
                if (e.KeyCode == this.Key)
                {
                    _worker.CancelAsync();
                }
            };
        }

        public void SpinBotActivate()
        {
            for (int i = 0; i < 60; i += 1)
            {
                mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, 1000, 0, 0, 0);
            }
            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, -60000, 0, 0, 0);
            Thread.Sleep(20);
        }

        public void Spinning(object? sender, DoWorkEventArgs e)
        {
            if (!this.Enabled) return;

            while (_worker.CancellationPending == false)
            {
                SpinBotActivate();
            }

            e.Cancel = true;

        }

    }
}
