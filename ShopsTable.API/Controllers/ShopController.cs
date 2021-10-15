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
    public class ShopController : ControllerBase
    {

        private readonly ILogger<ShopController> _logger;
        private readonly IShopService _shopService;

        public ShopController(ILogger<ShopController> logger,
            IShopService shopService)
        {
            _logger = logger;
            _shopService = shopService;
        }

        [HttpPost]
        public async Task<Shop> CreateAsync([FromBody] Shop shop)
        {
            await _shopService.CreateAsync(shop);
            return shop;
        }

        [HttpGet("{id}")]
        public Shop Get(Guid id)
        {
            var result = _shopService.Get(id);
            return result;
        }


        [HttpGet]
        public IEnumerable<Shop> Get()
        {
            return _shopService.Get();
        }

    }

}
