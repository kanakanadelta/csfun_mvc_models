#pragma checksum "/Users/rtongson/Documents/csharp/mvcfun/TestMvc/Views/Home/Numbers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d298a8d0f999709ee67ff119afa79cd4eadf0e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Numbers), @"mvc.1.0.view", @"/Views/Home/Numbers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Numbers.cshtml", typeof(AspNetCore.Views_Home_Numbers))]
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
#line 1 "/Users/rtongson/Documents/csharp/mvcfun/TestMvc/Views/_ViewImports.cshtml"
using TestMvc;

#line default
#line hidden
#line 2 "/Users/rtongson/Documents/csharp/mvcfun/TestMvc/Views/_ViewImports.cshtml"
using TestMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d298a8d0f999709ee67ff119afa79cd4eadf0e9", @"/Views/Home/Numbers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9eb0968f9f9382377bd971adbc94ae9b60ab674c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Numbers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/rtongson/Documents/csharp/mvcfun/TestMvc/Views/Home/Numbers.cshtml"
  
  ViewData["Title"] = "A Web page";

#line default
#line hidden
            BeginContext(41, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(56, 14, true);
            WriteLiteral("\n<div>\n  <ul>\n");
            EndContext();
#line 9 "/Users/rtongson/Documents/csharp/mvcfun/TestMvc/Views/Home/Numbers.cshtml"
     foreach(var num in Model)
    {

#line default
#line hidden
            BeginContext(107, 10, true);
            WriteLiteral("      <li>");
            EndContext();
            BeginContext(118, 3, false);
#line 11 "/Users/rtongson/Documents/csharp/mvcfun/TestMvc/Views/Home/Numbers.cshtml"
     Write(num);

#line default
#line hidden
            EndContext();
            BeginContext(121, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 12 "/Users/rtongson/Documents/csharp/mvcfun/TestMvc/Views/Home/Numbers.cshtml"
    }

#line default
#line hidden
            BeginContext(133, 14, true);
            WriteLiteral("  </ul>\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int[]> Html { get; private set; }
    }
}
#pragma warning restore 1591