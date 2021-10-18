using Newtonsoft.Json;
using ShopsTable.Client.Models;
using ShopsTable.Client.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShopsTable.Client.Services
{
    public class ShopService : IShopService
    {
        private readonly string hostUrl;

        public ShopService()
        {
            hostUrl = Settings.Url;
        }

        public async Task<IEnumerable<Shop>> GetAsync()
        {
            HttpClient httpclient = new HttpClient();
            var result = await httpclient.GetAsync($"{hostUrl}/shop"); //занести в аппсетинг

            return JsonConvert.DeserializeObject<IEnumerable<Shop>>(await result.Content.ReadAsStringAsync());
        }

        public async Task<Shop> GetAsync(Guid ShopId)
        {
            HttpClient httpclient = new HttpClient();
            var result = await httpclient.GetAsync($"{hostUrl}/shop/{ShopId}"); //занести в аппсетинг

            return JsonConvert.DeserializeObject<Shop>(await result.Content.ReadAsStringAsync());
        }

    }
}
