using System.Web.Mvc;
using InterfaceGW2Api.Models;

namespace InterfaceGW2Api.Infrastructure.Binders
{
    public class QueryBagModelBinder : IModelBinder
    {
        private const string sessionKey = "QueryBag";

        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            //Get the Query Bag from the Session
            QueryBag queryBag = null;
            if (controllerContext.HttpContext.Session != null)
            {
                queryBag = (QueryBag) controllerContext.HttpContext.Session[sessionKey];
            }
            //Create the Query Bag if there wasn't one in the session data
            if (queryBag == null)
            {
                queryBag = new QueryBag();
                if (controllerContext.HttpContext.Session != null)
                {
                    controllerContext.HttpContext.Session[sessionKey] = queryBag;
                }
            }
            //return the Query Bag
            return queryBag;
        }
    }
}