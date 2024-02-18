using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;

namespace FirstApp.Filters
{
    public class ValidFirstName : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var dictionary = context.ActionArguments.FirstOrDefault(I => I.Key == "customer");
            var customer = dictionary.Value as Customer;
            if (customer.firstName == "admin")
            {
                context.Result = new RedirectResult("/Home/Index");
            }
        }
    }
}
