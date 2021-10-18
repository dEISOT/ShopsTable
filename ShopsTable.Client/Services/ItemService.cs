using Newtonsoft.Json;
using ShopsTable.Client.Models;
using ShopsTable.Client.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShopsTable.Client.Services
{
    public class ItemService : IItemService
    {
        private readonly string hostUrl;

        public ItemService()
        {
            hostUrl = Settings.Url;
        }

        public async Task<IEnumerable<Item>> GetAsync(Guid Id)
        {

            HttpClient httpclient = new HttpClient();
            var result = await httpclient.GetAsync($"{hostUrl}/item/{Id}"); //занести в аппсетинг

            return JsonConvert.DeserializeObject<IEnumerable<Item>>(await result.Content.ReadAsStringAsync());
        }



        //public async Task<Item> CreateAsync(Item NewItem)
        //{

        //    HttpClient httpclient = new HttpClient();
        //    var result = await httpclient.CreateAsync($"https://localhost:44312/item/{Id}"); //занести в аппсетинг

        //    return JsonConvert.DeserializeObject<IEnumerable<Item>>(await result.Content.ReadAsStringAsync());
        //}
    }
}
