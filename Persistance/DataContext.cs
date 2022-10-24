using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistance
{
    public class DataContext : DbContext
    {
        public DbSet<Activity> Activities { get; set; }
        public DataContext(DbContextOptions options) :base(options)
        {

        }
    }
}