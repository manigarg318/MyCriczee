#pragma checksum "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\Quizzs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4703193af61ce95701acd55bb07e8fc795a64dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quizzs_Index), @"mvc.1.0.view", @"/Views/Quizzs/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4703193af61ce95701acd55bb07e8fc795a64dc", @"/Views/Quizzs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed208f4f8e8abe4082edb360fb6c4de649e3acc5", @"/Views/_ViewImports.cshtml")]
    public class Views_Quizzs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<cricZee.Quizz>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\Quizzs\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Quizz</h1>\r\n\r\n\r\n<table class=\"table\">\r\n\r\n    <tbody>\r\n");
#nullable restore
#line 13 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\Quizzs\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n\r\n                    ");
#nullable restore
#line 18 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\Quizzs\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ques));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <input type=\"radio\" id=\"Option1\"");
            BeginWriteAttribute("name", " name=\"", 388, "\"", 436, 1);
#nullable restore
#line 21 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\Quizzs\Index.cshtml"
WriteAttributeValue(" ", 395, Html.DisplayFor(modelItem => item.Ques), 396, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rb\"");
            BeginWriteAttribute("value", " value=\"", 448, "\"", 500, 1);
#nullable restore
#line 21 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\Quizzs\Index.cshtml"
WriteAttributeValue(" ", 456, Html.DisplayFor(modelItem => item.Option1), 457, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    ");
#nullable restore
#line 22 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\Quizzs\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Option1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n\r\n                    <input type=\"radio\" id=\"Option2\"");
            BeginWriteAttribute("name", " name=\"", 670, "\"", 718, 1);
#nullable restore
#line 26 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\Quizzs\Index.cshtml"
WriteAttributeValue(" ", 677, Html.DisplayFor(modelItem => item.Ques), 678, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rb\"");
            BeginWriteAttribute("value", " value=\"", 730, "\"", 782, 1);
#nullable restore
#line 26 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\Quizzs\Index.cshtml"
WriteAttributeValue(" ", 738, Html.DisplayFor(modelItem => item.Option2), 739, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    ");
#nullable restore
#line 27 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\Quizzs\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Option2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <input type=\"radio\" id=\"Option3\"");
            BeginWriteAttribute("name", " name=\"", 950, "\"", 998, 1);
#nullable restore
#line 30 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\Quizzs\Index.cshtml"
WriteAttributeValue(" ", 957, Html.DisplayFor(modelItem => item.Ques), 958, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rb\"");
            BeginWriteAttribute("value", " value=\"", 1010, "\"", 1062, 1);
#nullable restore
#line 30 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\Quizzs\Index.cshtml"
WriteAttributeValue(" ", 1018, Html.DisplayFor(modelItem => item.Option3), 1019, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n                    ");
#nullable restore
#line 32 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\Quizzs\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Option3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <input type=\"radio\" id=\"Option4\"");
            BeginWriteAttribute("name", " name=\"", 1232, "\"", 1280, 1);
#nullable restore
#line 35 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\Quizzs\Index.cshtml"
WriteAttributeValue(" ", 1239, Html.DisplayFor(modelItem => item.Ques), 1240, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rb\"");
            BeginWriteAttribute("value", " value=\"", 1292, "\"", 1344, 1);
#nullable restore
#line 35 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\Quizzs\Index.cshtml"
WriteAttributeValue(" ", 1300, Html.DisplayFor(modelItem => item.Option4), 1301, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    ");
#nullable restore
#line 36 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\Quizzs\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Option4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <label id=\"corrections\"");
            BeginWriteAttribute("name", " name=\"", 1542, "\"", 1590, 1);
#nullable restore
#line 42 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\Quizzs\Index.cshtml"
WriteAttributeValue(" ", 1549, Html.DisplayFor(modelItem => item.Ques), 1550, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rb\" style=\"display:none;color:forestgreen;\"><b>");
#nullable restore
#line 42 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\Quizzs\Index.cshtml"
                                                                                                                                              Write(Html.DisplayFor(modelItem => item.Correct));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></label>\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 46 "C:\Users\manig\OneDrive\Desktop\Crickzee2\cricZee\cricZee\Views\Quizzs\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<button type=""button"" id=""buttonexam"" class=""btn-success"" onclick=""displayresult();"">
    Submit
</button>

<label id=""useranswers""></label>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>

<script>
    $(document).ready(function () {

        $(""#buttonexam"").click(function () {

            $("".rb"").show();
            $("".rb"").attr(""disabled"", true);

        });
    });

    function displayresult() {

        document.getElementById(""useranswers"").innerHTML = """";
        var results = document.getElementsByTagName(""input"");
        for (i = 0; i < results.length; i++) {

            if (results[i].type == ""radio"") {
                if (results[i].checked) {
                    document.getElementById(""useranswers"").innerHTML += ""Q"" + results[i].name + "")"" + results[i].value + ""<br/>""
                }
            }
        }

    }




</script>




");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<cricZee.Quizz>> Html { get; private set; }
    }
}
#pragma warning restore 1591
