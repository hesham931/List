using Microsoft.EntityFrameworkCore;
using List.Models;

namespace List.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Item> items{ get; set; }
        public DbSet<Expenses> expenses{ get; set; }
    }
}