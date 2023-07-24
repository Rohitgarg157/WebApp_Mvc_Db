using Microsoft.EntityFrameworkCore;

namespace WebApp_Mvc_Db.Models
{
    public class AppdbContext:DbContext
    {
        public AppdbContext(DbContextOptions<AppdbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
