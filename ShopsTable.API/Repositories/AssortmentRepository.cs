using ShopsTable.API.Context;
using ShopsTable.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsTable.API.Repositories
{
    public class AssortmentRepository
    {
        private readonly ShopContext _db;

        public AssortmentRepository(ShopContext db)
        {
            _db = db;
        }

        public async Task<Assortment> CreateAsync(Assortment assortment)
        {
            await _db.Assortments.AddAsync(assortment);
            await _db.SaveChangesAsync();
            return assortment;
        }

        public Assortment Get(Guid id)
        {

            return _db.Assortments.FirstOrDefault(g => string.Equals(g.Id, id));
        }
        public IEnumerable<Assortment> Get()
        {
            return _db.Assortments;
        }

        public IEnumerable<Assortment> GetByShopId(Guid ShopId)
        {
            return _db.Assortments.Where(b => string.Equals(b.ShopId, ShopId));
        }
    }
}
