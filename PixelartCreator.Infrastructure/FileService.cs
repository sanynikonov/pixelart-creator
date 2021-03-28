using PixelartCreator.Domain;
using System;
using System.Drawing;
using System.IO;
using Image = PixelartCreator.Domain.Image;

namespace PixelartCreator.Infrastructure
{
    public class FileService : IImageStorage
    {
        private readonly string _rootPath;

        public FileService(string rootPath)
        {
            _rootPath = rootPath;
        }

        public Image GetImage(string relativePath)
        {
            var fullPath = Path.Combine(_rootPath, relativePath);
            var image = System.Drawing.Image.FromFile(fullPath);
            using var bitmap = new Bitmap(image);
            var pixels = BitmapConverter.ToColorsMatrix(bitmap);
            return new Image { Pixels = pixels };
        }

        public string SaveImage(Image image)
        {
            using var bitmap = BitmapConverter.FromColorsMatrix(image.Pixels);
            var path = Path.Combine(_rootPath, "Images", $"{Guid.NewGuid()}.png");
            bitmap.Save(path);
            return path;
        }
    }
}
