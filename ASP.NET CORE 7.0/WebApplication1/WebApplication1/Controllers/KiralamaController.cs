using Microsoft.AspNetCore.Mvc;
using WebApplication1.Utility;
using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace WebApplication1.Controllers
{
    [Authorize(Roles = UserRoles.Role_Admin)]

    public class KiralamaController : Controller
    {
        private readonly IKiralamaRepository _kiralamaRepository;
        private readonly IKitapRepository _kitapRepository;
        public readonly IWebHostEnvironment _webHostEnvironment;
        public KiralamaController(IKiralamaRepository context, IKitapRepository kitapTuruRepository, IWebHostEnvironment webHostEnvironment)
        {
            _kiralamaRepository = context;
            _kitapRepository = kitapTuruRepository;
            _webHostEnvironment = webHostEnvironment;
            
        }
      
        public IActionResult Index()
        {
            // List<Kitap> objKitapList = _kitapRepository.GetAll().ToList();
            List<Kiralama> objKiralamaList = _kiralamaRepository.GetAll(includeProps:"Kitap").ToList();
            return View(objKiralamaList);
        }

        public  IActionResult Guncelleme()
        {
            return View();
            
        }
        
        public IActionResult EkleGuncelle(int? id)
        {
            IEnumerable<SelectListItem> KitapList = _kitapRepository.GetAll()
                .Select(k => new SelectListItem
                {
                    Text = k.KitapAdi,
                    Value = k.Id.ToString()
                });
            ViewBag.KitapList = KitapList;
            if(id == null ||id == 0)
            {   // ekle
                return View();
            }
            else
            {
                //guncelleme
                Kiralama? kiralamaVt = _kiralamaRepository.Get(i => i.Id == id);
                if (kiralamaVt == null) { return NotFound(); }
                return View(kiralamaVt);
            }

        }

        [HttpPost]
        public IActionResult EkleGuncelle(Kiralama kiralama)
        {
            if (ModelState.IsValid)
            {
                if (kiralama.Id == 0)
                {
                    _kiralamaRepository.Ekle(kiralama);
                    TempData["basarili"] = "Kiralama işlemi başarılı";

                }
                else
                {
                    _kiralamaRepository.Guncelle(kiralama);
                    TempData["basarili"] = "Kiralama işlemi başarıyla guncellendi";
                }
                _kiralamaRepository.Kaydet();
                return RedirectToAction("Index", "Kiralama");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Sil(int? id)
        {
            IEnumerable<SelectListItem> KitapList = _kitapRepository.GetAll()
             .Select(k => new SelectListItem
             {
                 Text = k.KitapAdi,
                 Value = k.Id.ToString()
             });
            ViewBag.KitapList = KitapList;
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Kiralama? kiralamaVt = _kiralamaRepository.Get(i=>i.Id==id);
            if (kiralamaVt == null) { return NotFound(); }
            return View(kiralamaVt);
        }

        [HttpPost,ActionName("Sil")]
        public IActionResult SilPOST(int? id)
        {
            Kiralama? kiralama = _kiralamaRepository.Get(i => i.Id == id);

            if (kiralama == null) { return NotFound(); }
            _kiralamaRepository.Sil(kiralama);
            _kiralamaRepository.Kaydet();
            TempData["basarili"] = "Kiralama işlemi başarıyla silindi";

            return RedirectToAction("Index", "Kiralama");

        }
    }
}
