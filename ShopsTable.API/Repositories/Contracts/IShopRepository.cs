using ShopsTable.API.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopsTable.API.Repositories.Contracts
{
    public interface IShopRepository
    {
        Task<Shop> CreateAsync(Shop game);

        Shop Get(Guid id);

        IEnumerable<Shop> Get();
    }

}
