using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PixelartCreator.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PixelartCreator.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, string connectionString, string rootPath)
        {
            return services
                .AddScoped<IImageStorage, FileService>(s => new FileService(rootPath))
                .AddScoped<IFileService, FileService>(s => new FileService(rootPath))
                .AddSingleton<IDatabaseSeedDataProvider>(s => new DatabaseSeedDataProvider(rootPath))
                .AddDbContextPool<AppDbContext>(options =>
                    options.UseSqlServer(connectionString));
        }
    }
}
