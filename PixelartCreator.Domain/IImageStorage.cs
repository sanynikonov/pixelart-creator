using System;
using System.Collections.Generic;
using System.Text;

namespace PixelartCreator.Domain
{
    public interface IImageStorage
    {
        Image GetImage(string fileName);
        string SaveImage(Image image);
    }
}
