using System.Linq;
using System.Collections.Generic;
using System.Text;
using ClassColor = PixelartCreator.Domain.Color;
using StructColor = System.Drawing.Color;

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
            return null;
        }

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
