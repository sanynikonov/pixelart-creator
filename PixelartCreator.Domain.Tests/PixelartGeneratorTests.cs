using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using SColor = System.Drawing.Color;
using Xunit;

namespace PixelartCreator.Domain.Tests
{
    public class PixelartGeneratorTests
    {
        private readonly Mock<IImageStorage> _mockStorage = new Mock<IImageStorage>();
        private readonly IPixelartGenerator _generator;

        public PixelartGeneratorTests()
        {
            _generator = new PixelartGenerator(_mockStorage.Object);
        }

        [Theory]
        [MemberData(nameof(PixelartGeneratorTestsData.CreateTestData), MemberType = typeof(PixelartGeneratorTestsData))]
        public void CreatePixelart_FromImage_ReturnsAnother(PixelizingOptions options, Image image, SColor[,] expected)
        {
            var actual = _generator.CreatePixelart(image, options).Pixels;

            Assert.Equal(expected, actual);
        }
    }
}
