using Microsoft.EntityFrameworkCore;
using mynewblazorapp.Entities;

namespace mynewblazorapp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {

        }

        public DbSet<Game> Games { get; set; }
    }
}