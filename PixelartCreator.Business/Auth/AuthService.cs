using Microsoft.AspNetCore.Identity;
using PixelartCreator.Domain;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PixelartCreator.Business
{
    public class AuthService : IAuthService
    {
        private readonly SignInManager<User> _manager;

        public AuthService(SignInManager<User> manager)
        {
            _manager = manager;
        }

        public string GetUserId(ClaimsPrincipal principal)
        {
            return _manager.UserManager.GetUserId(principal);
        }

        public async Task<SignInResult> LoginAsync(LoginModel model)
        {
            return await _manager.PasswordSignInAsync(model.Login, model.Password, isPersistent: false, lockoutOnFailure: false);
        }

        public async Task LogoutAsync()
        {
            await _manager.SignOutAsync();
        }

        public async Task<IdentityResult> RegisterAsync(RegistrationModel model)
        {
            var user = new User
            {
                UserName = model.Email,
                Email = model.Email,
            };

            return await _manager.UserManager.CreateAsync(user, model.Password);
        }
    }
}
