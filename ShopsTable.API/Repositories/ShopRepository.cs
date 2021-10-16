using ShopsTable.API.Models;
using ShopsTable.API.Context;
using ShopsTable.API.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ShopsTable.API.Repositories
{
    public class ShopRepository : IShopRepository
    {
        private readonly ShopContext _db;

        public ShopRepository(ShopContext db)
        {
            _db = db;
        }

        public async Task<Shop> CreateAsync(Shop shop)
        {
            await _db.Shops.AddAsync(shop);
            await _db.SaveChangesAsync();
            return shop;
        }

        public Shop Get(Guid id)
        {
            
            return _db.Shops.FirstOrDefault(g => string.Equals(g.Id, id));
        }
        public IEnumerable<Shop> Get()
        {
            return _db.Shops;
        }
    }
}
