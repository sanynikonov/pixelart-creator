using System;
using System.Collections.Generic;
using System.Text;

namespace PixelartCreator.Domain
{
    public interface IPixelartTransformer
    {
        Image TransformPixelsToMinecraftBlocks(Image image, TransformingOptions options);
    }
}
