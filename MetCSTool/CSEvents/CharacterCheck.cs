using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetCSTool.CSEvents
{
    internal class CharacterCheck
    {
        public static bool Check(Bitmap ss1, Bitmap ss2)
        {

            var rgbs1 = GetRbgValues(ss1);
            var rgbs2 = GetRbgValues(ss2);

            return true;
        }
        private static bool IsSimilar(int color1, int color2)
        {
            if (Math.Abs(color1 - color2) < 20) return true;
            return false;
        }
        private static List<int> GetRbgValues(Bitmap screenshot) {

            var rgbs = new List<int>();

            for(int i = 0; i < screenshot.Width; i++)
            {
                for (int j = 0; j < screenshot.Height; j++)
                {
                    var pixel = screenshot.GetPixel(i, j);
                    rgbs.Add(pixel.R);
                    rgbs.Add(pixel.G);
                    rgbs.Add(pixel.B);
                }
            }

            return rgbs;

        }
    }
}
