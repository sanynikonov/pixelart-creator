using Microsoft.AspNetCore.Identity;
using PixelartCreator.Domain;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PixelartCreator.Business
{
    public class AuthService : IAuthService
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public AuthService(SignInManager<User> manager, UserManager<User> userManager)
        {
            _signInManager = manager;
            _userManager = userManager;
        }

        public string GetUserId(ClaimsPrincipal principal)
        {
            return _signInManager.UserManager.GetUserId(principal);
        }

        public async Task<SignInResult> TryLoginAsync(LoginModel model)
        {
            var user = await _userManager.FindByNameAsync(model.Login) ?? await _userManager.FindByEmailAsync(model.Login);
            return await _signInManager.CheckPasswordSignInAsync(user, model.Password, lockoutOnFailure: false);
        }


        public async Task<SignInResult> LoginAsync(LoginModel model)
        {
            var user = await _userManager.FindByNameAsync(model.Login) ?? await _userManager.FindByEmailAsync(model.Login);
            return await _signInManager.PasswordSignInAsync(user.UserName, model.Password, isPersistent: false, lockoutOnFailure: false);
        }

        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<IdentityResult> RegisterAsync(RegistrationModel model)
        {
            var user = new User
            {
                UserName = model.UserName,
                Email = model.Email,
            };

            return await _signInManager.UserManager.CreateAsync(user, model.Password);
        }
    }
}
