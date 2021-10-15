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
                    new Item { Id=new Guid("d0fa052c-3872-445b-b1f0-9d97db19a5a3"), Name="Milk", Price=5.99, Description="", ShopId= new Guid("79c17863-1ef7-4ad8-9dd1-eb7e2cdf4d1d")},
                    new Item { Id=new Guid("6fe1bc2d-c786-4fd3-87dd-a84cbfecb2e1"), Name="Bread", Price=12.99, Description="", ShopId= new Guid("f2d0146a-a4f1-4f13-8500-8eb9ec045f45")},
                    new Item { Id=new Guid("ef967ca0-66db-44dd-ad7a-d3daf1c37587"), Name="Iphone13", Price=998.99, Description="", ShopId= new Guid("5ec8357b-541e-46cb-bf26-08058501e586")},
                    new Item { Id=new Guid("142cc352-1a11-415b-8608-691924863eff"), Name="T-Shirt", Price=8.99, Description="", ShopId= new Guid("5b00c426-6eaa-46d4-8268-b735b398f71d")},
                    new Item { Id=new Guid("f753da50-cdd4-4859-9743-150fe17273e4"), Name="Beer", Price=6.99, Description="", ShopId= new Guid("79c17863-1ef7-4ad8-9dd1-eb7e2cdf4d1d")}
                }
            );

            modelBuilder.Entity<Assortment>().HasData(
                new Assortment[]
                {
                    new Assortment { Id = new Guid("9d412f7e-378b-48e3-9c22-7b76572d0e02"), ItemId = new Guid("87b249c0-3a12-4f95-acfa-43ce00dbd4fe"), ShopId = new Guid("79c17863-1ef7-4ad8-9dd1-eb7e2cdf4d1d") },
                    new Assortment { Id = new Guid("c7351349-94d8-47ff-a89f-d24468b2552b"), ItemId = new Guid("d0fa052c-3872-445b-b1f0-9d97db19a5a3"), ShopId = new Guid("79c17863-1ef7-4ad8-9dd1-eb7e2cdf4d1d") },
                    new Assortment { Id = new Guid("2ebbe441-9008-49b0-8842-e0eac8639f48"), ItemId = new Guid("6fe1bc2d-c786-4fd3-87dd-a84cbfecb2e1"), ShopId = new Guid("f2d0146a-a4f1-4f13-8500-8eb9ec045f45") },
                    new Assortment { Id = new Guid("bdefab9e-d81d-4d54-99e1-27faa0668629"), ItemId = new Guid("ef967ca0-66db-44dd-ad7a-d3daf1c37587"), ShopId = new Guid("5ec8357b-541e-46cb-bf26-08058501e586") },
                    new Assortment { Id = new Guid("b0d1f3eb-462f-443b-9ef8-9c63728a2d2a"), ItemId = new Guid("142cc352-1a11-415b-8608-691924863eff"), ShopId = new Guid("5b00c426-6eaa-46d4-8268-b735b398f71d") },
                    new Assortment { Id = new Guid("bc21bc0b-f411-45e9-b374-309e213ad40b"), ItemId = new Guid("f753da50-cdd4-4859-9743-150fe17273e4"), ShopId = new Guid("79c17863-1ef7-4ad8-9dd1-eb7e2cdf4d1d") }
                }
            );
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Initialize(modelBuilder);
        }

        

    }


}
