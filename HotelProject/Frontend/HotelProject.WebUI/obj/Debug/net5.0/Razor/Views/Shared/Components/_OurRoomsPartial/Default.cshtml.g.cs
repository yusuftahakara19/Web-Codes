#pragma checksum "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "42464afd6637999c042b6940ed34ed8796f2fcd70874e8f99047e1460d72dd0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__OurRoomsPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_OurRoomsPartial/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"42464afd6637999c042b6940ed34ed8796f2fcd70874e8f99047e1460d72dd0d", @"/Views/Shared/Components/_OurRoomsPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6f6a46813cd370a88b87deecca5e2bc8f805b3fd6c6afaf28447d8a47ad12e66", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__OurRoomsPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ResultRoomDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container-xxl py-5"">
    <div class=""container"">
        <div class=""text-center wow fadeInUp"" data-wow-delay=""0.1s"">
            <h6 class=""section-title text-center text-primary text-uppercase"">Our Rooms</h6>
            <h1 class=""mb-5"">Explore Our <span class=""text-primary text-uppercase"">Rooms</span></h1>
        </div>
        <div class=""row g-4"">
");
#nullable restore
#line 10 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
             foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-4 col-md-6 wow fadeInUp"" data-wow-delay=""0.1s"">
                    <div class=""room-item shadow rounded overflow-hidden"">
                        <div class=""position-relative"">
                            <img class=""img-fluid""");
            BeginWriteAttribute("src", " src=\"", 729, "\"", 755, 1);
#nullable restore
#line 15 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
WriteAttributeValue("", 735, item.RoomCoverImage, 735, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 756, "\"", 762, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <small class=\"position-absolute start-0 top-100 translate-middle-y bg-primary text-white rounded py-1 px-3 ms-4\">$");
#nullable restore
#line 16 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
                                                                                                                                         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("/Night</small>\r\n                        </div>\r\n                        <div class=\"p-4 mt-2\">\r\n                            <div class=\"d-flex justify-content-between mb-3\">\r\n                                <h5 class=\"mb-0\">");
#nullable restore
#line 20 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
                                            Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                <div class=""ps-2"">
                                    <small class=""fa fa-star text-primary""></small>
                                    <small class=""fa fa-star text-primary""></small>
                                    <small class=""fa fa-star text-primary""></small>
                                    <small class=""fa fa-star text-primary""></small>
                                    <small class=""fa fa-star text-primary""></small>
                                </div>
                            </div>
                            <div class=""d-flex mb-3"">
                                <small class=""border-end me-3 pe-3""><i class=""fa fa-bed text-primary me-2""></i>");
#nullable restore
#line 30 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
                                                                                                          Write(item.BedCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Bed</small>\r\n                                <small class=\"border-end me-3 pe-3\"><i class=\"fa fa-bath text-primary me-2\"></i>");
#nullable restore
#line 31 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
                                                                                                           Write(item.BathCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Bath</small>\r\n                                <small><i class=\"fa fa-wifi text-primary me-2\"></i>");
#nullable restore
#line 32 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
                                                                               Write(item.Wifi == "Yes" ? "Wifi" : "No Wifi");

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                            </div>\r\n                            <p class=\"text-body mb-3\">");
#nullable restore
#line 34 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
                                                 Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <div class=\"d-flex justify-content-between\">\r\n                                <a class=\"btn btn-sm btn-primary rounded py-2 px-4\"");
            BeginWriteAttribute("href", " href=\"", 2455, "\"", 2462, 0);
            EndWriteAttribute();
            WriteLiteral(">View Detail</a>\r\n                                <a class=\"btn btn-sm btn-dark rounded py-2 px-4\"");
            BeginWriteAttribute("href", " href=\"", 2561, "\"", 2568, 0);
            EndWriteAttribute();
            WriteLiteral(">Book Now</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 42 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ResultRoomDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
