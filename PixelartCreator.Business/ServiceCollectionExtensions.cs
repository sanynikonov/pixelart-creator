using Microsoft.Extensions.DependencyInjection;
using PixelartCreator.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PixelartCreator.Business
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IPixelartGenerator, PixelartGenerator>();

            return services
                .AddScoped<IAuthService, AuthService>()
                .AddScoped<IColorService, ColorService>()
                .AddScoped<IPixelartService, PixelartService>()
                .AddScoped<IPresentationUnitService, PresentationUnitService>()
                .AddScoped<IUserService, UserService>();
        }
    }
}
