using ShopsTable.API.Models;
using ShopsTable.API.Repositories.Contracts;
using ShopsTable.API.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopsTable.API.Services
{
    public class ShopService : IShopService
    {
        private readonly IShopRepository _shopRepository;

        public ShopService(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }

        public async Task<Shop> CreateAsync(Shop shop)
        {
            await _shopRepository.CreateAsync(shop);
            return shop;
        }

        public Shop Get(Guid id)
        {
            return _shopRepository.Get(id);
        }

        public IEnumerable<Shop> Get()
        {
            return _shopRepository.Get();
        }


    }
}

