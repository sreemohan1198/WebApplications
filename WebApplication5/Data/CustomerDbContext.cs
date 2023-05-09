using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Identity.Client;

namespace WebApplication5.Data
{
    public class CustomerDbContext : DbContext
    {
       public CustomerDbContext(DbContextOptions options) : base(options) 
        { 
        }

        public DbSet<CustomerLogin> CustomerLogin { get; set; }
    }
}
