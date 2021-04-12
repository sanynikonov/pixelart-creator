using PixelartCreator.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PixelartCreator.Infrastructure
{
    public class SeedingData
    {
        public IEnumerable<Color> Colors { get; set; }
        public IEnumerable<MinecraftBlock> Blocks { get; set; }
    }
}
