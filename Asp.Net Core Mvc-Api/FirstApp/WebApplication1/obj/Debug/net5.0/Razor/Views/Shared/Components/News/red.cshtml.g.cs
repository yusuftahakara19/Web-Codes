#pragma checksum "C:\Users\tkyusuft\Desktop\Web-Codes\Asp.Net Core Mvc-Api\FirstApp\WebApplication1\Views\Shared\Components\News\red.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "63e20ad9901114b037d351cc2e8cc0933f8cd143a3f5f741fd72a5e1320ca17b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_News_red), @"mvc.1.0.view", @"/Views/Shared/Components/News/red.cshtml")]
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
#line 3 "C:\Users\tkyusuft\Desktop\Web-Codes\Asp.Net Core Mvc-Api\FirstApp\WebApplication1\Views\_ViewImports.cshtml"
using FirstApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tkyusuft\Desktop\Web-Codes\Asp.Net Core Mvc-Api\FirstApp\WebApplication1\Views\_ViewImports.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"63e20ad9901114b037d351cc2e8cc0933f8cd143a3f5f741fd72a5e1320ca17b", @"/Views/Shared/Components/News/red.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d998f785eee4cd173cf49cc9644ee12a0114818b2a5b66e2cef88b76e90e2e8e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_News_red : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<News>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul class=\"list-group\">\r\n");
#nullable restore
#line 4 "C:\Users\tkyusuft\Desktop\Web-Codes\Asp.Net Core Mvc-Api\FirstApp\WebApplication1\Views\Shared\Components\News\red.cshtml"
     foreach(var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item text-danger\">");
#nullable restore
#line 6 "C:\Users\tkyusuft\Desktop\Web-Codes\Asp.Net Core Mvc-Api\FirstApp\WebApplication1\Views\Shared\Components\News\red.cshtml"
                                           Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 7 "C:\Users\tkyusuft\Desktop\Web-Codes\Asp.Net Core Mvc-Api\FirstApp\WebApplication1\Views\Shared\Components\News\red.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<News>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
