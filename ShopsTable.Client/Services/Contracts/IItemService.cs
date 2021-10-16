using ShopsTable.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsTable.Client.Services.Contracts
{
    public interface IItemService
    {
        Task<IEnumerable<Item>> GetAsync(Guid Id);



    }

}
