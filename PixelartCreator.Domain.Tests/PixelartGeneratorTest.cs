using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using SColor = System.Drawing.Color;
using Xunit;
using AutoFixture;

namespace PixelartCreator.Domain.Tests
{
    public class PixelartGeneratorTest
    {
        private readonly Mock<IImageResizer> _mockResizer = new Mock<IImageResizer>();
        private readonly Fixture _fixture = new Fixture();
        private readonly IPixelartGenerator _generator;

        public PixelartGeneratorTest()
        {
            _generator = new PixelartGenerator(_mockResizer.Object);
        }

        [Fact]
        public void CreatePixelart_ImageIsNull_ThrowsException()
        {
            Image image = null;
            var options = _fixture.Create<PixelizingOptions>();

            void Action() => _generator.CreatePixelart(image, options);

            Assert.Throws<ArgumentNullException>(Action);
        }

        [Fact]
        public void CreatePixelart_OptionsAreNull_ThrowsException()
        {
            var image = _fixture.Create<Image>();
            PixelizingOptions options = null;

            void Action() => _generator.CreatePixelart(image, options);

            Assert.Throws<ArgumentNullException>(Action);
        }

        [Theory]
        [MemberData(nameof(PixelartGeneratorTestData.CreateTestData), MemberType = typeof(PixelartGeneratorTestData))]
        public void CreatePixelart_FromImage_ReturnsAnother(PixelizingOptions options, Image image, SColor[,] expected)
        {
            _mockResizer
                .Setup(x => x.Resize(It.IsAny<Image>(), It.IsAny<Size>()))
                .Returns((Image img, Size size) => img);

            var actual = _generator.CreatePixelart(image, options).Pixels;

            Assert.Equal(expected, actual);
        }
    }
}
