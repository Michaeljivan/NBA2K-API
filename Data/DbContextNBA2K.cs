using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class DbContextNBA2K : DbContext
    {
        public DbContextNBA2K(DbContextOptions<DbContextNBA2K> options) : base(options) { }

        public DbSet<Player> Player { get; set; }

        public DbSet<PlayerHistory> PlayerHistory { get; set; }
    }
}
