using System;
using Microsoft.AspNetCore.Mvc;


public class ProductController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    //localhost:5000/product/list dediğinde bu metoda gelmiş olursun.

    public IActionResult list()
    {
        return View();
    }

    //localhost:5000/product/details dediğinde buradasın
    public IActionResult Details(int id)
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View("MyView");
    }


}
