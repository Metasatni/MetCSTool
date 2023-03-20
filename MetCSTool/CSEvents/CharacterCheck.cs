using AForge.Imaging.Filters;
using AForge.Imaging;
using System.Runtime.Intrinsics.X86;
using System.Drawing.Imaging;

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
        public static bool Check(Bitmap ss, out Direction direction, out int distance)
        {
            int[,,] rgbs = GetRbgValues(ss);
            distance = 0;
            direction = Direction.None;
            List<Bitmap> patternImage = new List<Bitmap>();
            for (int i = 1; i <= 20; i++)
            {
                patternImage.Add(new Bitmap("models/" + i + ".png"));
                patternImage[i - 1] = ConvertToFormat(patternImage[i - 1], PixelFormat.Format24bppRgb);
            }
            ss = ConvertToFormat(ss, PixelFormat.Format24bppRgb);
            for (int i = 0; i < patternImage.Count; i++)
            {

                TemplateMatch[] matches = new ExhaustiveTemplateMatching().ProcessImage(
                new ResizeBilinear(ss.Width, ss.Height).Apply(ss),
                new ResizeBilinear(patternImage[i].Width, patternImage[i].Height).Apply(patternImage[i])
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
                    if (indexMaxSim == -1) return false;
                    var bestCharacter = matches[indexMaxSim];
                    Rectangle character = bestCharacter.Rectangle;
                    int x = character.X;
                    int y = character.Y;
                    direction = GetDirection(rgbs, x, y, out distance);
                    return true;
                }
            }
            return false;
        }

        private static Bitmap ConvertToFormat(Bitmap image, PixelFormat format)
        {
            Bitmap copy = new Bitmap(image.Width, image.Height, format);
            using (Graphics gr = Graphics.FromImage(copy))
            {
                gr.DrawImage(image, new Rectangle(0, 0, copy.Width, copy.Height));
            }
            return copy;
        }

        private static Direction GetDirection(int[,,] rgbs, int x, int y, out int distance)
        {
            int halfX = rgbs.GetLength(1) / 2 + 1;
            distance = Math.Abs(halfX - x);
            if (x - halfX < -8) { return Direction.Left; }
            if (x - halfX > 8) { return Direction.Right; }
            else return Direction.Middle;
        }

        private static int[,,] GetRbgValues(Bitmap screenshot)
        {

            int[,,] rgbs = new int[screenshot.Height, screenshot.Width, 3];

            for (int i = 0; i < screenshot.Width; i++)
            {
                for (int j = 0; j < screenshot.Height; j++)
                {
                    var pixel = screenshot.GetPixel(i, j);
                    if (pixel.R < 70 && pixel.G < 70 && pixel.B < 70)
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