using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PixelartCreator.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PixelartCreator.Infrastructure
{
    public class AppDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        private IDatabaseSeedDataProvider _provider;

        public DbSet<MinecraftBlock> MinecraftBlocks { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Pixelart> Pixelarts { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options, IDatabaseSeedDataProvider provider) : base(options)
        {
            _provider = provider;
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            _provider.Seed(builder);
        }
    }
}
