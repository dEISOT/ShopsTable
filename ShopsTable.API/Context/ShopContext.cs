using Microsoft.EntityFrameworkCore;
using ShopsTable.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsTable.API.Context
{
    public class ShopContext : DbContext
    {
        public DbSet<Shop> Shops { get; set; }

        public ShopContext(DbContextOptions<ShopContext> options)
           : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
