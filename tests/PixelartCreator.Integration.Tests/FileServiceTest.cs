using PixelartCreator.Infrastructure;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace PixelartCreator.Integration.Tests
{
    public class FileServiceTest : IDisposable
    {
        private static readonly string _rootPath = Path.Combine(Environment.CurrentDirectory, "TestFileSystem");
        private static readonly string _testData = Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "TestData"); 
        private readonly FileService _service;

        public FileServiceTest()
        {
            Directory.CreateDirectory(_rootPath);
            Directory.CreateDirectory(Path.Combine(_rootPath, "Images"));

            _service = new FileService(_rootPath);
        }

        [Theory]
        [InlineData("Image1.jpg")]
        [InlineData("Image2.png")]
        public async Task UploadImageAsync_ImageIsCorrect_SavesToDirectory(string fileName)
        {
            var stream = File.OpenRead(Path.Combine(_testData, fileName));
            var model = new FileUploadModel { OldName = fileName, Stream = stream };

            var actual = await _service.UploadImageAsync(model);
            var fileExists = File.Exists(Path.Combine(_rootPath, "Images", actual));

            Assert.Contains(model.OldName, actual);
            Assert.True(fileExists);
        }

        [Fact]
        public void GetImageInfo_ByName_ReturnsInfo()
        {
            var fileName = "Image1.jpg";
            File.Copy(Path.Combine(_testData, fileName), Path.Combine(_rootPath, "Images", fileName));
            var expected = new ImageInfoModel { Height = 256, Width = 256 };

            var actual = _service.GetImageInfo(fileName);

            Assert.Equal(expected.Width, actual.Width);
            Assert.Equal(expected.Height, actual.Height);
        }

        [Fact]
        public void GetImage_ByName_ReturnsColorsMatrix()
        {
            var expected = new Color[,]
            {
                { Color.FromArgb(64, 64, 255), Color.FromArgb(64, 65, 255), Color.FromArgb(64, 64, 251) },
                { Color.FromArgb(63, 64, 255), Color.FromArgb(62, 63, 255), Color.FromArgb(64, 64, 240) },
                { Color.FromArgb(60, 64, 255), Color.FromArgb(11, 64, 255), Color.FromArgb(64, 64, 232) },
            };
            using (var bitmap = Domain.BitmapConverter.FromColorsMatrix(expected))
            {
                bitmap.Save(Path.Combine(_rootPath, "Images", "Image.png"));
            }

            var actual = _service.GetImage("Image.png");

            Assert.Equal(expected, actual.Pixels);
        }

        [Fact]
        public void SaveImage_ByPixels_ReturnsName()
        {
            var image = new Domain.Image
            {
                Pixels = new Color[,]
                {
                    { Color.FromArgb(64, 64, 255), Color.FromArgb(64, 65, 255), Color.FromArgb(64, 64, 251) },
                    { Color.FromArgb(63, 64, 255), Color.FromArgb(62, 63, 255), Color.FromArgb(64, 64, 240) },
                    { Color.FromArgb(60, 64, 255), Color.FromArgb(11, 64, 255), Color.FromArgb(64, 64, 232) },
                }
            };

            var actual = _service.SaveImage(image);

            Assert.NotEmpty(actual);
        }

        public void Dispose()
        {
            Directory.Delete(_rootPath, recursive: true);
        }
    }
}
