using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MetCSTool.Tool
{
    internal class BunnyHop
    {
        public bool Enabled { get; set; }
        public int LatencyInMs { get; set; }
        public Keys Key { get; set; }

        KeyboardHook hook = new KeyboardHook();
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        public BunnyHop(Keys key)
        {
            this.Enabled = false;
            this.LatencyInMs = 2000;
            this.Key = key;
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += BunnyHopping;
            worker.WorkerSupportsCancellation = true;

            hook.KeyDown += (sender, e) => { if (e.KeyCode == this.Key) {
                    if (worker.IsBusy) return;
                    worker.RunWorkerAsync();
                } };
            hook.KeyUp += (sender, e) => { if (e.KeyCode == this.Key) { worker.CancelAsync(); } };

        }
        private void BunnyHopping(object? sender, DoWorkEventArgs e)
        {
            if (!Enabled) return;
            BackgroundWorker bg = (BackgroundWorker)sender;
            while (true)
            {
                Thread.Sleep(this.LatencyInMs);
                BunnyHopBunnyHopping();
                if (bg.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        public void BunnyHopBunnyHopping()
        {
            const int VK_SPACE = 0x20;
            const int KEYEVENTF_KEYDOWN = 0x0;
            const int KEYEVENTF_KEYUP = 0x2;

            keybd_event(VK_SPACE, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(VK_SPACE, 0, KEYEVENTF_KEYUP, 0);
        }

    }
}
