using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PixelartCreator.Business
{
    public interface IAuthService
    {
        Task<SignInResult> LoginAsync(LoginModel model);
        Task<SignInResult> TryLoginAsync(LoginModel model);
        Task<IdentityResult> RegisterAsync(RegistrationModel model);
        string GetUserId(ClaimsPrincipal principal);
        Task LogoutAsync();
    }
}
