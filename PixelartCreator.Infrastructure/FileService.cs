using PixelartCreator.Domain;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Image = PixelartCreator.Domain.Image;

namespace PixelartCreator.Infrastructure
{
    public class FileService : IImageStorage, IFileService
    {
        private const string ImageFolder = "/Images/";
        private readonly string _rootPath;
        private readonly Random _random;

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

        public async Task<string> UploadImageAsync(FileUploadModel file)
        {
            if (Path.GetExtension(file.OldName) != ".jpg" &&
                Path.GetExtension(file.OldName) != ".png")
                throw new FormatException("Image format should be .png or .jpg");

            var fileName = CreateValuableFileName(file.OldName);

            var fullPath = GetImageFullPath(fileName);

            using (var fileStream = new FileStream(fullPath, FileMode.Create))
            {
                using var stream = file.Stream;
                await stream.CopyToAsync(fileStream);
            }

            return fileName;
        }

        private string GetImageFullPath(string fileName)
        {
            return _rootPath + ImageFolder + fileName;
        }

        private string CreateValuableFileName(string oldName)
        {
            string name = oldName;
            if (oldName.Length > 75)
                name = ShortenFileName(oldName);

            return DateTime.Now.ToString("ddMMyyyy-HHmmss") + "-" + GetRandomString(8) + "-" + name;
        }

        private string ShortenFileName(string fileName)
        {
            return Path.GetFileName(fileName).Substring(0, 71) + Path.GetExtension(fileName);
        }

        private string GetRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[_random.Next(s.Length)]).ToArray());
        }
    }
}
