using AutoFixture;
using Moq;
using PixelartCreator.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Color = PixelartCreator.Domain.Color;
using Image = PixelartCreator.Domain.Image;
using SColor = System.Drawing.Color;

namespace PixelartCreator.Business.Tests
{
    public class PixelartServiceTest
    {
        private readonly Mock<IImageStorage> _storageMock = new Mock<IImageStorage>();
        private readonly Mock<IRepository> _repositoryMock = new Mock<IRepository>();
        private readonly Mock<IPixelartGenerator> _generatorMock = new Mock<IPixelartGenerator>();
        private readonly Fixture _fixture = new Fixture();
        private readonly IPixelartService _service;

        public PixelartServiceTest()
        {
            _service = new PixelartService(_storageMock.Object, _repositoryMock.Object, _generatorMock.Object);
        }

        [Fact]
        public async Task DeleteAsync_ById_DeletesPixelart()
        {
            var pixelart = new Pixelart { Id = 10 };
            _repositoryMock.Setup(r => r.GetAsync<Pixelart>(pixelart.Id)).ReturnsAsync(pixelart);
            _repositoryMock.Setup(r => r.DeleteAsync(pixelart));

            await _service.DeleteAsync(pixelart.Id);

            _repositoryMock.VerifyAll();
        }

        [Fact]
        public async Task CreateAsync_ByModel_CreatesAndSavesPixelart()
        {
            var model = new PixelartCreateModel
            {
                SourcePath = "path/to/file.png",
                Size = new Size(2, 3),
                AvailibleColorsIds = new[] { 1, 2, 3 },
                Unit = SizeUnit.Pixel
            };
            var image = _fixture.Create<Image>();
            var colors = new Color[]
            {
                new Color { Id = 1 },
                new Color { Id = 2 },
                new Color { Id = 3 },
                new Color { Id = 4 }
            };
            var options = new PixelizingOptions
            {
                AvailibleColors = new[]
                {
                    new SColor(),
                    new SColor(),
                    new SColor(),
                },
                Size = new Size(2, 3)
            };
            var expected = _fixture.Create<string>();

            _storageMock.Setup(s => s.GetImage(model.SourcePath)).Returns(image);
            _repositoryMock.Setup(r => r.GetAsync(
                It.IsAny<Expression<Func<Color, bool>>>(), It.IsAny<int?>(), It.IsAny<int?>()))
                .ReturnsAsync(colors);
            _generatorMock.Setup(g => g.CreatePixelart(It.IsAny<Image>(), It.IsAny<PixelizingOptions>()));
            _storageMock.Setup(s => s.SaveImage(It.IsAny<Image>())).Returns(expected);

            var result = await _service.CreateAsync(model);

            Assert.Equal(expected, result.ResultPath);
            _generatorMock.VerifyAll();
            _repositoryMock.VerifyAll();
            _storageMock.VerifyAll();
        }
    }
}
