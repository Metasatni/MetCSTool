using System.ComponentModel;
namespace MetCSTool.Tool
{
    internal class BunnyHop
    {
        private readonly KeyboardHook _hook;

        public bool Enabled { get; set; } = false;
        public int LatencyInMs { get; set; } = 2000;
        public Keys Key { get; set; }

        public BunnyHop(KeyboardHook hook, Keys key)
        {
            _hook = hook;
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
            if (!this.Enabled) return;
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
