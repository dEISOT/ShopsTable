using ShopsTable.API.Models;
using ShopsTable.API.Repositories.Contracts;
using ShopsTable.API.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsTable.API.Services
{
    public class AssortmentService : IAssortmentService
    {
        private readonly IAssortmentRepository _assortmentRepository;

        public AssortmentService(IAssortmentRepository assortmentRepository)
        {
            _assortmentRepository = assortmentRepository;
        }

        public async Task<Assortment> CreateAsync(Assortment assortment)
        {
            await _assortmentRepository.CreateAsync(assortment);
            return assortment;
        }

        public Assortment Get(Guid id)
        {
            return _assortmentRepository.Get(id);
        }

        public IEnumerable<Assortment> Get()
        {
            return _assortmentRepository.Get();
        }

        public IEnumerable<Guid> GetItemsIDByShopID(Guid ShopId)
        {
            return _assortmentRepository.GetByShopId(ShopId).Select(b => b.ItemId);
        }
    }
}
