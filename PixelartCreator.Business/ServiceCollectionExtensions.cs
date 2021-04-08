using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace PixelartCreator.Business
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            return services
                .AddScoped<IAuthService, AuthService>()
                .AddScoped<IColorService, ColorService>()
                .AddScoped<IPixelartUseCaseService, PixelartUseCaseService>()
                .AddScoped<IPresentationUnitService, PresentationUnitService>()
                .AddScoped<IUserService, UserService>();
        }
    }
}
