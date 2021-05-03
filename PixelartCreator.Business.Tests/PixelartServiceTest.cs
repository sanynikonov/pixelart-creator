using AutoFixture;
using Moq;
using PixelartCreator.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        public async Task DeleteAsync_ById_DeletesInRepository()
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

        [Fact]
        public async Task SaveAsync_Model_SavesToRepository()
        {
            var model = new PixelartSaveModel
            {
                Description = "cool",
                Name = "pixelart",
                ResultPath = "path/to/result",
                SourcePath = "path/to/source",
                UserId = 123
            };

            _repositoryMock.Setup(r => r.AddAsync(It.IsAny<Pixelart>()));

            await _service.SaveAsync(model);

            _repositoryMock.Verify(r => r.AddAsync(It.Is<Pixelart>(p => PixelartAndModelAreEqual(p, model))));
        }

        [Fact]
        public async Task UpdateAsync_Model_SavesToRepository()
        {
            var model = new PixelartUpdateModel
            {
                Id = 123,
                Description = "cool",
                Name = "pixelart"
            };
            var pixelart = new Pixelart
            {
                Id = 123
            };

            _repositoryMock.Setup(r => r.UpdateAsync(It.IsAny<Pixelart>()));
            _repositoryMock.Setup(r => r.GetAsync<Pixelart>(It.IsAny<int>())).ReturnsAsync(pixelart);

            await _service.UpdateAsync(model);

            _repositoryMock.Verify(r => r.UpdateAsync(It.Is<Pixelart>(p => PixelartAndModelAreEqual(p, model))));
        }

        [Fact]
        public async Task GetAsync_ById_ReturnsOneModel()
        {
            var pixelart = new Pixelart
            {
                Id = 123,
                Name = "pixelart",
                Description = "cool",
                UserId = 123,
                CreatedAt = DateTime.Now,
                ResultPath = "path/to/result",
                SourcePath = "path/to/source"
            };

            _repositoryMock.Setup(r => r.GetAsync<Pixelart>(It.IsAny<int>())).ReturnsAsync(pixelart);

            var model = await _service.GetAsync(pixelart.Id);

            _repositoryMock.Verify(r => r.UpdateAsync(It.Is<Pixelart>(p => PixelartAndModelAreEqual(p, model))));
        }

        [Fact]
        public async Task GetAsync_ByFilter_ReturnsManyModels()
        {
            var pixelarts = new[]
            {
                new Pixelart
                {
                    Id = 123,
                    Name = "pixelart",
                    Description = "cool",
                    UserId = 123,
                    CreatedAt = DateTime.Now,
                    ResultPath = "path/to/result",
                    SourcePath = "path/to/source"
                },
                new Pixelart
                {
                    Id = 1234,
                    Name = "pixelart1",
                    Description = "cool1",
                    UserId = 123,
                    CreatedAt = DateTime.Now,
                    ResultPath = "path/to/result",
                    SourcePath = "path/to/source"
                }
            };
            var filter = new PageFilter();

            _repositoryMock.Setup(r => r.GetAsync(
                It.IsAny<Expression<Func<Pixelart, bool>>>(), It.IsAny<int?>(), It.IsAny<int?>()))
                .ReturnsAsync(pixelarts);

            var models = await _service.GetAsync(filter);

            foreach (var model in models)
            {
                _repositoryMock.Verify(r => r.UpdateAsync(It.Is<Pixelart>(p => PixelartAndModelAreEqual(p, model))));
            }
        }

        private bool PixelartAndModelAreEqual(Pixelart pixelart, PixelartSaveModel model)
        {
            return pixelart.Name == model.Name
                && pixelart.Description == model.Description
                && pixelart.ResultPath == model.ResultPath
                && pixelart.SourcePath == model.SourcePath
                && pixelart.UserId == model.UserId;
        }

        private bool PixelartAndModelAreEqual(Pixelart pixelart, PixelartUpdateModel model)
        {
            return pixelart.Name == model.Name
                && pixelart.Description == model.Description
                && pixelart.Id == model.Id;
        }

        private bool PixelartAndModelAreEqual(Pixelart pixelart, PixelartInfoModel model)
        {
            return pixelart.Name == model.Name
                && pixelart.Description == model.Description
                && pixelart.ResultPath == model.ResultPath
                && pixelart.SourcePath == model.SourcePath
                && pixelart.UserId == model.UserId
                && pixelart.Id == model.Id
                && pixelart.CreatedAt == model.CreatedAt;
        }

        private bool PixelartAndModelAreEqual(Pixelart pixelart, PixelartListItemModel model)
        {
            return pixelart.Name == model.Name
                && pixelart.Description == model.Description
                && pixelart.ResultPath == model.ResultPath
                && pixelart.UserId == model.UserId
                && pixelart.Id == model.Id
                && pixelart.CreatedAt == model.CreatedAt;
        }
    }
}
