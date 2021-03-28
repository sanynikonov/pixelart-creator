using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PixelartCreator.Business
{
    public class PixelartCreateModel
    {
        public string SourcePath { get; set; }
        public Size Size { get; set; }
        public SizeUnit Unit { get; set; }
        public IEnumerable<int> AvailibleColorsIds { get; set; } = new List<int>();
    }
}
