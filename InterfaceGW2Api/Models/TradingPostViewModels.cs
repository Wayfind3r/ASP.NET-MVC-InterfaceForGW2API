using System.ComponentModel.DataAnnotations;

namespace InterfaceGW2Api.Models
{
    public class Buys
    {
        [Display(Name = "Quantity")]
        public int quantity { get; set; }
        [Display(Name = "Unit Price")]
        public int unit_price { get; set; }
    }

    public class Sells
    {
        [Display(Name = "Quantity")]
        public int quantity { get; set; }
        [Display(Name = "Unit Price")]
        public int unit_price { get; set; }
    }

    public class ItemPrices
    {
        public int id { get; set; }
        public bool whitelisted { get; set; }
        [Display(Name = "Buys")]
        public Buys buys { get; set; }
        [Display(Name = "Sells")]
        public Sells sells { get; set; }
    }
}