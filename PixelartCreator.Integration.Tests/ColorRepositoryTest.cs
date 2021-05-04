using Microsoft.EntityFrameworkCore;
using PixelartCreator.Domain;
using PixelartCreator.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PixelartCreator.Integration.Tests
{
    public class ColorRepositoryTest : BaseRepositoryTest
    {
        private readonly IRepository _repository;

        public ColorRepositoryTest()
        {
            _repository = new EfRepository(_context);
        }

        [Fact]
        public async Task AddAsync_Item_SavesToDb()
        {
            var expected = new Color { R = 1, G = 2, B = 3, A = 4, Name = "cool" };

            await _repository.AddAsync(expected);

            var actual = await _context.Colors.FirstAsync();
            AssertColorsAreEqualWithoutId(expected, actual);
        }

        [Fact]
        public async Task GetAsync_ById_ReturnsItem()
        {
            var expected = new Color { R = 1, G = 2, B = 3, A = 4, Name = "cool" };
            await _context.AddAsync(expected);
            await _context.SaveChangesAsync();

            var actual = await _repository.GetAsync<Color>(expected.Id);

            AssertColorsAreEqual(expected, actual);
        }

        [Fact]
        public async Task GetAsync_ByPage_ReturnsPageOfItems()
        {
            var colors = new[]
            {
                new Color { R = 1, G = 2, B = 3, A = 4, Name = "cool" },
                new Color { R = 1, G = 2, B = 3, A = 4, Name = "hot" },
                new Color { R = 1, G = 2, B = 3, A = 4, Name = "clean" },
            };
            await _context.AddRangeAsync(colors);
            await _context.SaveChangesAsync();

            var result = await _repository.GetAsync<Color>(x => true, pageNumer: 1, pageSize: 2);

            var expected = colors[0..2];
            var actual = result.ToArray();

            Assert.Equal(expected.Length, actual.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                AssertColorsAreEqual(expected[i], actual[i]);
            }
        }

        [Fact]
        public async Task GetAsync_ByCondition_ReturnsFilteredItems()
        {
            var colors = new[]
            {
                new Color { R = 1, G = 2, B = 3, A = 4, Name = "cool" },
                new Color { R = 1, G = 2, B = 3, A = 4, Name = "hot" },
                new Color { R = 1, G = 2, B = 3, A = 4, Name = "clean" },
            };
            await _context.AddRangeAsync(colors);
            await _context.SaveChangesAsync();

            var result = await _repository.GetAsync<Color>(x => x.Name == "hot");

            var expected = colors[1];
            var actual = result.First();

            AssertColorsAreEqual(expected, actual);
        }

        [Fact]
        public async Task UpdateAsync_Item_UpdatesInDb()
        {
            var expected = new Color { R = 1, G = 2, B = 3, A = 4, Name = "cool" };
            await _context.AddAsync(expected);
            await _context.SaveChangesAsync();

            expected.Name = "new";
            expected.R = 10;
            await _repository.UpdateAsync(expected);

            var actual = await _context.Colors.FirstAsync();
            AssertColorsAreEqual(expected, actual);
        }

        [Fact]
        public async Task DeleteAsync_Item_DeletesFromDb()
        {
            var color = new Color { R = 1, G = 2, B = 3, A = 4, Name = "cool" };
            await _context.AddAsync(color);
            await _context.SaveChangesAsync();

            await _repository.DeleteAsync(color);

            var actual = await _context.Colors.CountAsync();
            Assert.Equal(0, actual);
        }

        [Fact]
        public async Task CountAsync_Item_CountsMentions()
        {
            var colors = new[]
            {
                new Color { R = 1, G = 2, B = 3, A = 4, Name = "cool" },
                new Color { R = 1, G = 2, B = 3, A = 4, Name = "hot" },
                new Color { R = 1, G = 2, B = 3, A = 4, Name = "clean" },
            };
            await _context.AddRangeAsync(colors);
            await _context.SaveChangesAsync();

            var actual = await _repository.CountAsync<Color>(x => x.Name == "hot");

            Assert.Equal(1, actual);
        }

        private void AssertColorsAreEqualWithoutId(Color expected, Color actual)
        {
            Assert.Equal(expected.R, actual.R);
            Assert.Equal(expected.G, actual.G);
            Assert.Equal(expected.B, actual.B);
            Assert.Equal(expected.A, actual.A);
            Assert.Equal(expected.Name, actual.Name);
        }

        private void AssertColorsAreEqual(Color expected, Color actual)
        {
            Assert.Equal(expected.Id, actual.Id);

            AssertColorsAreEqualWithoutId(expected, actual);
        }
    }
}
