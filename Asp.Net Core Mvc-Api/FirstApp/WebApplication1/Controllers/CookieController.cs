using Microsoft.AspNetCore.Mvc;
using System;

namespace FirstApp.Controllers
{
    public class CookieController : Controller
    {
        public IActionResult Index()
        {
            SetCookie();
            ViewBag.Cookie = GetCookie();
            return View();
        }

        private void SetCookie()
        {
            HttpContext.Response.Cookies.Append("Course", "ASP Net Core",
                new Microsoft.AspNetCore.Http.CookieOptions
                {
                    Expires = DateTime.Now.AddDays(10),
                    HttpOnly = true,
                    SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict
                });
        }

        private string GetCookie()
        {
            string cookieValue = string.Empty;
            HttpContext.Request.Cookies.TryGetValue("Course", out cookieValue);
            return cookieValue;
        }
    }
}
