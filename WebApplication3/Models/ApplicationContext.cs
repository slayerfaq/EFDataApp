using Microsoft.EntityFrameworkCore;

namespace EFDataApp.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Base> Bases { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создание БД при первом обращении
        }
    }
}