#pragma checksum "/Users/tanakakizuki/Desktop/ASP.net_learn/SampleMVCApp/SampleMVCApp/Views/Hello/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5683e8907d95d50233baf8ca9e45c7aca934b0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hello_Index), @"mvc.1.0.view", @"/Views/Hello/Index.cshtml")]
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
#nullable restore
#line 1 "/Users/tanakakizuki/Desktop/ASP.net_learn/SampleMVCApp/SampleMVCApp/Views/_ViewImports.cshtml"
using SampleMVCApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/tanakakizuki/Desktop/ASP.net_learn/SampleMVCApp/SampleMVCApp/Views/_ViewImports.cshtml"
using SampleMVCApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5683e8907d95d50233baf8ca9e45c7aca934b0d", @"/Views/Hello/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc8a54a820f40bc53cb67e663039073bc3a981e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Hello_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "/Users/tanakakizuki/Desktop/ASP.net_learn/SampleMVCApp/SampleMVCApp/Views/Hello/Index.cshtml"
  
    ViewData["Title"] = "Inde/Hello";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<div class=\"text-left\">\n    <h1 class=\"display-3\">Index</h1>\n    <p class=\"h4 mb-4\">");
#nullable restore
#line 16 "/Users/tanakakizuki/Desktop/ASP.net_learn/SampleMVCApp/SampleMVCApp/Views/Hello/Index.cshtml"
                  Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <ul class=\"h5\">\n        <li>");
#nullable restore
#line 18 "/Users/tanakakizuki/Desktop/ASP.net_learn/SampleMVCApp/SampleMVCApp/Views/Hello/Index.cshtml"
       Write(ViewData["id"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        <li>");
#nullable restore
#line 19 "/Users/tanakakizuki/Desktop/ASP.net_learn/SampleMVCApp/SampleMVCApp/Views/Hello/Index.cshtml"
       Write(ViewData["name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n    </ul>\n</div>\n");
        }
        #pragma warning restore 1998
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
