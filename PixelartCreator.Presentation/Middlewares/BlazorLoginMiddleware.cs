using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using PixelartCreator.Business;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PixelartCreator.Presentation.Middlewares
{
    public class BlazorLoginMiddleware
    {
        public static IDictionary<Guid, LoginModel> Logins { get; private set; }
            = new ConcurrentDictionary<Guid, LoginModel>();


        private readonly RequestDelegate _next;

        public BlazorLoginMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, IAuthService signInMgr)
        {
            if (context.Request.Path == "/middlewares/login" && context.Request.Query.ContainsKey("key"))
            {
                var key = Guid.Parse(context.Request.Query["key"]);
                var info = Logins[key];

                var result = await signInMgr.LoginAsync(info);
                info.Password = null;
                if (result.Succeeded)
                {
                    Logins.Remove(key);
                    context.Response.Redirect("/profile");
                    return;
                }
                else
                {
                    context.Response.Redirect("/error");
                    return;
                }
            }
            else
            {
                await _next.Invoke(context);
            }
        }
    }
}
