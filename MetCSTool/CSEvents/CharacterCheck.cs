using MetCSTool.Inputs;
using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetCSTool.CSEvents
{
    public enum Direction
    {
        Left,
        Right,
        Middle,
        None
    }
    internal class CharacterCheck
    {
        public static bool Check(Bitmap ss1, Bitmap ss2, out Direction direction)
        {
            int[,,] rgbs1= GetRbgValues(ss1);
            int[,,] rgbs2 = GetRbgValues(ss2);

            return IsArraySimilar(rgbs1,rgbs2, out direction);

        }
        private static bool IsArraySimilar(int[,,] arr1, int[,,] arr2, out Direction direction)
        {
            direction = Direction.None;
            int similarcounter = 0;
            int length = arr1.Length;
            int leftc = 0;
            int rightc = 0;
            int middle = 0;

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    for (int k = 0; k < arr1.GetLength(2); k++)
                    {
                        if (IsSimilar(arr1[i,j,k], arr2[i,j,k])) similarcounter++;
                        else
                        {
                            if (j < arr1.GetLength(1) / 2) leftc++;
                            else if (j > arr1.GetLength(1) / 2) rightc++;
                        }
                    }
                }
            }
            bool issimilar = similarcounter / length > 0.85;
            int halfY = arr2.GetLength(0) / 2 + 1;
            int halfX = arr2.GetLength(1) / 2 + 1;
            if (!issimilar) {
                if (!IsSimilar(arr2[halfY, halfX, 0], arr1[halfY, halfX, 0])){
                    if (!IsSimilar(arr2[halfY, halfX, 1], arr1[halfY, halfX, 1]))
                    {
                        if (!IsSimilar(arr2[halfY, halfX, 2], arr1[halfY, halfX, 2]))
                        {
                            direction = Direction.Middle;
                            return true;
                        }
                    }
                }
                if(rightc > leftc && leftc > middle) direction = Direction.Right;
                if(leftc > rightc && leftc > middle ) direction = Direction.Left;
                return true;
            }
            return false;
        }

        private static bool IsSimilar(int color1, int color2)
        {
            if (Math.Abs(color1 - color2) < 10) return true;
            return false;
        }

        private static int[,,] GetRbgValues(Bitmap screenshot) {

            int[,,] rgbs = new int[screenshot.Height, screenshot.Width,3]; 

            for(int i = 0; i < screenshot.Width; i++)
            {
                for (int j = 0; j < screenshot.Height; j++)
                {
                    var pixel = screenshot.GetPixel(i, j);
                    if(pixel.R < 70 && pixel.G < 70 && pixel.B < 70)
                    {
                        rgbs[j, i, 0] = pixel.R;
                        rgbs[j, i, 1] = pixel.G;
                        rgbs[j, i, 2] = pixel.B;
                    }
                    else
                    {
                        rgbs[j, i, 0] = 0;
                        rgbs[j, i, 1] = 0;
                        rgbs[j, i, 2] = 0;
                    }
                }
            }

            return rgbs;

        }
    }
}
