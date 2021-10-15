using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopsTable.API.Models;
using ShopsTable.API.Services.Contracts;

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

    [HttpGet("{ShopId}")]
    public IEnumerable<Item> GetByShopId(Guid ShopId)
        {
            return _itemService.GetByShopId(ShopId);
        }
    }
}
