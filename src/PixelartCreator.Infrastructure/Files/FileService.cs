﻿using PixelartCreator.Domain;
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
        private const string ImageFolder = "Images";
        private readonly string _rootPath;
        private readonly Random _random;

        public FileService(string rootPath)
        {
            _rootPath = rootPath;
            _random = new Random();

            var directory = Path.Combine(rootPath, ImageFolder);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

        public Image GetImage(string relativePath)
        {
            var fullPath = GetImageFullPath(relativePath);
            using var bitmap = new Bitmap(fullPath);
            var pixels = BitmapConverter.ToColorsMatrix(bitmap);
            return new Image { Pixels = pixels };
        }

        public string SaveImage(Image image)
        {
            using var bitmap = BitmapConverter.FromColorsMatrix(image.Pixels);
            var path = GetImageFullPath($"{Guid.NewGuid()}.png");
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
            return Path.Combine(_rootPath, ImageFolder, fileName);
        }

        private string CreateValuableFileName(string oldName)
        {
            string name = oldName;
            if (oldName.Length > 75)
                name = ShortenFileName(oldName);

            return DateTime.Now.ToString("ddMMyyyyTHHmmss") + "-" + GetRandomString(8) + "-" + name;
        }

        private string ShortenFileName(string path)
        {
            const int maxLength = 71;
            var fileName = Path.GetFileNameWithoutExtension(path);
            var nameLength = fileName.Length < maxLength ? fileName.Length : maxLength;
            return fileName.Substring(0, nameLength) + Path.GetExtension(path);
        }

        private string GetRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[_random.Next(s.Length)]).ToArray());
        }

        public ImageInfoModel GetImageInfo(string fileName)
        {
            using var image = System.Drawing.Image.FromFile(GetImageFullPath(fileName));

            return new ImageInfoModel
            {
                Height = image.Height,
                Width = image.Width
            };
        }
    }
}
