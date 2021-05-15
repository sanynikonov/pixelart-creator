using Microsoft.AspNetCore.Http;
using PixelartCreator.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PixelartCreator.Presentation.Middlewares
{
    public class BlazorLogoutMiddleware
    {
        private readonly RequestDelegate _next;

        public BlazorLogoutMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, IAuthService authService)
        {
            if (context.Request.Path == "/middlewares/logout")
            {
                await authService.LogoutAsync();

                context.Response.Redirect("/");
            }
            else
            {
                await _next.Invoke(context);
            }
        }

    }
}
