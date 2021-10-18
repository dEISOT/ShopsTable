using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopsTable.Client.Services.Contracts;
using System;
using System.Threading.Tasks;

namespace ShopsTable.Client.Controllers
{
    public class ShopController : Controller
    {
        private readonly IShopService _shopService;
        private readonly ILogger<ShopController> _logger;
        private readonly IItemService _itemService;

        public ShopController(ILogger<ShopController> logger,
            IShopService shopService, IItemService itemService)
        {
            _logger = logger;
            _shopService = shopService;
            _itemService = itemService;
        }

        public async Task<IActionResult> Index()
        {
            var shops = await _shopService.GetAsync();
            return View(shops);
        }

        public async Task<IActionResult> Detail(Guid shopId)
        {
            var items = await _itemService.GetAsync(shopId);
            var shop = await _shopService.GetAsync(shopId);
            ViewBag.Items = items;
            return View("Detail", shop);
        }
    }
}
