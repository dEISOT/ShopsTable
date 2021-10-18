using ShopsTable.API.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopsTable.API.Services.Contracts
{
    public interface IItemService
    {
        Item Get(Guid ShopId);

        Task<Item> CreateAsync(Item item);

        public IEnumerable<Item> Get();

        IEnumerable<Item> GetByShopId(Guid ShopID);

    }
}
