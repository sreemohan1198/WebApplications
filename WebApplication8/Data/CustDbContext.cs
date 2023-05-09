using Microsoft.EntityFrameworkCore;
//using System.Collections.Generic;

namespace WebApplication8.Data
{
    public class CustDbContext: DbContext
    {
        public CustDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CustLogin> CustLogin { get; set; }
    }
}
