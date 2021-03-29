using System;
using System.Collections.Generic;
using System.Text;

namespace PixelartCreator.Domain
{
    public interface IPresentationUnitMentionsCounter
    {
        Dictionary<System.Drawing.Color, int> CountColorsMentions(Image image);
    }
}
