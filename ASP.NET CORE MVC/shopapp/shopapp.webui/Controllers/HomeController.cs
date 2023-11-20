﻿using System;
using Microsoft.AspNetCore.Mvc;

namespace shopapp.webui.Controllers
{      
    //localhost:5000/home dediğinde bu controller'a gelirsin
    public class HomeController : Controller
    {
        // action method
        //localhost:5000/home/index dediğinde bu metoda gelmiş olursun.
        public string Index()
        {
            return "home/index";
        }

        //localhost:5000/home/about dediğinde buradasın
        public string About()
        {
            return "home/about";
        }
    }

}