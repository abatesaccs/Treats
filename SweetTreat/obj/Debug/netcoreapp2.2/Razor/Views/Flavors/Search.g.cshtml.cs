#pragma checksum "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05404656aac818aed9d80bfe07f3f856d00b84f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flavors_Search), @"mvc.1.0.view", @"/Views/Flavors/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Flavors/Search.cshtml", typeof(AspNetCore.Views_Flavors_Search))]
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
#line 2 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/_ViewImports.cshtml"
using SweetTreat.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05404656aac818aed9d80bfe07f3f856d00b84f3", @"/Views/Flavors/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88e1ead03f012a1eb5d72bd185f022caa1eed39d", @"/Views/_ViewImports.cshtml")]
    public class Views_Flavors_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SweetTreat.Models.Flavor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Search.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(60, 30, true);
            WriteLiteral("\n<h4>Search for a Flavor</h4>\n");
            EndContext();
#line 8 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Search.cshtml"
 using (Html.BeginForm("SearchDetails"))
{
    

#line default
#line hidden
            BeginContext(138, 40, false);
#line 10 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Search.cshtml"
Write(Html.LabelFor(model => model.FlavorName));

#line default
#line hidden
            EndContext();
            BeginContext(184, 42, false);
#line 11 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Search.cshtml"
Write(Html.TextBoxFor(model => model.FlavorName));

#line default
#line hidden
            EndContext();
            BeginContext(232, 50, true);
            WriteLiteral("    <input type=\"submit\" value=\"SearchDetails\" />\n");
            EndContext();
#line 14 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Search.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SweetTreat.Models.Flavor> Html { get; private set; }
    }
}
#pragma warning restore 1591
