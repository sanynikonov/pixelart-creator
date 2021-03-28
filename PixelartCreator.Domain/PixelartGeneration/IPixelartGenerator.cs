using System;
using System.Collections.Generic;
using System.Text;

namespace PixelartCreator.Domain
{
    public interface IPixelartGenerator
    {
        Image CreatePixelart(Image image, PixelizingOptions options);
        Image TransformPixelsToMinecraftBlocks(Image image, TransformOptions options);
    }
}
