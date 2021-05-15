using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PixelartCreator.Domain
{
    public class ImageResizer : IImageResizer
    {
        public Image Resize(Image image, Size size)
        {
            if (image == null)
            {
                throw new ArgumentNullException(nameof(image));
            }

            if (size.Width <= 0 || size.Height <= 0)
            {
                throw new ArgumentException("Size should contain only positive numbers", nameof(size));
            }

            var sizeDiffers = size.Height != image.Pixels.GetLength(0)
                && size.Width != image.Pixels.GetLength(1);

            if (sizeDiffers && size != default)
            {
                var bitmap = new Bitmap(BitmapConverter.FromColorsMatrix(image.Pixels), size);

                return new Image
                {
                    Pixels = BitmapConverter.ToColorsMatrix(bitmap)
                };
            }

            return image; //NOTE: same image, not copy!
        }
    }
}
