using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MetCSTool.Tool
{
    internal class FakeSpinBot
    {
        public bool Enabled { get; set; }
        public Keys Key { get; set; }
        public Cursor Cursor { get; set; }
        Point prevPos;


        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;

        KeyboardHook hook = new KeyboardHook();
        public FakeSpinBot()
        {
            this.Enabled = false;
            this.Key = Keys.Z;

            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += Spinning;
            worker.WorkerSupportsCancellation = true;
            hook.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == this.Key)
                {
                    if (worker.IsBusy) return;
                    worker.RunWorkerAsync();
                }
            };

            hook.KeyUp += (sender, e) =>
            {
                if (e.KeyCode == this.Key)
                {
                    worker.CancelAsync();
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
            if (!Enabled) return;
            BackgroundWorker bg = (BackgroundWorker)sender;
            while (true)
            {
                SpinBotActivate();
                if (bg.CancellationPending)
                {
                    bg.Dispose();
                    e.Cancel = true;
                    return;
                }
            }

        }

    }
}
