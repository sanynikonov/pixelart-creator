using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PixelartCreator.Business
{
    public interface IPresentationUnitService
    {
        Task<IEnumerable<ColorMentionsCount>> CountColorsMentionsFromImageAsync(string imagePath);
        Task<IEnumerable<BlockMentionsCount>> CountBlocksMentionsFromImageAsync(CountBlocksMentionsModel model);
    }
}
