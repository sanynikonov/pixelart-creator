using AutoFixture;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xunit;

namespace PixelartCreator.Domain.Tests
{
    public class ImageResizerTest
    {
        private IImageResizer _resizer = new ImageResizer();

        [Theory]
        [MemberData(nameof(ImageResizerTestData.SuccessTestData), MemberType = typeof(ImageResizerTestData))]
        public void Resize_Image_ReturnsImageWithNewSize(Size expected)
        {
            var image = new Fixture().Create<Image>();

            var result = _resizer.Resize(image, expected);
            var actual = new Size(result.Pixels.GetLength(1), result.Pixels.GetLength(0));

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(ImageResizerTestData.FailTestData), MemberType = typeof(ImageResizerTestData))]
        public void Resize_NonPositiveSize_ThrowsException(Size size)
        {
            var image = new Fixture().Create<Image>();

            void Action() => _resizer.Resize(image, size);

            Assert.Throws<ArgumentException>(Action);
        }

        [Fact]
        public void Resize_NullImage_ThrowsException()
        {
            Image image = null;
            var size = new Size(5, 5);

            void Action() => _resizer.Resize(image, size);

            Assert.Throws<ArgumentNullException>(Action);
        }
    }
}
