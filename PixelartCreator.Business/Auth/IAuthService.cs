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
        Task<SignInResult> Login(LoginModel model);
        Task<IdentityResult> Register(RegistrationModel model);
        string GetUserId(ClaimsPrincipal principal);
        Task Logout();
    }
}
