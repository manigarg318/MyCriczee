#pragma checksum "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\TopBatsmen\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82a3bc3d1cda1fa02b6ffda0bc2a29d4437f25af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TopBatsmen_Index), @"mvc.1.0.view", @"/Views/TopBatsmen/Index.cshtml")]
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
#line 1 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\_ViewImports.cshtml"
using cricZee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\_ViewImports.cshtml"
using cricZee.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82a3bc3d1cda1fa02b6ffda0bc2a29d4437f25af", @"/Views/TopBatsmen/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed208f4f8e8abe4082edb360fb6c4de649e3acc5", @"/Views/_ViewImports.cshtml")]
    public class Views_TopBatsmen_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<cricZee.Models.TopBatsmen>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\TopBatsmen\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Top Scorers</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\TopBatsmen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Player));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\TopBatsmen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Innings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\TopBatsmen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Runs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\TopBatsmen\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\TopBatsmen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Player));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\TopBatsmen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Innings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\TopBatsmen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Runs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 38 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\TopBatsmen\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<cricZee.Models.TopBatsmen>> Html { get; private set; }
    }
}
#pragma warning restore 1591