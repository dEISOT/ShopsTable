﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsTable.Client.Services.Contracts
{
    public interface IShopService
    {
        Task<IEnumerable<Shop>> GetAsync();
    }
}