using System;
using Microsoft.AspNetCore.Mvc;


    public class ProductController : Controller
    {
    public string Index()
    {
        return "product/index";
    }

    //localhost:5000/product/list dediğinde bu metoda gelmiş olursun.

    public string list()
        {
            return "product/list";
        }

        //localhost:5000/product/details dediğinde buradasın
        public string Details(int id)
        {
            return "product/details/"+id;
        }
    }
