#pragma checksum "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Treats/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bba528e0fba70a37585d8263280c18afcfb7cce7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Treats_Edit), @"mvc.1.0.view", @"/Views/Treats/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Treats/Edit.cshtml", typeof(AspNetCore.Views_Treats_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bba528e0fba70a37585d8263280c18afcfb7cce7", @"/Views/Treats/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88e1ead03f012a1eb5d72bd185f022caa1eed39d", @"/Views/_ViewImports.cshtml")]
    public class Views_Treats_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SweetTreat.Models.Treat>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Treats/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(59, 37, true);
            WriteLiteral("\n<h2>Edit</h2>\n\n<h4>Edit this Treat: ");
            EndContext();
            BeginContext(97, 41, false);
#line 9 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Treats/Edit.cshtml"
                Write(Html.DisplayFor(model => model.TreatName));

#line default
#line hidden
            EndContext();
            BeginContext(138, 7, true);
            WriteLiteral("</h4>\n\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Treats/Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(178, 38, false);
#line 13 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Treats/Edit.cshtml"
Write(Html.HiddenFor(model => model.TreatId));

#line default
#line hidden
            EndContext();
            BeginContext(223, 39, false);
#line 15 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Treats/Edit.cshtml"
Write(Html.LabelFor(model => model.TreatName));

#line default
#line hidden
            EndContext();
            BeginContext(268, 40, false);
#line 16 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Treats/Edit.cshtml"
Write(Html.EditorFor(model => model.TreatName));

#line default
#line hidden
            EndContext();
            BeginContext(310, 41, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\n");
            EndContext();
#line 19 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Treats/Edit.cshtml"
}

#line default
#line hidden
            BeginContext(353, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(357, 46, false);
#line 20 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Treats/Edit.cshtml"
Write(Html.ActionLink("Back to categories", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(403, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SweetTreat.Models.Treat> Html { get; private set; }
    }
}
#pragma warning restore 1591