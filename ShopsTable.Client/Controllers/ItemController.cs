using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopsTable.Client.Services.Contracts;

namespace ShopsTable.Client.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemService _itemService;
        private readonly ILogger<ItemController> _logger;

        public ItemController(ILogger<ItemController> logger,
           IItemService itemService)
        {
            _logger = logger;
            _itemService = itemService;
        }

        public async Task<IActionResult> Detail()
        {
            var items = await _itemService.GetAsync();
            return View(items);
        }
    }
}
