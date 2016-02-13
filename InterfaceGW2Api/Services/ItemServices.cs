using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using InterfaceGW2Api.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InterfaceGW2Api.Services
{
    public class ItemServices
    {
        private const string WebApiGetItemName = "http://api.gw2tp.com/1/bulk/items-names.json";
        private const string GW2ApiItem = "https://api.guildwars2.com/v2/items/";
        private const string GW2ApiItemPrices = "https://api.guildwars2.com/v2/commerce/prices/";
        private const string GW2ApiItemListings = "https://api.guildwars2.com/v2/commerce/listings/";

        public ListingsViewModel GetItemListingsViewModel(int itemId)
        {
            var httpWebRequest = (HttpWebRequest) WebRequest.Create(GW2ApiItemListings + itemId);
            httpWebRequest.Method = "GET";
            var result = new ListingsViewModel();
            var response = httpWebRequest.GetResponse();
            using (var responseStream = response.GetResponseStream())
            {
                var reader = new StreamReader(responseStream, Encoding.UTF8);
                result = JsonConvert.DeserializeObject<ListingsViewModel>(reader.ReadToEnd());
            }
            return result;
        }

        public List<SimpleItemViewModel> GetItemViewModels()
        {
            var httpWebRequest = (HttpWebRequest) WebRequest.Create(WebApiGetItemName);
            httpWebRequest.Method = "GET";
            var collection = new ItemCollection();
            var response = httpWebRequest.GetResponse();
            using (var responseStream = response.GetResponseStream())
            {
                var reader = new StreamReader(responseStream, Encoding.UTF8);
                collection = JsonConvert.DeserializeObject<ItemCollection>(reader.ReadToEnd());
            }
            var listResult = new List<SimpleItemViewModel>();
            for (int i = 0; i<collection.items.GetLength(0); i++)
            {
                listResult.Add(new SimpleItemViewModel()
                {
                    Id = collection.items[i,0],
                    Name = collection.items[i,1]
                });
            }
            return listResult;
        }

        public List<SimpleItemViewModel> GetItemViewModels(string searchBy)
        {
            List<SimpleItemViewModel> itemList = GetItemViewModels().Where(x=>x.Name.IndexOf(searchBy, StringComparison.InvariantCultureIgnoreCase)!=-1).ToList();
            return itemList;
        }

        public CompleteItemViewModel GetCompleteItemViewModel(int itemId)
        {
            var httpWebRequest = (HttpWebRequest) WebRequest.Create(GW2ApiItem + itemId);
            httpWebRequest.Method = "GET";
            var completeItem = new CompleteItemViewModel();
            var response = httpWebRequest.GetResponse();
            using (var responseStream = response.GetResponseStream())
            {
                var reader = new StreamReader(responseStream, Encoding.UTF8);
                var readerString = reader.ReadToEnd();
                completeItem = JsonConvert.DeserializeObject<CompleteItemViewModel>(readerString);
            }
            return completeItem;
        }

        public ItemPrices GetItemPrices(int itemId)
        {
            var httpWebRequest = (HttpWebRequest) WebRequest.Create(GW2ApiItemPrices + itemId);
            httpWebRequest.Method = "GET";
            var result = new ItemPrices();
            var response = httpWebRequest.GetResponse();
            using (var resStream = response.GetResponseStream())
            {
                var reader = new StreamReader(resStream, Encoding.UTF8);
                var readerString = reader.ReadToEnd();
                result = JsonConvert.DeserializeObject<ItemPrices>(readerString);
            }
            return result;
        }
    }
}