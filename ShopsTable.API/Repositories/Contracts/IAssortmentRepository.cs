using ShopsTable.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsTable.API.Repositories.Contracts
{
    public interface IAssortmentRepository
    {
        public IEnumerable<Assortment> GetByShopId(Guid ShopId);

        public IEnumerable<Assortment> Get();

        public Assortment Get(Guid id);

        Task<Assortment> CreateAsync(Assortment assortment);


    }
}
