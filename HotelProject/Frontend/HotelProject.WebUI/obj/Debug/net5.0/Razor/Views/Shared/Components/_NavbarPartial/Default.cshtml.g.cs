#pragma checksum "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_NavbarPartial\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e26d20bfa06d4249bd11ae0a03494563e5657033a1620b116c80337957b0d914"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__NavbarPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_NavbarPartial/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Staff;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Testimonial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.ServiceDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.RegisterDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.LoginDto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e26d20bfa06d4249bd11ae0a03494563e5657033a1620b116c80337957b0d914", @"/Views/Shared/Components/_NavbarPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a7102038f32e0fe5b0575b3f98ae3690fc4ab86fd532487d43cd94643d14be49", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__NavbarPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-fluid bg-dark px-0"">
    <div class=""row gx-0"">
        <div class=""col-lg-3 bg-dark d-none d-lg-block"">
            <a href=""index.html"" class=""navbar-brand w-100 h-100 m-0 p-0 d-flex align-items-center justify-content-center"">
                <h1 class=""m-0 text-primary text-uppercase"">Hotelier</h1>
            </a>
        </div>
        <div class=""col-lg-9"">
            <div class=""row gx-0 bg-white d-none d-lg-flex"">
                <div class=""col-lg-7 px-5 text-start"">
                    <div class=""h-100 d-inline-flex align-items-center py-2 me-4"">
                        <i class=""fa fa-envelope text-primary me-2""></i>
                        <p class=""mb-0"">info@example.com</p>
                    </div>
                    <div class=""h-100 d-inline-flex align-items-center py-2"">
                        <i class=""fa fa-phone-alt text-primary me-2""></i>
                        <p class=""mb-0"">+012 345 6789</p>
                    </div>
                </div");
            WriteLiteral(">\r\n                <div class=\"col-lg-5 px-5 text-end\">\r\n                    <div class=\"d-inline-flex align-items-center py-2\">\r\n                        <a class=\"me-3\"");
            BeginWriteAttribute("href", " href=\"", 1193, "\"", 1200, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-facebook-f\"></i></a>\r\n                        <a class=\"me-3\"");
            BeginWriteAttribute("href", " href=\"", 1280, "\"", 1287, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-twitter\"></i></a>\r\n                        <a class=\"me-3\"");
            BeginWriteAttribute("href", " href=\"", 1364, "\"", 1371, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-linkedin-in\"></i></a>\r\n                        <a class=\"me-3\"");
            BeginWriteAttribute("href", " href=\"", 1452, "\"", 1459, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-instagram\"></i></a>\r\n                        <a");
            BeginWriteAttribute("class", " class=\"", 1525, "\"", 1533, 0);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1534, "\"", 1541, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fab fa-youtube""></i></a>
                    </div>
                </div>
            </div>
            <nav class=""navbar navbar-expand-lg bg-dark navbar-dark p-3 p-lg-0"">
                <a href=""index.html"" class=""navbar-brand d-block d-lg-none"">
                    <h1 class=""m-0 text-primary text-uppercase"">Hotelier</h1>
                </a>
                <button type=""button"" class=""navbar-toggler"" data-bs-toggle=""collapse"" data-bs-target=""#navbarCollapse"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""collapse navbar-collapse justify-content-between"" id=""navbarCollapse"">
                    <div class=""navbar-nav mr-auto py-0"">
                        <a href=""index.html"" class=""nav-item nav-link active"">Home</a>
                        <a href=""about.html"" class=""nav-item nav-link"">About</a>
                        <a href=""service.html"" class=""nav-item nav-link"">Services</a>
                        <a");
            WriteLiteral(@" href=""room.html"" class=""nav-item nav-link"">Rooms</a>
                        <div class=""nav-item dropdown"">
                            <a href=""#"" class=""nav-link dropdown-toggle"" data-bs-toggle=""dropdown"">Pages</a>
                            <div class=""dropdown-menu rounded-0 m-0"">
                                <a href=""booking.html"" class=""dropdown-item"">Booking</a>
                                <a href=""team.html"" class=""dropdown-item"">Our Team</a>
                                <a href=""testimonial.html"" class=""dropdown-item"">Testimonial</a>
                            </div>
                        </div>
                        <a href=""contact.html"" class=""nav-item nav-link"">Contact</a>
                    </div>
                    <a href=""https://htmlcodex.com/hotel-html-template-pro"" class=""btn btn-primary rounded-0 py-4 px-md-5 d-none d-lg-block"">Premium Version<i class=""fa fa-arrow-right ms-3""></i></a>
                </div>
            </nav>
        </div>
    </div>
<");
            WriteLiteral("/div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
