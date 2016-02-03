using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InterfaceGW2Api.Models;

namespace InterfaceGW2Api.Controllers
{
    public class QueryBagController : Controller
    {
        public ViewResult Index(QueryBag queryBag ,string returnUrl)
        {
            return View(new QueryBagIndexViewModel
            {
                QueryBag = queryBag,
                ReturnUrl = returnUrl
            });
        }
        public RedirectToRouteResult AddToQueryBag(QueryBag queryBag ,int queryId, string returnUrl)
        {
            //place GW2 Api query code here
            //Placeholder variable
            QueryResult resultToAdd = new QueryResult() {QueryId = queryId };
            queryBag.AddQueryResult(resultToAdd);
            return RedirectToAction("Index", new {returnUrl});
        }

        public RedirectToRouteResult RemoveFromQueryBag(QueryBag queryBag ,int queryId, string returnUrl)
        {
            queryBag.RemoveQueryResult(queryId);
            return RedirectToAction("Index", new {returnUrl});
        }

        public PartialViewResult Summary(QueryBag queryBag)
        {
            return PartialView(queryBag);
        }
    }
}