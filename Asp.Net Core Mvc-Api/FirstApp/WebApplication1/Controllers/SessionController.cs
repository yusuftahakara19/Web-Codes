using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            SetSession();
            ViewBag.Session = GetSession();
            return View();  
        }

        private void SetSession()
        {
            HttpContext.Session.SetString("Course", "Asp Net");
        }

        private string GetSession()
        {
            return HttpContext.Session.GetString("Course");
        }
    }
}
