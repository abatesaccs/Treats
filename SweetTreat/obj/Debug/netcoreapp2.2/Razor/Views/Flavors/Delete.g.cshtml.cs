#pragma checksum "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cdc1e101cf302ac36b3451f61ed578b42ad33fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flavors_Delete), @"mvc.1.0.view", @"/Views/Flavors/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Flavors/Delete.cshtml", typeof(AspNetCore.Views_Flavors_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cdc1e101cf302ac36b3451f61ed578b42ad33fd", @"/Views/Flavors/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88e1ead03f012a1eb5d72bd185f022caa1eed39d", @"/Views/_ViewImports.cshtml")]
    public class Views_Flavors_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SweetTreat.Models.Flavor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(60, 49, true);
            WriteLiteral("\n<h2>Are you sure you want to delete this?</h2>\n\n");
            EndContext();
            BeginContext(110, 46, false);
#line 9 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.FlavorName));

#line default
#line hidden
            EndContext();
            BeginContext(156, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(159, 42, false);
#line 9 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Delete.cshtml"
                                            Write(Html.DisplayFor(model => model.FlavorName));

#line default
#line hidden
            EndContext();
            BeginContext(201, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 10 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(230, 43, true);
            WriteLiteral("    <input type=\"submit\" value=\"Delete\" />\n");
            EndContext();
#line 13 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Delete.cshtml"
}

#line default
#line hidden
            BeginContext(276, 40, false);
#line 14 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Flavors/Delete.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
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
