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
        public DbSet<Item> Items { get; set; }

        public ShopContext(DbContextOptions<ShopContext> options)
          : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        void Initialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shop>().HasData(
                 new Shop[]
                 {
                    new Shop { Id=new Guid("79c17863-1ef7-4ad8-9dd1-eb7e2cdf4d1d"), Name="Evroopt", Adress="Kurchatova,8", WorkTime = "8:00-20:00"},
                    new Shop { Id=new Guid("5b00c426-6eaa-46d4-8268-b735b398f71d"), Name="Sosedi", Adress="Kurchatova,5", WorkTime = "10:00-17:00"},
                    new Shop { Id=new Guid("245fac6d-6e3c-4984-ab80-57be57dff0af"), Name="Kopeechka", Adress="Kurchatova,6", WorkTime = "9:00-15:30"}
                 }
             );

            modelBuilder.Entity<Item>().HasData(
                new Item[]
                {
                    new Item { Id=new Guid("87b249c0-3a12-4f95-acfa-43ce00dbd4fe"), Name="Chiken", Price=19.99, Description="", ShopId= new Guid("79c17863-1ef7-4ad8-9dd1-eb7e2cdf4d1d")},
                    new Item { Id=new Guid("d0fa052c-3872-445b-b1f0-9d97db19a5a3"), Name="Milk", Price=9.99, Description="", ShopId= new Guid("79c17863-1ef7-4ad8-9dd1-eb7e2cdf4d1d")},
                    new Item { Id=new Guid("f753da50-cdd4-4859-9743-150fe17273e4"), Name="Beer", Price=6.99, Description="", ShopId= new Guid("79c17863-1ef7-4ad8-9dd1-eb7e2cdf4d1d")}
                }
            );
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Initialize(modelBuilder);

            modelBuilder.Entity<Item>()
                .HasOne(p => p.Shop)
                .WithMany(t => t.Items)
                .HasForeignKey(p => p.ShopId);
        }

        

    }


}
