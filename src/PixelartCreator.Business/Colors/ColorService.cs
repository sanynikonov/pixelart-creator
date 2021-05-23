using PixelartCreator.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelartCreator.Business
{
    public class ColorService : IColorService
    {
        private readonly IRepository _repository;

        public ColorService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<ColorModel> GetAsync(int id)
        {
            var color = await _repository.GetAsync<Color>(id);

            return new ColorModel
            {
                A = color.A,
                B = color.B,
                R = color.R,
                G = color.G,
            };
        }

        public async Task<IEnumerable<ColorModel>> GetAsync()
        {
            var colors = await _repository.GetAsync<Color>();

            return colors.Select(color => new ColorModel
            {
                A = color.A,
                B = color.B,
                R = color.R,
                G = color.G,
            });
        }

        public async Task<IEnumerable<int>> GetColorsIdsAsync()
        {
            return (await _repository.GetAsync<Color>()).Select(x => x.Id);
        }

        public async Task<IEnumerable<ColorLibraryItemModel>> GetColorsLibraryAsync()
        {
            var entities = await _repository.GetAsync<Color>();

            var items = entities.Select(x =>
                new ColorLibraryItemModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    A = x.A,
                    B = x.B,
                    G = x.G,
                    R = x.R
                }).ToList();

            foreach (var item in items)
            {
                var id = item.Id;
                var blocks = await _repository.GetAsync<MinecraftBlock>(x => x.ColorId == id);
                item.BlocksNames = blocks.Select(x => x.Name);
            }

            return items;
        }
    }
}
