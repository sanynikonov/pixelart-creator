using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PixelartCreator.Domain
{
    public class BitmapConverter
    {
        public static System.Drawing.Color[,] ToColorsMatrix(Bitmap image)
        {
            var pixels = new System.Drawing.Color[image.Height, image.Width];

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    pixels[y, x] = image.GetPixel(x, y);
                }
            }

            return pixels;
        }

        public static Bitmap FromColorsMatrix(System.Drawing.Color[,] colors)
        {
            var bitmap = new Bitmap(colors.GetLength(1), colors.GetLength(0));

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    bitmap.SetPixel(x, y, colors[y, x]);
                }
            }

            return bitmap;
        }
    }
}
