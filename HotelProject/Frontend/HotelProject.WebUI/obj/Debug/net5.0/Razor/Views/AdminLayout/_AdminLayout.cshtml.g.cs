#pragma checksum "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2e00c277fb75ed18e0097d5736b06287c146c7a3c52848ee5e724bc3da9815f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminLayout__AdminLayout), @"mvc.1.0.view", @"/Views/AdminLayout/_AdminLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2e00c277fb75ed18e0097d5736b06287c146c7a3c52848ee5e724bc3da9815f7", @"/Views/AdminLayout/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e8c7af95b4dbc6738197064faaa67d836dc4e27df025ad2593fb8d1dba49b32f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminLayout__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
#nullable restore
#line 8 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml"
Write(await Html.PartialAsync("/Views/AdminLayout/HeadPartial.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e00c277fb75ed18e0097d5736b06287c146c7a3c52848ee5e724bc3da9815f74691", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 13 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml"
Write(await Html.PartialAsync("/Views/AdminLayout/PreloaderPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <div id=\"main-wrapper\">\r\n\r\n        ");
#nullable restore
#line 17 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml"
   Write(await Html.PartialAsync("/Views/AdminLayout/NavheaderPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 19 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml"
   Write(await Html.PartialAsync("/Views/AdminLayout/HeaderPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 21 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml"
   Write(await Html.PartialAsync("/Views/AdminLayout/SidebarPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

        <div class=""content-body"">
            <!-- row -->

            <div class=""container-fluid"">
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""card"">
                            <div class=""card-body"">
                                ");
#nullable restore
#line 31 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml"
                           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                <br/>
                            
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- #/ container -->
        </div>


        ");
#nullable restore
#line 43 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml"
   Write(await Html.PartialAsync("/Views/AdminLayout/FooterPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    </div>\r\n    ");
#nullable restore
#line 46 "C:\Users\tkyusuft\Desktop\Web-Codes\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml"
Write(await Html.PartialAsync("/Views/AdminLayout/ScriptPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
