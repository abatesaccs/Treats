#pragma checksum "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a66e56e2e62f472c59fb2dfa9307225ab8fcf91f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flavors_Index), @"mvc.1.0.view", @"/Views/Flavors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Flavors/Index.cshtml", typeof(AspNetCore.Views_Flavors_Index))]
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
#line 1 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/_ViewImports.cshtml"
using SweetTreat;

#line default
#line hidden
#line 5 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Index.cshtml"
using SweetTreat.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a66e56e2e62f472c59fb2dfa9307225ab8fcf91f", @"/Views/Flavors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88e1ead03f012a1eb5d72bd185f022caa1eed39d", @"/Views/_ViewImports.cshtml")]
    public class Views_Flavors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SweetTreat.Models.Flavor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(100, 17, true);
            WriteLiteral("\n<h1>Flavors for ");
            EndContext();
            BeginContext(118, 18, false);
#line 8 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Index.cshtml"
           Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(136, 7, true);
            WriteLiteral("</h1>\n\n");
            EndContext();
#line 10 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Index.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(163, 7, true);
            WriteLiteral("  <ul>\n");
            EndContext();
#line 13 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Index.cshtml"
     foreach (Flavor flavor in Model)
    {

#line default
#line hidden
            BeginContext(214, 10, true);
            WriteLiteral("      <li>");
            EndContext();
            BeginContext(225, 80, false);
#line 15 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Index.cshtml"
     Write(Html.ActionLink($"{flavor.FlavorName}", "Details", new { id = flavor.FlavorId }));

#line default
#line hidden
            EndContext();
            BeginContext(305, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 16 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(317, 8, true);
            WriteLiteral("  </ul>\n");
            EndContext();
#line 18 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Index.cshtml"
} 
else
{

#line default
#line hidden
            BeginContext(335, 43, true);
            WriteLiteral("  <h3>No Flavors have been added yet!</h3>\n");
            EndContext();
#line 22 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Index.cshtml"
}

#line default
#line hidden
            BeginContext(380, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(385, 43, false);
#line 24 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Index.cshtml"
Write(Html.ActionLink("Add new Flavor", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(428, 9, true);
            WriteLiteral("</p>\n\n<p>");
            EndContext();
            BeginContext(438, 40, false);
#line 26 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(478, 5, true);
            WriteLiteral("</p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SweetTreat.Models.Flavor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
