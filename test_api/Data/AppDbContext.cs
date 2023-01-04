using Microsoft.EntityFrameworkCore;
using test_api.Models.Entities;

namespace test_api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }


        public DbSet<Person>? People { get; set; }
    }
}
