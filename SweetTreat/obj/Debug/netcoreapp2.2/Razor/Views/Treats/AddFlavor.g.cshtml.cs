#pragma checksum "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Treats/AddFlavor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9fcc5ba1b304616326e4430c75a9fe7245121c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Treats_AddFlavor), @"mvc.1.0.view", @"/Views/Treats/AddFlavor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Treats/AddFlavor.cshtml", typeof(AspNetCore.Views_Treats_AddFlavor))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9fcc5ba1b304616326e4430c75a9fe7245121c9", @"/Views/Treats/AddFlavor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88e1ead03f012a1eb5d72bd185f022caa1eed39d", @"/Views/_ViewImports.cshtml")]
    public class Views_Treats_AddFlavor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SweetTreat.Models.Treat>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Treats/AddFlavor.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(59, 34, true);
            WriteLiteral("\n<h4>Add a Flavor for this Treat: ");
            EndContext();
            BeginContext(94, 15, false);
#line 7 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Treats/AddFlavor.cshtml"
                            Write(Model.TreatName);

#line default
#line hidden
            EndContext();
            BeginContext(109, 7, true);
            WriteLiteral("</h4>\n\n");
            EndContext();
#line 9 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Treats/AddFlavor.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(149, 38, false);
#line 11 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Treats/AddFlavor.cshtml"
Write(Html.HiddenFor(model => model.TreatId));

#line default
#line hidden
            EndContext();
            BeginContext(194, 27, false);
#line 13 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Treats/AddFlavor.cshtml"
Write(Html.Label("Select Flavor"));

#line default
#line hidden
            EndContext();
            BeginContext(227, 29, false);
#line 14 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Treats/AddFlavor.cshtml"
Write(Html.DropDownList("FlavorId"));

#line default
#line hidden
            EndContext();
            BeginContext(258, 41, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\n");
            EndContext();
#line 17 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Treats/AddFlavor.cshtml"
}

#line default
#line hidden
            BeginContext(301, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(306, 40, false);
#line 19 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Treats/AddFlavor.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(346, 4, true);
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
