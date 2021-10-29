using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPICoreEx.Models;

namespace WebAPICoreEx.Data
{
    public class CustDbContext : DbContext
    {
        public CustDbContext (DbContextOptions<CustDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPICoreEx.Models.Customer> Customer { get; set; }
    }
}
