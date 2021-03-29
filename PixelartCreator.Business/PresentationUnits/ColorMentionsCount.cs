using System;
using System.Collections.Generic;
using System.Text;

namespace PixelartCreator.Business
{
    public class ColorMentionsCount
    {
        public int Id { get; set; }
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }
        public byte A { get; set; }
        public int MentionsCount { get; set; }
    }
}
