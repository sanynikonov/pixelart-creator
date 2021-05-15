using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SColor = System.Drawing.Color;

namespace PixelartCreator.Domain
{
    internal class PixelartTransformer : IPixelartTransformer
    {
        private const int TextureSize = 16;
        private readonly IImageStorage _storage;

        public PixelartTransformer(IImageStorage storage)
        {
            _storage = storage;
        }

        public Image TransformPixelsToMinecraftBlocks(Image image, TransformingOptions options)
        {
            var cachedPixels = new Dictionary<SColor, Image>();

            var result = new SColor[image.Pixels.GetLength(0) * TextureSize, image.Pixels.GetLength(1) * TextureSize];

            for (int y = 0; y < image.Pixels.GetLength(0); y++)
            {
                for (int x = 0; x < image.Pixels.GetLength(1); x++)
                {
                    var color = image.Pixels[y, x];

                    var texture = GetTexture(color, cachedPixels, options.AvailibleBlocks);

                    FillTextureOnResult(result, x * TextureSize, y * TextureSize, texture.Pixels);
                }
            }

            return new Image { Pixels = result };
        }

        private Image GetTexture(SColor color, Dictionary<SColor, Image> cache, IEnumerable<MinecraftBlock> blocks)
        {
            if (cache.ContainsKey(color))
            {
                return cache[color];
            }

            var block = blocks.First(x => SColor
                .FromArgb(x.MapColor.A, x.MapColor.R, x.MapColor.G, x.MapColor.B)
                .Equals(color));

            var texture = _storage.GetImage(block.TexturePath);

            cache[color] = texture;

            return texture;
        }

        private void FillTextureOnResult(SColor[,] result, int x, int y, SColor[,] texture)
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
