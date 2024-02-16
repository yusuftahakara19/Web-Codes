using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.ViewComponents
{
    public class News : ViewComponent
    {
        public IViewComponentResult Invoke(string color="default")
        {
            var list = NewsContext.List;
            if(color== "default")
            {
                return View(list);
            }
            else if(color=="red"){
                return View("red",list); // viewName and list
            }
            else
            {
                return View("blue", list);
            }
        }
    }
}
