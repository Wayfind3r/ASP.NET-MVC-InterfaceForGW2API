using System;
using System.Collections.Generic;
using System.Web.Mvc;
using InterfaceGW2Api.Models;
using InterfaceGW2Api.Services;
using PagedList;

namespace InterfaceGW2Api.Controllers
{
    public class SearchController : Controller
    {
        private readonly ItemServices itemServices;

        public SearchController()
        {
            itemServices = new ItemServices();
        }

        // GET: Search
        public ActionResult Items(int page = 1, int pageSize = 200, string searchString = null)
        {
            var list = new List<SimpleItemViewModel>();
            if (String.IsNullOrEmpty(searchString))
            {
                list = itemServices.GetItemViewModels();
            }
            else
            {
                list = itemServices.GetItemViewModels(searchString);
            }
            var model = new PagedList<SimpleItemViewModel>(list, page, pageSize);
            return View(model);
        }
    }
}