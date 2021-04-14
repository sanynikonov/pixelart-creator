using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PixelartCreator.Business
{
    public interface IPixelartService
    {
        Task<PixelartCreationResultModel> CreateAsync(PixelartCreateModel model);
        Task SaveAsync(PixelartSaveModel model);
        Task UpdateAsync(PixelartUpdateModel model);
        Task DeleteAsync(int id);
        Task<IEnumerable<PixelartInfoModel>> GetByUserAsync(int userId, PageFilter filter);
        Task<IEnumerable<PixelartListItemModel>> GetAsync(PageFilter filter);
        Task<PixelartInfoModel> GetAsync(int id);
    }
}
