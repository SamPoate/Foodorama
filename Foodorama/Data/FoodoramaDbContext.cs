using Foodorama.Models;
using Microsoft.EntityFrameworkCore;

namespace Foodorama.Data
{
    public class FoodoramaDbContext : DbContext
    {
        public FoodoramaDbContext(DbContextOptions options)
            : base(options)
        {
            
        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
