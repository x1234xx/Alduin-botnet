#pragma checksum "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e482d0297653e34d38e23ce418b3bb9dd5e1660a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_List_List), @"mvc.1.0.view", @"/Views/List/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/List/List.cshtml", typeof(AspNetCore.Views_List_List))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\_ViewImports.cshtml"
using Alduin.Web;

#line default
#line hidden
#line 2 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\_ViewImports.cshtml"
using Alduin.Web.Models;

#line default
#line hidden
#line 4 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e482d0297653e34d38e23ce418b3bb9dd5e1660a", @"/Views/List/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df02d679023bc56e9cc697f1d66d605b9a4371f2", @"/Views/_ViewImports.cshtml")]
    public class Views_List_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(42, 178, true);
            WriteLiteral("<div class=\"container d-flex justify-content-center\">\r\n    <div class=\"list-board\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12 text-center\">\r\n                <h1>");
            EndContext();
            BeginContext(221, 17, false);
#line 9 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\List.cshtml"
               Write(Localizer["List"]);

#line default
#line hidden
            EndContext();
            BeginContext(238, 404, true);
            WriteLiteral(@"</h1>
            </div>
        </div>
        <!--List start-->
        <!--List Head start-->
        <!--List Head end-->
        <div class=""row text-center w-100 bg-danger"">
            <div class=""col-1"">Id</div>
            <div class=""col-3"">Domain</div>
            <div class=""col-2"">Online</div>
            <div class=""col-2"">Last seen</div>
        </div>
    </div>
</div>

");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591