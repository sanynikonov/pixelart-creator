using System;
using System.Collections.Generic;
using System.Text;

namespace PixelartCreator.Business
{
    public class CountBlocksMentionsModel
    {
        public IEnumerable<int> AvailibleBlocksIds { get; set; }
        public string ImagePath { get; set; }
    }
}
