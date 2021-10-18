using ShopsTable.Client.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopsTable.Client.Services.Contracts
{
    public interface IShopService
    {
        Task<IEnumerable<Shop>> GetAsync();

        Task<Shop> GetAsync(Guid ShopId);

    }
}
