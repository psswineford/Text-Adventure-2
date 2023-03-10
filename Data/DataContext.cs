using Microsoft.EntityFrameworkCore;
using Text_Adventure_2.Models;

namespace Text_Adventure_2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Characters> Characters { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<Rooms> Rooms { get; set; }


    }
}
