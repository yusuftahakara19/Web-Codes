using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace FirstApp.Controllers
{
    public class FileController:Controller
    {
        public IActionResult List()
        {        
                DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot","files"));
                var files = directoryInfo.GetFiles();
                return View(files);  
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string fileName)
        {
            FileInfo file = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files",fileName));
            if(!file.Exists)
               file.Create();
            
            return RedirectToAction("List");
        }

        public IActionResult Remove(string fileName)
        {
            FileInfo file = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files", fileName));
            if (file.Exists)
                file.Delete();

            return RedirectToAction("List");
        }
        public IActionResult CreateWithData()
        {
            FileInfo file = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files",Guid.NewGuid().ToString()+".txt"));
            StreamWriter writer = file.CreateText();
            writer.Write("Hello!!!");
            writer.Close();
            return RedirectToAction("List");    
        }

        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Upload(IFormFile formFile)
        {
            if(formFile.ContentType == "image/png")
            {
                var ext = Path.GetExtension(formFile.FileName); 
                var pth = Directory.GetCurrentDirectory() + "/wwwroot"+ "/images/"+Guid.NewGuid()+ext;
                FileStream stream = new FileStream(pth, FileMode.Create);
                formFile.CopyTo(stream);
                TempData["message"] = "Image saved successfully";
            }
            else
            {
                TempData["message"] = "Image could not be saved";
            }
            return RedirectToAction("Upload");
        }
    }
}
