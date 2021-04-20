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

        private static readonly SColor Water = SColor.FromArgb(64, 64, 255);
        private static readonly SColor Wood = SColor.FromArgb(143, 119, 72);
        private static readonly SColor Quartz = SColor.FromArgb(255, 252, 245);
        private static readonly SColor Orange = SColor.FromArgb(216, 127, 51);
        private static readonly SColor Plant = SColor.FromArgb(0, 124, 0);

        private readonly SColor[] _colors =
        {
            Water,
            Wood,
            Quartz,
            Orange,
            Plant
        };

        private readonly SColor[,] _image =
        {
            { SColor.FromArgb(64, 64, 255), SColor.FromArgb(64, 65, 255), SColor.FromArgb(64, 64, 251) },
            { SColor.FromArgb(63, 64, 255), SColor.FromArgb(62, 63, 255), SColor.FromArgb(64, 64, 240) },
            { SColor.FromArgb(60, 64, 255), SColor.FromArgb(11, 64, 255), SColor.FromArgb(64, 64, 232) },
        };

        public PixelartGeneratorTests()
        {
            _generator = new PixelartGenerator(_mockStorage.Object);
        }

        [Fact]
        public void CreatePixelart_FromImage_ReturnsAnother()
        {
            var options = new PixelizingOptions { AvailibleColors = _colors };
            var image = new Image { Pixels = _image };

            var expected = new SColor[,]
            {
                { Water, Water, Water },
                { Water, Water, Water },
                { Water, Water, Water }
            };

            var actual = _generator.CreatePixelart(image, options).Pixels;

            Assert.Equal(expected, actual);
        }
    }
}
