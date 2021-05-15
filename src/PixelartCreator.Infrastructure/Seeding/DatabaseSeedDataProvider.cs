using Microsoft.EntityFrameworkCore;
using PixelartCreator.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PixelartCreator.Infrastructure
{
    public class DatabaseSeedDataProvider : IDatabaseSeedDataProvider
    {
        private string _path;

        public DatabaseSeedDataProvider(string path)
        {
            _path = path;
        }

        public void Seed(ModelBuilder modelBuilder)
        {
            var parser = new XlsColorsParser(_path);

            var data = parser.GetAll();

            modelBuilder.Entity<Color>().HasData(data.Colors);

            modelBuilder.Entity<MinecraftBlock>().HasData(data.Blocks);
        }
    }
}
