namespace MetCSTool.CSEvents
{
    internal class FlashCheck
    {
        public static bool Check(Bitmap ss1, Bitmap ss2)
        {

            int counter = 0;
            var rgbs1 = GetRbgValues(ss1);
            var rgbs2 = GetRbgValues(ss2);

            for(int i = 0; i < rgbs1.Count; i++)
            {
                if (rgbs2[i] > rgbs1[i] ) counter++;
            }

            return counter / rgbs1.Count > 0.99;

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
