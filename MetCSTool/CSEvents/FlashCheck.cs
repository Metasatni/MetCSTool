using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetCSTool.CSEvents
{
    internal class FlashCheck
    {
        public static bool Check(Bitmap ss1, Bitmap ss2)
        {
            List<int> rgbs1 = new List<int>();
            List<int> rgbs2 = new List<int>();
            int counter = 0;
            

           for(int i = 0; i < ss1.Width; i++)
            {
                for (int j = 0; j < ss1.Height; j++)
                {
                    rgbs1.Add(ss1.GetPixel(i, j).R);
                    rgbs1.Add(ss1.GetPixel(i, j).G);
                    rgbs1.Add(ss1.GetPixel(i, j).B);
                }
            } 
            for(int i = 0; i < ss2.Width; i++)
            {
                for (int j = 0; j < ss2.Height; j++)
                {
                    rgbs2.Add(ss2.GetPixel(i, j).R);
                    rgbs2.Add(ss2.GetPixel(i, j).G);
                    rgbs2.Add(ss2.GetPixel(i, j).B);
                }
            } 
            for(int i = 0; i < rgbs1.Count; i++)
            {
                if(rgbs2[i] > rgbs1[i] ) {
                    counter++;
                }
            }
            if (counter / rgbs1.Count > 0.99)
                return true;
            return false;

        }
    }
}
