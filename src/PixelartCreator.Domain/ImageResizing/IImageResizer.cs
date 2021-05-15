using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PixelartCreator.Domain
{
    public interface IImageResizer
    {
        Image Resize(Image image, Size size);
    }
}
