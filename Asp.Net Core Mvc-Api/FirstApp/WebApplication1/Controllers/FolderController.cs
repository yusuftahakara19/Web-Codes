using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace FirstApp.Controllers
{
    public class FolderController : Controller
    {
        public IActionResult List()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(),"wwwroot"));
            var folders  = directoryInfo.GetDirectories();
            return View(folders);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string folderName)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(),"wwwroot",folderName));
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
            return RedirectToAction("List");
        }
    }
}
