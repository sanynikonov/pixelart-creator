using Microsoft.EntityFrameworkCore;
using PixelartCreator.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace PixelartCreator.Integration.Tests
{
    public class BaseRepositoryTest : IDisposable
    {
        protected readonly AppDbContext _context;

        public BaseRepositoryTest()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new AppDbContext(options, null);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
