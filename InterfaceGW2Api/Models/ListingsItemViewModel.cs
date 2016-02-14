using System.Collections.Generic;

namespace InterfaceGW2Api.Models
{
    public class Buy
    {
        public int listings { get; set; }
        public int unit_price { get; set; }
        public int quantity { get; set; }
    }

    public class Sell
    {
        public int listings { get; set; }
        public int unit_price { get; set; }
        public int quantity { get; set; }
    }

    public class ListingsViewModel
    {
        public int id { get; set; }
        public List<Buy> buys { get; set; }
        public List<Sell> sells { get; set; }
    }

    //Chart array data
    public class ListingChartViewModel
    {
        public int ItemId { get; set; }
        public int[] BuyListingsInts { get; set; }
        public int[] SellListingInts { get; set; }

        public int[] BuyPriceInts { get; set; }
        public int[] SellPriceInts { get; set; }

        public int[] BuyQuantityInts { get; set; }
        public int[] SellQuantityInts { get; set; }

        private ListingChartViewModel(){}

        //ctor populates arrays for buy and sell charts
        public ListingChartViewModel(ListingsViewModel model)
        {
            ItemId = model.id;
            int modelBuysArrayLength = model.buys.Count;
            int modelSellsArrayLength = model.sells.Count;
            BuyListingsInts = new int[modelBuysArrayLength];
            BuyPriceInts = new int[modelBuysArrayLength];
            BuyQuantityInts = new int[modelBuysArrayLength];
            SellListingInts = new int[modelSellsArrayLength];
            SellPriceInts = new int[modelSellsArrayLength];
            SellQuantityInts = new int[modelSellsArrayLength];
            for (int i = 0; i<modelBuysArrayLength; i++)
            {
                BuyListingsInts[i] = model.buys[i].listings;
                BuyPriceInts[i] = model.buys[i].unit_price;
                BuyQuantityInts[i] = model.buys[i].quantity;
            }
            for (int i = 0; i < modelSellsArrayLength; i++)
            {
                SellListingInts[i] = model.sells[i].listings;
                SellPriceInts[i] = model.sells[i].unit_price;
                SellQuantityInts[i] = model.sells[i].quantity;
            }
        }
    }
}