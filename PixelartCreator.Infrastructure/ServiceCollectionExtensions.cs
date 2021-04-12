using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OfficeOpenXml;
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
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            services
                .AddScoped<IImageStorage, FileService>(s => new FileService(rootPath))
                .AddScoped<IFileService, FileService>(s => new FileService(rootPath))
                .AddSingleton<IDatabaseSeedDataProvider>(s => new DatabaseSeedDataProvider(rootPath));

            services
                .AddIdentity<User, IdentityRole<int>>(opts => {
                    opts.Password.RequiredLength = 5;
                    opts.Password.RequireNonAlphanumeric = false;
                    opts.Password.RequireLowercase = false;
                    opts.Password.RequireUppercase = false;
                    opts.Password.RequireDigit = false;
                })
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            return services
                .AddScoped<IRepository, EfRepository>()
                .AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(connectionString));
        }
    }
}
