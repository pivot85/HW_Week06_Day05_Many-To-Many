#pragma checksum "C:\Users\96658\source\repos\CodeFirstApp\Views\Branches\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab0cb3f471871fe38511aa3158b4adbe7c65917d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Branches_Index), @"mvc.1.0.view", @"/Views/Branches/Index.cshtml")]
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
#line 1 "C:\Users\96658\source\repos\CodeFirstApp\Views\_ViewImports.cshtml"
using CodeFirstApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\96658\source\repos\CodeFirstApp\Views\_ViewImports.cshtml"
using CodeFirstApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab0cb3f471871fe38511aa3158b4adbe7c65917d", @"/Views/Branches/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a67b1c23b3f15af6920d3c70b52285a28e3f28e", @"/Views/_ViewImports.cshtml")]
    public class Views_Branches_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\96658\source\repos\CodeFirstApp\Views\Branches\Index.cshtml"
   
    List<BranchModel> branches = (List<BranchModel>) ViewData["Branches"];
    string searchByID = ViewData["searchByID"] as string;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>This is a Branch Index</h1>\r\n<h2>");
#nullable restore
#line 6 "C:\Users\96658\source\repos\CodeFirstApp\Views\Branches\Index.cshtml"
Write(searchByID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <td>ID</td>\r\n            <td>Area</td>\r\n            <td>Email</td>\r\n            <td>Name</td>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 18 "C:\Users\96658\source\repos\CodeFirstApp\Views\Branches\Index.cshtml"
           
            foreach (var item in branches)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\96658\source\repos\CodeFirstApp\Views\Branches\Index.cshtml"
                   Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\96658\source\repos\CodeFirstApp\Views\Branches\Index.cshtml"
                   Write(item.Area);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\96658\source\repos\CodeFirstApp\Views\Branches\Index.cshtml"
                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\96658\source\repos\CodeFirstApp\Views\Branches\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 27 "C:\Users\96658\source\repos\CodeFirstApp\Views\Branches\Index.cshtml"
                
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n    </tbody>\r\n</table>\r\n");
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