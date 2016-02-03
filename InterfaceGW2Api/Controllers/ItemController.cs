using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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

        public ActionResult ArmorView(int armorId)
        {
            var model = itemServices.GetCompleteItemViewModel(armorId);
            model.ItemPrices = itemServices.GetItemPrices(armorId);
            return View(model);
        }
    }
}