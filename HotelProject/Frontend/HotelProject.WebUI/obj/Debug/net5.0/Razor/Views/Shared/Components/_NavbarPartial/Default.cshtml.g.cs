#pragma checksum "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_NavbarPartial\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f749710b36b88cf997141079ea0ef65d59245771bd41058d2dcb106b05e1aeb0"
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
#nullable restore
#line 8 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.AboutDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.RoomDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.TestimonialDto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f749710b36b88cf997141079ea0ef65d59245771bd41058d2dcb106b05e1aeb0", @"/Views/Shared/Components/_NavbarPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"bd0673712834ce0583c86e7c1ac8e12f94024bccc3a55093604e50336383f18d", @"/Views/_ViewImports.cshtml")]
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
            <a href=""/Default/Index"" class=""navbar-brand w-100 h-100 m-0 p-0 d-flex align-items-center justify-content-center"">
                <h1 class=""m-0 text-primary text-uppercase"">YTK HOTEL</h1>
            </a>
        </div>
        <div class=""col-lg-9"">
            <div class=""row gx-0 bg-white d-none d-lg-flex"">
                <div class=""col-lg-7 px-5 text-start"">
                    <div class=""h-100 d-inline-flex align-items-center py-2 me-4"">
                        <i class=""fa fa-envelope text-primary me-2""></i>
                        <p class=""mb-0"">info@ytkhotel.com</p>
                    </div>
                    <div class=""h-100 d-inline-flex align-items-center py-2"">
                        <i class=""fa fa-phone-alt text-primary me-2""></i>
                        <p class=""mb-0"">+90 555 555 5555</p>
                    </div>
            ");
            WriteLiteral("    </div>\r\n                <div class=\"col-lg-5 px-5 text-end\">\r\n                    <div class=\"d-inline-flex align-items-center py-2\">\r\n                        <a class=\"me-3\"");
            BeginWriteAttribute("href", " href=\"", 1202, "\"", 1209, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-facebook-f\"></i></a>\r\n                        <a class=\"me-3\"");
            BeginWriteAttribute("href", " href=\"", 1289, "\"", 1296, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-twitter\"></i></a>\r\n                        <a class=\"me-3\"");
            BeginWriteAttribute("href", " href=\"", 1373, "\"", 1380, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-linkedin-in\"></i></a>\r\n                        <a class=\"me-3\"");
            BeginWriteAttribute("href", " href=\"", 1461, "\"", 1468, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-instagram\"></i></a>\r\n                        <a");
            BeginWriteAttribute("class", " class=\"", 1534, "\"", 1542, 0);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1543, "\"", 1550, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fab fa-youtube""></i></a>
                    </div>
                </div>
            </div>
            <nav class=""navbar navbar-expand-lg bg-dark navbar-dark p-3 p-lg-0"">
                <a href=""index.html"" class=""navbar-brand d-block d-lg-none"">
                    <h1 class=""m-0 text-primary text-uppercase"">YTK HOTEL</h1>
                </a>
                <button type=""button"" class=""navbar-toggler"" data-bs-toggle=""collapse"" data-bs-target=""#navbarCollapse"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""collapse navbar-collapse justify-content-between"" id=""navbarCollapse"">
                    <div class=""navbar-nav mr-auto py-0"">
                        <a href=""/Default/Index"" class=""nav-item nav-link active"">Home</a>
                        <a href=""about.html"" class=""nav-item nav-link"">About</a>
                        <a href=""service.html"" class=""nav-item nav-link"">Services</a>
                     ");
            WriteLiteral(@"   <a href=""room.html"" class=""nav-item nav-link"">Rooms</a>
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
    </di");
            WriteLiteral("v>\r\n</div>");
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
