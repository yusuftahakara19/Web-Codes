using Microsoft.AspNetCore.Mvc;
using WebApplication1.Utility;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class KitapTuruController : Controller
    {
        private readonly IKitapTuruRepository kitapTuruRepository;
        
        public KitapTuruController(IKitapTuruRepository context)
        {
            kitapTuruRepository = context;
        }
        public IActionResult Index()
        {
            List<KitapTuru> objKitapTuruList = kitapTuruRepository.GetAll().ToList();
            return View(objKitapTuruList);
        }
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(KitapTuru kitapTuru)
        {
            if (ModelState.IsValid)
            {
                kitapTuruRepository.Ekle(kitapTuru);
                kitapTuruRepository.Kaydet();
                TempData["basarili"] = "Yeni Kitap Türü oluşturma başarılı";
                return RedirectToAction("Index", "KitapTuru");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Guncelle(int? id)
        {
            if(id==null || id == 0)
            {
                return NotFound();
            }
            KitapTuru? kitapTuruVt = kitapTuruRepository.Get(i=>i.Id==id); 
            if (kitapTuruVt == null) { return NotFound(); }
            return View(kitapTuruVt);
        }

        [HttpPost]
        public IActionResult Guncelle(KitapTuru kitapTuru)
        {
            if (ModelState.IsValid)
            {
                kitapTuruRepository.Guncelle(kitapTuru);
                kitapTuruRepository.Kaydet();
                TempData["basarili"] = "Kitap Türü başarıyla güncellendi";
                return RedirectToAction("Index", "KitapTuru");
            }
            else
            {
                return View();
            }

        }


        public IActionResult Sil(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            KitapTuru? kitapTuruVt = kitapTuruRepository.Get(i=>i.Id==id);
            if (kitapTuruVt == null) { return NotFound(); }
            return View(kitapTuruVt);
        }

        [HttpPost,ActionName("Sil")]
        public IActionResult SilPOST(int? id)
        {
            KitapTuru? kitapTuru = kitapTuruRepository.Get(i => i.Id == id);

            if (kitapTuru == null) { return NotFound(); }
            kitapTuruRepository.Sil(kitapTuru);
            kitapTuruRepository.Kaydet();
            TempData["basarili"] = "Kitap Türü başarıyla silindi";

            return RedirectToAction("Index", "KitapTuru");

        }
    }
}
