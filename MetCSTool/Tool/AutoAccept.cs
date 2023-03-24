using AForge.Imaging;
using AForge.Imaging.Filters;
using MetCSTool.Inputs;
using MetCSTool.Others;
using System.Drawing.Imaging;

namespace MetCSTool.Tool
{
    internal class AutoAccept
    {
        public bool Enabled { get; set; } = false;
        public int LatencyInMs { get; set; } = 5000;
        public int ResolutionWidth { get; set; }
        public int ResolutionHeight { get; set; }
        public Keys Key { get; set; }

        private static Bitmap ConvertToFormat(Bitmap image, PixelFormat format)
        {
            Bitmap copy = new Bitmap(image.Width, image.Height, format);
            using (Graphics gr = Graphics.FromImage(copy))
            {
                gr.DrawImage(image, new Rectangle(0, 0, copy.Width, copy.Height));
            }
            return copy;
        }
        public async void SearchAccept()
        {
            var patternImage = new Bitmap("models/" + "accept.png");
            patternImage = ConvertToFormat(patternImage, PixelFormat.Format24bppRgb);
            while (this.Enabled)
            {
                await Task.Run(() => Thread.Sleep(LatencyInMs));
                var screen = ScreenFunc.TakeScreenshot(ResolutionWidth, ResolutionHeight, 100, 200);
                screen = ConvertToFormat(screen, PixelFormat.Format24bppRgb);
                TemplateMatch[] matches = new ExhaustiveTemplateMatching().ProcessImage(
                new ResizeBilinear(screen.Width, screen.Height).Apply(screen),
                new ResizeBilinear(patternImage.Width, patternImage.Height).Apply(patternImage)
                );
                    int indexMaxSim = -1;
                    float maxSim = 0;
                    int indCounter = 0;
                    if (matches.Length > 0)
                    {
                        foreach (var item in matches)
                        {
                            if (item.Similarity > 0.90)
                            {
                                if (item.Similarity > maxSim)
                                {
                                    indexMaxSim = indCounter;
                                    maxSim = item.Similarity;
                                }
                                indCounter++;
                            }
                        }
                        if (indexMaxSim == -1) return;
                        Cursor.Position = new Point( Convert.ToInt32(this.ResolutionWidth * 0.6) , Convert.ToInt32(this.ResolutionHeight * 0.5));
                        MouseInput.MouseClick();
                    }
                screen.Dispose();
                }
    
            }
        }
    }
