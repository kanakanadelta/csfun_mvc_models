#pragma checksum "/Users/rtongson/Documents/csharp/mvcfun/TestMvc/Views/Home/UserView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08942ae2027c989646aa7bd840a0e513817ab0a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserView), @"mvc.1.0.view", @"/Views/Home/UserView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/UserView.cshtml", typeof(AspNetCore.Views_Home_UserView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08942ae2027c989646aa7bd840a0e513817ab0a5", @"/Views/Home/UserView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9eb0968f9f9382377bd971adbc94ae9b60ab674c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/rtongson/Documents/csharp/mvcfun/TestMvc/Views/Home/UserView.cshtml"
  
  ViewData["Title"] = "A Web page";

#line default
#line hidden
            BeginContext(41, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(55, 40, true);
            WriteLiteral("\n<div>\n  <h3>Here is a User!</h3>\n  <h1>");
            EndContext();
            BeginContext(96, 15, false);
#line 9 "/Users/rtongson/Documents/csharp/mvcfun/TestMvc/Views/Home/UserView.cshtml"
 Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(111, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(113, 14, false);
#line 9 "/Users/rtongson/Documents/csharp/mvcfun/TestMvc/Views/Home/UserView.cshtml"
                  Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(127, 12, true);
            WriteLiteral("</h1>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
