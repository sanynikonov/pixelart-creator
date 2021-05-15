using System;
using System.Collections.Generic;
using System.Text;

namespace PixelartCreator.Domain
{
    public class MinecraftBlock : IBaseEntity
    {
        public int Id { get; set; }

        public string TexturePath { get; set; }
        public string Name { get; set; }

        public Color MapColor { get; set; }
        public int ColorId { get; set; }
    }
}
