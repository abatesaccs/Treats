#pragma checksum "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Account/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1eba9a1f86b1560f9eed99c56c7cd0b55deb9dcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Index.cshtml", typeof(AspNetCore.Views_Account_Index))]
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
#line 5 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Account/Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1eba9a1f86b1560f9eed99c56c7cd0b55deb9dcf", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88e1ead03f012a1eb5d72bd185f022caa1eed39d", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Account/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(58, 46, true);
            WriteLiteral("\n<h2>Authentication with Identity</h2>\n<hr />\n");
            EndContext();
#line 9 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Account/Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(142, 13, true);
            WriteLiteral("    <p>Hello ");
            EndContext();
            BeginContext(156, 18, false);
#line 11 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Account/Index.cshtml"
        Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(174, 6, true);
            WriteLiteral("!</p>\n");
            EndContext();
#line 12 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Account/Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(189, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(197, 39, false);
#line 15 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Account/Index.cshtml"
  Write(Html.ActionLink("Register", "Register"));

#line default
#line hidden
            EndContext();
            BeginContext(236, 12, true);
            WriteLiteral("</p>\n    <p>");
            EndContext();
            BeginContext(249, 34, false);
#line 16 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Account/Index.cshtml"
  Write(Html.ActionLink("Log in", "Login"));

#line default
#line hidden
            EndContext();
            BeginContext(283, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 17 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Account/Index.cshtml"
}

#line default
#line hidden
#line 18 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Account/Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(328, 13, true);
            WriteLiteral("    <p>Hello ");
            EndContext();
            BeginContext(342, 18, false);
#line 20 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Account/Index.cshtml"
        Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(360, 6, true);
            WriteLiteral("!</p>\n");
            EndContext();
#line 21 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Account/Index.cshtml"
     using (Html.BeginForm("LogOff", "Account"))
    {

#line default
#line hidden
            BeginContext(421, 72, true);
            WriteLiteral("        <input type=\"submit\" class=\"btn btn-default\" value=\"Log out\" />\n");
            EndContext();
#line 24 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Account/Index.cshtml"
    }

#line default
#line hidden
#line 24 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Account/Index.cshtml"
     
}

#line default
#line hidden
            BeginContext(501, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(505, 40, false);
#line 26 "/Users/Guest/Desktop/Treats.Solution/SweetTreat/Views/Account/Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(545, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
