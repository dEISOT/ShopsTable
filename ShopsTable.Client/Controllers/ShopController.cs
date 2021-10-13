using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopsTable.Client.Models;
using ShopsTable.Client.Services.Contracts;

namespace ShopsTable.Client.Controllers
{
    public class ShopController : Controller
    {
        private readonly IShopService _shopService;
        private readonly ILogger<ShopController> _logger;

        public ShopController(ILogger<ShopController> logger, IShopService shopService)
        {
            _logger = logger;
            _shopService = shopService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var shops = await _shopService.GetAsync();
            return View(shops);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
