using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PixelartCreator.Domain.Tests
{
    public class ImageResizerTestData
    {
        public static IEnumerable<object[]> SuccessTestData = new object[][]
        {
            new object[]
            {
                new Size(10, 10)
            },
            new object[]
            {
                new Size(20, 15)
            }
        };

        public static IEnumerable<object[]> FailTestData = new object[][]
        {
            new object[]
            {
                new Size(0, 15)
            },
            new object[]
            {
                new Size(20, -20)
            }
        };
    }
}
