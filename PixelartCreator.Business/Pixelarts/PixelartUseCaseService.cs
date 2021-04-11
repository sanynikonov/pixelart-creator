using PixelartCreator.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = PixelartCreator.Domain.Color;

namespace PixelartCreator.Business
{
    public class PixelartUseCaseService : IPixelartUseCaseService
    {
        private readonly IImageStorage _storage;
        private readonly IRepository _repository;
        private readonly IPixelartGenerator _pixelartGenerator;

        public PixelartUseCaseService(IImageStorage storage, IRepository repository, IPixelartGenerator pixelartGenerator)
        {
            _storage = storage;
            _repository = repository;
            _pixelartGenerator = pixelartGenerator;
        }

        public async Task<PixelartCreationResultModel> CreateAsync(PixelartCreateModel model)
        {
            var image = _storage.GetImage(model.SourcePath);

            var ids = model.AvailibleColorsIds;
            var colors = await _repository.GetAsync<Color>(x => ids.Contains(x.Id));
            var options = new PixelizingOptions
            {
                AvailibleColors = colors.Select(x => System.Drawing.Color.FromArgb(x.A, x.R, x.G, x.B)),
                Size = model.Size * (int)model.Unit
            };

            var result = _pixelartGenerator.CreatePixelart(image, options);

            var path = _storage.SaveImage(result);

            return new PixelartCreationResultModel { ResultPath = path };
        }

        public async Task DeleteAsync(int id)
        {
            var pixelart = await _repository.GetAsync<Pixelart>(id);
            await _repository.DeleteAsync(pixelart);
        }

        public async Task<PixelartInfoModel> GetAsync(int id)
        {
            var pixelart = await _repository.GetAsync<Pixelart>(id);

            return new PixelartInfoModel
            {
                ResultPath = pixelart.ResultPath,
                SourcePath = pixelart.SourcePath,
                Id = pixelart.Id,
                CreatedAt = pixelart.CreatedAt,
                Description = pixelart.Description,
                UserId = pixelart.UserId
            };
        }

        public async Task<IEnumerable<PixelartInfoModel>> GetByUserAsync(int userId, PageFilter filter)
        {
            var pixelarts = await _repository.GetAsync<Pixelart>(x => x.UserId == userId, filter.PageNumber, filter.PageSize);

            return pixelarts.Select(x => new PixelartInfoModel
            {
                ResultPath = x.ResultPath,
                SourcePath = x.SourcePath,
                Id = x.Id,
                CreatedAt = x.CreatedAt,
                Description = x.Description,
                UserId = x.UserId
            });
        }

        public async Task SaveAsync(PixelartSaveModel model)
        {
            var pixelart = new Pixelart
            {
                ResultPath = model.ResultPath,
                SourcePath = model.SourcePath,
                Description = model.Description,
                UserId = model.UserId,
                CreatedAt = DateTime.Now
            };

            await _repository.AddAsync(pixelart);
        }

        public async Task UpdateAsync(PixelartUpdateModel model)
        {
            var pixelart = await _repository.GetAsync<Pixelart>(model.Id);
            pixelart.Description = model.Description;
            await _repository.UpdateAsync(pixelart);
        }
    }
}
