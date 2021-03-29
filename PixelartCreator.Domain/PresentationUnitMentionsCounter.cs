using System;
using System.Collections.Generic;
using System.Text;

namespace PixelartCreator.Domain
{
    public class PresentationUnitMentionsCounter : IPresentationUnitMentionsCounter
    {
        public Dictionary<System.Drawing.Color, int> CountColorsMentions(Image image)
        {
            var mentions = new Dictionary<System.Drawing.Color, int>();

            foreach (var color in image.Pixels)
            {
                if (!mentions.ContainsKey(color))
                {
                    mentions[color] = 0;
                }

                mentions[color]++;
            }

            return mentions;
        }
    }
}
