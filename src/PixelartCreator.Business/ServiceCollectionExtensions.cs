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
            services
                .AddScoped<IPixelartGenerator, PixelartGenerator>()
                .AddScoped<IImageResizer, ImageResizer>()
                .AddScoped<IPresentationUnitMentionsCounter, PresentationUnitMentionsCounter>();

            return services
                .AddScoped<IAuthService, AuthService>()
                .AddScoped<IColorService, ColorService>()
                .AddScoped<IPixelartService, PixelartService>()
                .AddScoped<IPresentationUnitService, PresentationUnitService>()
                .AddScoped<IUserService, UserService>();
        }
    }
}
