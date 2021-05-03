using Moq;
using PixelartCreator.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PixelartCreator.Business.Tests
{
    public class ColorServiceTest
    {
        private readonly Mock<IRepository> _repositoryMock = new Mock<IRepository>();
        private readonly IColorService _service;

        public ColorServiceTest()
        {
            _service = new ColorService(_repositoryMock.Object);
        }

        [Fact]
        public async Task GetColorsLibraryAsync()
        {
            var colors = new[]
            {
                new Color { Id = 1, R = 1, A = 1, G = 1, B = 1 },
                new Color { Id = 2, R = 2, A = 1, G = 1, B = 1 }
            };
            var blocks = new[]
            {
                new MinecraftBlock { Name = "Block1", ColorId = 1 },
                new MinecraftBlock { Name = "Block2", ColorId = 2 },
                new MinecraftBlock { Name = "Block3", ColorId = 1 },
                new MinecraftBlock { Name = "Block4", ColorId = 3 },
            };
            var expected = new[]
            {
                new ColorLibraryItemModel { Id = 1, R = 1, A = 1, G = 1, B = 1, BlocksNames = new[] { "Block1", "Block3" } },
                new ColorLibraryItemModel { Id = 2, R = 2, A = 1, G = 1, B = 1, BlocksNames = new[] { "Block2" } }
            };

            _repositoryMock.Setup(r => r.GetAsync(
                It.IsAny<Expression<Func<Color, bool>>>(), It.IsAny<int?>(), It.IsAny<int?>()))
                .ReturnsAsync(colors);

            _repositoryMock.Setup(r => r.GetAsync(
                It.IsAny<Expression<Func<MinecraftBlock, bool>>>(), It.IsAny<int?>(), It.IsAny<int?>()))
                .ReturnsAsync((Expression<Func<MinecraftBlock, bool>> pred, int? _, int? asd) => blocks.Where(pred.Compile()));

            var actual = await _service.GetColorsLibraryAsync();

            AssertColorLibraryListItemsAreValid(expected, actual.ToArray());
        }

        private void AssertColorLibraryListItemsAreValid(ColorLibraryItemModel[] expected, ColorLibraryItemModel[] actual)
        {
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i].R, actual[i].R);
                Assert.Equal(expected[i].G, actual[i].G);
                Assert.Equal(expected[i].B, actual[i].B);
                Assert.Equal(expected[i].A, actual[i].A);
                Assert.Equal(expected[i].BlocksNames, actual[i].BlocksNames);
            }
        }
    }
}
