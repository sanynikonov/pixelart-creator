using System.Linq;
using System.Collections.Generic;
using System.Text;
using ClassColor = PixelartCreator.Domain.Color;
using StructColor = System.Drawing.Color;
using System.Drawing;
using System;

namespace PixelartCreator.Domain
{
    public class PixelartGenerator : IPixelartGenerator
    {
        private const int TextureSize = 16;
        private readonly IImageStorage _storage;


        public PixelartGenerator(IImageStorage storage)
        {
            _storage = storage;
        }

        public Image CreatePixelart(Image image, PixelizingOptions options)
        {
            var _availibleColors = options.AvailibleColors;
            var cache = new Dictionary<StructColor, StructColor>();

            var bitmap = new Bitmap(BitmapConverter.FromColorsMatrix(image.Pixels), options.Size);
            var pixels = BitmapConverter.ToColorsMatrix(bitmap);

            var result = new StructColor[pixels.GetLength(0), pixels.GetLength(1)];

            for (int y = 0; y < pixels.GetLength(0); y++)
            {
                for (int x = 0; x < pixels.GetLength(1); x++)
                {
                    result[y, x] = FindMostSuitableAvailibleColor(pixels[y, x], _availibleColors, cache);
                }
            }

            return new Image { Pixels = result };
        }

        private StructColor FindMostSuitableAvailibleColor(StructColor color, IEnumerable<StructColor> _availibleColors, Dictionary<StructColor, StructColor> _cachedColors)
        {
            if (_cachedColors.TryGetValue(color, out var neighbour))
            {
                return neighbour;
            }

            var distances = _availibleColors.Select(c => new { Neighbour = c, Distance = DistanceToNeighbour(color, c) });
            var minDistance = distances.Min(x => x.Distance);
            neighbour = distances.First(x => x.Distance == minDistance).Neighbour;

            _cachedColors.Add(color, neighbour);
            return neighbour;
        }

        public static double DistanceToNeighbour(StructColor c1, StructColor c2)
            => 30 * Math.Pow(c2.R - c1.R, 2) + 59 * Math.Pow(c2.G - c1.G, 2) + 11 * Math.Pow(c2.B - c1.B, 2);

        public Image TransformPixelsToMinecraftBlocks(Image image, TransformOptions options)
        {
            var cachedPixels = new Dictionary<StructColor, Image>();

            var result = new StructColor[image.Pixels.GetLength(0) * TextureSize, image.Pixels.GetLength(1) * TextureSize];

            for (int y = 0; y < image.Pixels.GetLength(0); y++)
            {
                for (int x = 0; x < image.Pixels.GetLength(1); x++)
                {
                    var color = image.Pixels[y, x];

                    var texture = GetTexture(color, cachedPixels, options.AvailibleBlocks);

                    FillTextureOnResult(result, x * TextureSize, y * TextureSize, texture.Pixels);
                }
            }

            return new Image { Pixels = result};
        }

        private Image GetTexture(StructColor color, Dictionary<StructColor, Image> cache, IEnumerable<MinecraftBlock> blocks)
        {
            if (cache.ContainsKey(color))
            {
                return cache[color];
            }

            var block = blocks.First(x => StructColor
                .FromArgb(x.MapColor.A, x.MapColor.R, x.MapColor.G, x.MapColor.B)
                .Equals(color));

            var texture = _storage.GetImage(block.TexturePath);

            cache[color] = texture;

            return texture;
        }

        private void FillTextureOnResult(StructColor[,] result, int x, int y, StructColor[,] texture)
        {
            for (int yOffset = 0; yOffset < TextureSize; yOffset++)
            {
                for (int xOffset = 0; xOffset < TextureSize; xOffset++)
                {
                    result[y + yOffset, x + xOffset] = texture[yOffset, xOffset];
                }
            }
        }
    }
}
