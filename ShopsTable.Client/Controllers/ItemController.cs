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
    }
}
