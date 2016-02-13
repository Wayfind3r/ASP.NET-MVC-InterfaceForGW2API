using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Protocols;
using InterfaceGW2Api.Models;
using InterfaceGW2Api.Services;

namespace InterfaceGW2Api.Controllers
{
    public class ItemController : Controller
    {
        private readonly ItemServices itemServices;
        public ItemController()
        {
            itemServices = new ItemServices();
        }
        // GET: Item
        [HttpGet]
        public ActionResult SingleItem(int itemId)
        {
            var model = itemServices.GetCompleteItemViewModel(itemId);
            switch (model.type)
            {
                case "Armor":
                    return RedirectToAction("ArmorView", new { armorId = itemId });
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult SingleItemListings(int itemId)
        {
            var model = new ListingChartViewModel(itemServices.GetItemListingsViewModel(itemId));
            return View(model);
        }
        [HttpGet]
        public ActionResult ArmorView(int armorId)
        {
            var model = itemServices.GetCompleteItemViewModel(armorId);
            model.ItemPrices = itemServices.GetItemPrices(armorId);
            return View(model);
        }
    }
}