#pragma checksum "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_TestimonialPartial\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "85b62eee5f406d461f109dfbbdcbf29087ee268dfb46a9736a174ce599279ec4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__TestimonialPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_TestimonialPartial/Default.cshtml")]
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
#nullable restore
#line 11 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.StaffDto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"85b62eee5f406d461f109dfbbdcbf29087ee268dfb46a9736a174ce599279ec4", @"/Views/Shared/Components/_TestimonialPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6f6a46813cd370a88b87deecca5e2bc8f805b3fd6c6afaf28447d8a47ad12e66", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__TestimonialPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ResultTestimonialDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container-xxl testimonial my-5 py-5 bg-dark wow zoomIn\" data-wow-delay=\"0.1s\">\r\n    <div class=\"container\">\r\n        <div class=\"owl-carousel testimonial-carousel py-5\">\r\n");
#nullable restore
#line 6 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_TestimonialPartial\Default.cshtml"
             foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"testimonial-item position-relative bg-white rounded overflow-hidden\">\r\n                    <p>");
#nullable restore
#line 9 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_TestimonialPartial\Default.cshtml"
                  Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <div class=\"d-flex align-items-center\">\r\n                        <img class=\"img-fluid flex-shrink-0 rounded\"");
            BeginWriteAttribute("src", " src=\"", 550, "\"", 567, 1);
#nullable restore
#line 11 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_TestimonialPartial\Default.cshtml"
WriteAttributeValue("", 556, item.Image, 556, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 45px; height: 45px;\">\r\n                        <div class=\"ps-3\">\r\n                            <h6 class=\"fw-bold mb-1\">");
#nullable restore
#line 13 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_TestimonialPartial\Default.cshtml"
                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <small>");
#nullable restore
#line 14 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_TestimonialPartial\Default.cshtml"
                              Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        </div>\r\n                    </div>\r\n                    <i class=\"fa fa-quote-right fa-3x text-primary position-absolute end-0 bottom-0 me-4 mb-n1\"></i>\r\n                </div>\r\n");
#nullable restore
#line 19 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_TestimonialPartial\Default.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ResultTestimonialDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
