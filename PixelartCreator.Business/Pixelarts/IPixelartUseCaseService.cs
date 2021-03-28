using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PixelartCreator.Business
{
    public interface IPixelartUseCaseService
    {
        Task<PixelartCreationResultModel> Create(PixelartCreateModel model);
        Task Save(PixelartSaveModel model);
        Task Update(PixelartUpdateModel model);
        Task Delete(int id);
        Task<IEnumerable<PixelartInfoModel>> GetByUser(int userId, PageFilter filter);
        Task<PixelartInfoModel> Get(int id);
    }
}
