using ShopsTable.API.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopsTable.API.Services.Contracts
{
    public interface IAssortmentService
    {
        Task<Assortment> CreateAsync(Assortment assortment);

        Assortment Get(Guid id);

        IEnumerable<Assortment> Get();
        IEnumerable<Guid> GetItemsIDByShopID(Guid ShopId);

    }
}
