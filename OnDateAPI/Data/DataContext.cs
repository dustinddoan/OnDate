using Microsoft.EntityFrameworkCore;
using OnDateAPI.Models;

namespace OnDateAPI.Data
{
    public class DataContext : DbContext
    {
        // DbContextOption with type DataContext change to base constructor
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
            
        }

        // tell EF about the entity, type DbSet type Value, Values=> table name
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
    }
}