using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PixelartCreator.Presentation.Data
{
    public class ColorPalletItem
    {
        public int Id { get; set; }
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }
        public byte A { get; set; }
        public bool Selected { get; set; }
    }
}
