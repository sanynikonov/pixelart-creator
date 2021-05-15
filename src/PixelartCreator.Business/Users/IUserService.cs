using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PixelartCreator.Business
{
    public interface IUserService
    {
        Task<UserModel> GetAsync(int id);
        Task<IEnumerable<UserListItemModel>> GetAsync(PageFilter filter);
    }
}
