using PixelartCreator.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PixelartCreator.Business
{
    public class UserService : IUserService
    {
        private readonly IRepository _repository;

        public UserService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<UserModel> GetAsync(int id)
        {
            var user = await _repository.GetAsync<User>(id);

            return new UserModel
            {
                UserName = user.UserName,
                Email = user.Email,
                Id = user.Id
            };
        }

        public async Task<IEnumerable<UserListItemModel>> GetAsync(PageFilter filter)
        {
            var users = await _repository.GetAsync<User>(pageNumer: filter.PageNumber, pageSize: filter.PageSize);

            var models = new List<UserListItemModel>();

            foreach (var user in users)
            {
                var model = new UserListItemModel
                {
                    UserName = user.UserName,
                    Id = user.Id,
                    PixelartsCount = await _repository.CountAsync<Pixelart>(x => x.UserId == user.Id)
                };

                models.Add(model);
            }

            return models;
        }
    }
}
