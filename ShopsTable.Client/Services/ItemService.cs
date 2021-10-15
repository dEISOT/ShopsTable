using Newtonsoft.Json;
using ShopsTable.Client.Models;
using ShopsTable.Client.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShopsTable.Client.Services
{
    public class ItemService : IItemService
    {
        public async Task<IEnumerable<Item>> GetAsync()
        {
            HttpClient httpclient = new HttpClient();
            var result = await httpclient.GetAsync("https://localhost:44312/item"); //занести в аппсетинг

            return JsonConvert.DeserializeObject<IEnumerable<Item>>(await result.Content.ReadAsStringAsync());
        }
    }
}
