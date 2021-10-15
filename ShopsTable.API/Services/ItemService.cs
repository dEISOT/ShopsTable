using ShopsTable.API.Models;
using ShopsTable.API.Repositories.Contracts;
using ShopsTable.API.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsTable.API.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;
        private readonly IAssortmentService _assortmentService;


        public ItemService(IItemRepository itemRepository, IAssortmentService assortmentService)
        {
            _itemRepository = itemRepository;
            _assortmentService = assortmentService;

        }



        public async Task<Item> CreateAsync(Item item)
        {
            await _itemRepository.CreateAsync(item);
            return item;
        }

        public Item Get(Guid id)
        {
            return _itemRepository.Get(id);
        }

        public IEnumerable<Item> Get()
        {
            return _itemRepository.Get();
        }

        public IEnumerable<Item> GetByShopId(Guid ShopID)
        {
            IEnumerable<Guid> itemIDs = _assortmentService.GetItemsIDByShopID(ShopID);
            List<Item> items = new List<Item>();
            foreach(Guid id in itemIDs)
            {
                items.Add(Get(id));
            }
            return items;
        }
    }
}
