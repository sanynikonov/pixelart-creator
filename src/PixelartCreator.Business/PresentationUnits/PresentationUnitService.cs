using PixelartCreator.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelartCreator.Business
{
    public class PresentationUnitService : IPresentationUnitService
    {
        private readonly IRepository _repository;
        private readonly IImageStorage _storage;
        private readonly IPresentationUnitMentionsCounter _counter;

        public PresentationUnitService(IRepository repository, IImageStorage imageStorage)
        {
            _repository = repository;
            _storage = imageStorage;
        }

        public async Task<IEnumerable<BlockMentionsCount>> CountBlocksMentionsFromImageAsync(CountBlocksMentionsModel model)
        {
            var colorsMentions = await CountColorsMentionsFromImageAsync(model.ImagePath);

            var availiableIds = model.AvailibleBlocksIds;

            var blocks = await _repository.GetAsync<MinecraftBlock>(x => availiableIds.Contains(x.Id));

            var mentions = blocks.Select(block => new BlockMentionsCount
            {
                Id = block.Id,
                Name = block.Name,
                TexturePath = block.TexturePath,
                MentionsCount = 0
            });

            foreach (var color in colorsMentions)
            {
                foreach (var block in mentions)
                {
                    if (blocks.First(x => x.Id == block.Id).ColorId == color.Id)
                    {
                        block.MentionsCount = color.MentionsCount;
                    }
                }
            }

            return mentions;
        }

        public async Task<IEnumerable<ColorMentionsCount>> CountColorsMentionsFromImageAsync(string imagePath)
        {
            var image = _storage.GetImage(imagePath);

            var mentions = _counter.CountColorsMentions(image);

            var colors = await _repository.GetAsync<Color>();

            return colors.Join(mentions,
                x => System.Drawing.Color.FromArgb(x.A, x.R, x.G, x.B),
                x => x.Key,
                (c, m) => new ColorMentionsCount
                {
                    Id = c.Id,
                    A = c.A,
                    B = c.B,
                    R = c.R,
                    G = c.G,
                    MentionsCount = m.Value
                });
        }
    }
}
