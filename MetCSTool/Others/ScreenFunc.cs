using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetCSTool.Others
{
    internal class ScreenFunc
    {
        public static Bitmap TakeScreenshot(int ResolutionWidth, int ResolutionHeight, int Width, int Height)
        {
            int centerX = ResolutionWidth / 2;
            int centerY = ResolutionHeight / 2;

            Bitmap screenshot = new Bitmap(Width, Height, PixelFormat.Format32bppArgb);
            Graphics gfx = Graphics.FromImage(screenshot);
            gfx.CopyFromScreen(centerX - Width/2, centerY - Height/5, 0, 0, new Size(Width, Height), CopyPixelOperation.SourceCopy);

            return screenshot;
        }
        public static Color GetSinglePixel(Bitmap screenshot, int x, int y)
        {
            int centerX = screenshot.Width / 2 + x;
            int centerY = screenshot.Height / 2 + y;

            Color color = screenshot.GetPixel(0, 0);
            return color;
        }
    }
}
