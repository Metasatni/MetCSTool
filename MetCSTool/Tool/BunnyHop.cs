using System.ComponentModel;
namespace MetCSTool.Tool
{
    internal class BunnyHop
    {
        public bool Enabled { get; set; }
        public int LatencyInMs { get; set; }
        public Keys Key { get; set; }

        KeyboardHook hook = new KeyboardHook();


        public BunnyHop(Keys key)
        {
            this.Enabled = false;
            this.LatencyInMs = 2000;
            this.Key = key;
            //BackgroundWorker worker = new BackgroundWorker();
            //worker.DoWork += BunnyHopping;
            //worker.WorkerSupportsCancellation = true;

            //hook.KeyDown += (sender, e) =>
            //{
            //    if (e.KeyCode == this.Key)
            //    {
            //        if (worker.IsBusy) return;
            //        worker.RunWorkerAsync();
            //    }
            //};
            //hook.KeyUp += (sender, e) => { if (e.KeyCode == this.Key) { worker.CancelAsync(); } };

        }
        private void BunnyHopping(object? sender, DoWorkEventArgs e)
        {
            if (!Enabled) return;
            BackgroundWorker bg = (BackgroundWorker)sender;
            Thread.Sleep(this.LatencyInMs);
            BunnyHopBunnyHopping();
        }

        public void BunnyHopBunnyHopping()
        {
            
            //waiting for directx

        }


        
    }
}
