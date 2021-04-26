using System.Linq;
using System.Collections.Generic;
using System.Text;
using SColor = System.Drawing.Color;
using System.Drawing;
using System;

namespace PixelartCreator.Domain
{
    public class PixelartGenerator : IPixelartGenerator
    {
        public Image CreatePixelart(Image image, PixelizingOptions options)
        {
            var availibleColors = options.AvailibleColors;
            var cache = new Dictionary<SColor, SColor>();

            var pixels = Resize(image, options);

            var result = new SColor[pixels.GetLength(0), pixels.GetLength(1)];

            for (int y = 0; y < pixels.GetLength(0); y++)
            {
                for (int x = 0; x < pixels.GetLength(1); x++)
                {
                    result[y, x] = FindMostSuitableAvailibleColor(pixels[y, x], availibleColors, cache);
                }
            }

            return new Image { Pixels = result };
        }

        private static SColor[,] Resize(Image image, PixelizingOptions options)
        {
            var sizeDiffers = options.Size.Height != image.Pixels.GetLength(0)
                && options.Size.Width != image.Pixels.GetLength(1);

            if (sizeDiffers && options.Size != default)
            {
                var bitmap = new Bitmap(BitmapConverter.FromColorsMatrix(image.Pixels), options.Size);
                return BitmapConverter.ToColorsMatrix(bitmap);
            }

            return image.Pixels;
        }

        private SColor FindMostSuitableAvailibleColor(SColor color, IEnumerable<SColor> availibleColors, Dictionary<SColor, SColor> _cachedColors)
        {
            if (_cachedColors.TryGetValue(color, out var neighbour))
            {
                return neighbour;
            }

            var distances = availibleColors.Select(c => new { Neighbour = c, Distance = DistanceToNeighbour(color, c) });
            var minDistance = distances.Min(x => x.Distance);
            neighbour = distances.First(x => x.Distance == minDistance).Neighbour;

            _cachedColors.Add(color, neighbour);
            return neighbour;
        }

        public static double DistanceToNeighbour(SColor c1, SColor c2)
            => 30 * Math.Pow(c2.R - c1.R, 2) + 59 * Math.Pow(c2.G - c1.G, 2) + 11 * Math.Pow(c2.B - c1.B, 2);
    }
}
