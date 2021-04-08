using PixelartCreator.Domain;
using System;
using System.Collections.Generic;
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

        public async Task<Color> GetAsync(int id)
        {
            return await _repository.GetAsync<Color>(id);
        }
    }
}
