using ShopsTable.API.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopsTable.API.Services.Contracts
{
    public interface IShopService
    {
        Task<Shop> CreateAsync(Shop shop);

        Shop Get(Guid id);

        IEnumerable<Shop> Get();

    }
}
