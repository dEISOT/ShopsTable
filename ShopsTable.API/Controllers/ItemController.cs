using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopsTable.API.Models;
using ShopsTable.API.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopsTable.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly ILogger<ItemController> _logger;
        private readonly IItemService _itemService;

        public ItemController(ILogger<ItemController> logger,
            IItemService itemService)
        {
            _logger = logger;
            _itemService = itemService;
        }

        [HttpPost]
        public async Task<Item> CreateAsync([FromBody] Item item)
        {
            await _itemService.CreateAsync(item);
            return item;
        }

        [HttpGet("{ShopId}")]
        public IEnumerable<Item> GetByShopId(Guid ShopId)
        {
            return _itemService.GetByShopId(ShopId);
        }
    }
}
