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
        public DbSet<Assortment> Assortments { get; set; }

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
                    new Shop { Id=new Guid("79c17863-1ef7-4ad8-9dd1-eb7e2cdf4d1d"), Name="Evroopt", Adress="Kurchatova, 8", WorkTime = "8:00-20:00"},
                    new Shop { Id=new Guid("5b00c426-6eaa-46d4-8268-b735b398f71d"), Name="Sosedi", Adress="Kurchatova, 5", WorkTime = "10:00-17:00"},
                    new Shop { Id=new Guid("5ec8357b-541e-46cb-bf26-08058501e586"), Name="Kopeechka", Adress="Kurchatova, 8", WorkTime = "8:00-20:00"},
                    new Shop { Id=new Guid("f2d0146a-a4f1-4f13-8500-8eb9ec045f45"), Name="Korona", Adress="Sovetskaya, 3", WorkTime = "5:00-13:00"}
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

            modelBuilder.Entity<Assortment>().HasData(
                new Assortment[]
                {
                    new Assortment { Id = new Guid("9d412f7e-378b-48e3-9c22-7b76572d0e02"), ItemId = new Guid("87b249c0-3a12-4f95-acfa-43ce00dbd4fe"), ShopId = new Guid("79c17863-1ef7-4ad8-9dd1-eb7e2cdf4d1d") },
                    new Assortment { Id = new Guid("c7351349-94d8-47ff-a89f-d24468b2552b"), ItemId = new Guid("d0fa052c-3872-445b-b1f0-9d97db19a5a3"), ShopId = new Guid("79c17863-1ef7-4ad8-9dd1-eb7e2cdf4d1d") },
                    new Assortment { Id = new Guid("bc21bc0b-f411-45e9-b374-309e213ad40b"), ItemId = new Guid("f753da50-cdd4-4859-9743-150fe17273e4"), ShopId = new Guid("79c17863-1ef7-4ad8-9dd1-eb7e2cdf4d1d") }
                }
            );
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Initialize(modelBuilder);

            //modelBuilder.Entity<Item>()
            //    .HasOne(p => p.Shop)
            //    .WithMany(t => t.Items)
            //    .HasForeignKey(p => p.ShopId);

            modelBuilder.Entity<Shop>()
            .HasMany(c => c.Items)
            .WithMany(p => p.Shops)
            .UsingEntity(j => j.ToTable("Assortment"));
        }

        

    }


}
