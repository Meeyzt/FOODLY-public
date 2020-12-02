using Microsoft.EntityFrameworkCore;

namespace Foodly.Models.EfModels
{
    public class Context:DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }
    }
}
