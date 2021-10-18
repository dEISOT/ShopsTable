using ShopsTable.API.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopsTable.API.Repositories.Contracts
{
    public interface IItemRepository
    {

        public Item Get(Guid id);

        public IEnumerable<Item> Get();

        Task<Item> CreateAsync(Item item);

    }
}
