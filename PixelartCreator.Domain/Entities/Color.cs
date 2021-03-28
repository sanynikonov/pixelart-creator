using System;
using System.Collections.Generic;
using System.Text;

namespace PixelartCreator.Domain
{
    public class Color : IBaseEntity
    {
        public int Id { get; set; }
        
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }
        public byte A { get; set; }

        public ICollection<MinecraftBlock> Blocks { get; set; }
    }
}
