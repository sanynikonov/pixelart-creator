using System;
using System.Collections.Generic;
using System.Text;
using SColor = System.Drawing.Color;

namespace PixelartCreator.Domain.Tests
{
    public class PixelartGeneratorTestsData
    {
        private static readonly SColor Water = SColor.FromArgb(64, 64, 255);
        private static readonly SColor Wood = SColor.FromArgb(143, 119, 72);
        private static readonly SColor Quartz = SColor.FromArgb(255, 252, 245);
        private static readonly SColor Orange = SColor.FromArgb(216, 127, 51);
        private static readonly SColor Plant = SColor.FromArgb(0, 124, 0);

        private static readonly SColor[] _colors =
        {
            Water,
            Wood,
            Quartz,
            Orange,
            Plant
        };

        private static readonly SColor[,] _image =
        {
            { SColor.FromArgb(64, 64, 255), SColor.FromArgb(64, 65, 255), SColor.FromArgb(64, 64, 251) },
            { SColor.FromArgb(63, 64, 255), SColor.FromArgb(62, 63, 255), SColor.FromArgb(64, 64, 240) },
            { SColor.FromArgb(60, 64, 255), SColor.FromArgb(11, 64, 255), SColor.FromArgb(64, 64, 232) },
        };

        public static IEnumerable<object[]> CreateTestData => new List<object[]>
        {
            new object[]
            {
                new PixelizingOptions
                {
                    AvailibleColors = _colors
                },
                new Image
                {
                    Pixels = _image
                },
                new SColor[,]
                {
                    { Water, Water, Water },
                    { Water, Water, Water },
                    { Water, Water, Water }
                }
            }
        };
    }
}
