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
    public class ShopService : IShopService
    {
        public async Task<IEnumerable<Shop>> GetAsync()
        {
            HttpClient httpclient = new HttpClient();
            var result = await httpclient.GetAsync("https://localhost:44370/game");

            return JsonConvert.DeserializeObject<IEnumerable<Shop>>(await result.Content.ReadAsStringAsync());
        }
    }
}
