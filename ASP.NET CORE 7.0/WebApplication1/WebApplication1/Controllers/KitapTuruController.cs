using Microsoft.AspNetCore.Mvc;
using WebApplication1.Utility;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class KitapTuruController : Controller
    {
        private readonly UygulamaDbContext _uygulamaDbContext;
        
        public KitapTuruController(UygulamaDbContext context)
        {
            _uygulamaDbContext = context;
        }
        public IActionResult Index()
        {
            List<KitapTuru> objKitapTuruList = _uygulamaDbContext.KitapTurleri.ToList();
            return View(objKitapTuruList);
        }
    }
}
