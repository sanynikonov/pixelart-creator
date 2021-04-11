using Microsoft.EntityFrameworkCore;

namespace PixelartCreator.Infrastructure
{
    public interface IDatabaseSeedDataProvider
    {
        void Seed(ModelBuilder builder);
    }
}