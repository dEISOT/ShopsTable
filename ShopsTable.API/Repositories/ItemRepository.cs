using ShopsTable.API.Context;
using ShopsTable.API.Models;
using ShopsTable.API.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsTable.API.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly ShopContext _db;

        public ItemRepository(ShopContext db)
        {
            _db = db;
        }

        public async Task<Item> CreateAsync(Item item)
        {
            await _db.Items.AddAsync(item);
            await _db.SaveChangesAsync();
            return item;
        }

        public Item Get(Guid id)
        {

            return _db.Items.FirstOrDefault(g => string.Equals(g.Id, id));
        }
        public IEnumerable<Item> Get()
        {
            return _db.Items;
        }

    }
}
