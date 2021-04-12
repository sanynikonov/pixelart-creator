using System.Collections.Generic;
using System.Drawing;

namespace PixelartCreator.Business
{
    public class ColorLibraryItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }
        public byte A { get; set; }
        public IEnumerable<string> BlocksNames { get; set; } = new List<string>();
    }
}