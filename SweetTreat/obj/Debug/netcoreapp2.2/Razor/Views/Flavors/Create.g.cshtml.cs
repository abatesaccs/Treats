#pragma checksum "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "099e27aab4b644c2542be4a683cfd080145c4b37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flavors_Create), @"mvc.1.0.view", @"/Views/Flavors/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Flavors/Create.cshtml", typeof(AspNetCore.Views_Flavors_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"099e27aab4b644c2542be4a683cfd080145c4b37", @"/Views/Flavors/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88e1ead03f012a1eb5d72bd185f022caa1eed39d", @"/Views/_ViewImports.cshtml")]
    public class Views_Flavors_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SweetTreat.Models.Flavor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(60, 27, true);
            WriteLiteral("\n<h4>Add a new Flavor</h4>\n");
            EndContext();
#line 8 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(120, 40, false);
#line 10 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Create.cshtml"
Write(Html.LabelFor(model => model.FlavorName));

#line default
#line hidden
            EndContext();
            BeginContext(166, 42, false);
#line 11 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Create.cshtml"
Write(Html.TextBoxFor(model => model.FlavorName));

#line default
#line hidden
            EndContext();
            BeginContext(219, 26, false);
#line 13 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Create.cshtml"
Write(Html.Label("Select Treat"));

#line default
#line hidden
            EndContext();
            BeginContext(251, 28, false);
#line 14 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Create.cshtml"
Write(Html.DropDownList("TreatId"));

#line default
#line hidden
            EndContext();
            BeginContext(281, 74, true);
            WriteLiteral("    <input type=\"submit\" value=\"Add new Flavor\" class=\"btn btn-default\"/>\n");
            EndContext();
#line 17 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Create.cshtml"
}

#line default
#line hidden
            BeginContext(357, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(361, 44, false);
#line 18 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Create.cshtml"
Write(Html.ActionLink("Show all Flavors", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(405, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SweetTreat.Models.Flavor> Html { get; private set; }
    }
}
#pragma warning restore 1591