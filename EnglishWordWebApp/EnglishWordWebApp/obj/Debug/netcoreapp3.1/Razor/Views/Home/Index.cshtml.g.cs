#pragma checksum "C:\Users\Nursel\Desktop\Software\Projects\C#\Bot-ConsoleApp\EnglishWordsPracticeProject\EnglishWordWebApp\EnglishWordWebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "760b39e32c80e195a98257d994b0927dc57a483f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Nursel\Desktop\Software\Projects\C#\Bot-ConsoleApp\EnglishWordsPracticeProject\EnglishWordWebApp\EnglishWordWebApp\Views\_ViewImports.cshtml"
using Entities.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"760b39e32c80e195a98257d994b0927dc57a483f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46da55864dc9597363c674bab7b82a33ec1c99dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Word>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-secondary ml-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Nursel\Desktop\Software\Projects\C#\Bot-ConsoleApp\EnglishWordsPracticeProject\EnglishWordWebApp\EnglishWordWebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"

    



<br>
<br>
<h2 class=""mt-4"">WORDS LIST</h2>
<br>
<div class=""table-responsive"">
    <table class=""table"">
        <thead>
            <tr>
                <th>#</th>
                <th>Name</th>
                <th>Meaning</th>
                <th>Level</th>
                <th>Operations</th>

            </tr>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "760b39e32c80e195a98257d994b0927dc57a483f5109", async() => {
                WriteLiteral("Add New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "760b39e32c80e195a98257d994b0927dc57a483f6360", async() => {
                WriteLiteral("Search");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 33 "C:\Users\Nursel\Desktop\Software\Projects\C#\Bot-ConsoleApp\EnglishWordsPracticeProject\EnglishWordWebApp\EnglishWordWebApp\Views\Home\Index.cshtml"
              
                int count = 1;
                string format = "d  MMM yyyy";

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Nursel\Desktop\Software\Projects\C#\Bot-ConsoleApp\EnglishWordsPracticeProject\EnglishWordWebApp\EnglishWordWebApp\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 41 "C:\Users\Nursel\Desktop\Software\Projects\C#\Bot-ConsoleApp\EnglishWordsPracticeProject\EnglishWordWebApp\EnglishWordWebApp\Views\Home\Index.cshtml"
                   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "C:\Users\Nursel\Desktop\Software\Projects\C#\Bot-ConsoleApp\EnglishWordsPracticeProject\EnglishWordWebApp\EnglishWordWebApp\Views\Home\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "C:\Users\Nursel\Desktop\Software\Projects\C#\Bot-ConsoleApp\EnglishWordsPracticeProject\EnglishWordWebApp\EnglishWordWebApp\Views\Home\Index.cshtml"
                   Write(item.Meaning);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\Nursel\Desktop\Software\Projects\C#\Bot-ConsoleApp\EnglishWordsPracticeProject\EnglishWordWebApp\EnglishWordWebApp\Views\Home\Index.cshtml"
                   Write(item.Level);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    \r\n                    <td>\r\n\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1095, "\"", 1126, 2);
            WriteAttributeValue("", 1102, "Home/UpdateView/", 1102, 16, true);
#nullable restore
#line 48 "C:\Users\Nursel\Desktop\Software\Projects\C#\Bot-ConsoleApp\EnglishWordsPracticeProject\EnglishWordWebApp\EnglishWordWebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1118, item.Id, 1118, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  class=\"btn btn-info btn-sm\">Update</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1195, "\"", 1222, 2);
            WriteAttributeValue("", 1202, "Home/Remove/", 1202, 12, true);
#nullable restore
#line 49 "C:\Users\Nursel\Desktop\Software\Projects\C#\Bot-ConsoleApp\EnglishWordsPracticeProject\EnglishWordWebApp\EnglishWordWebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1214, item.Id, 1214, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\">Remove</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 52 "C:\Users\Nursel\Desktop\Software\Projects\C#\Bot-ConsoleApp\EnglishWordsPracticeProject\EnglishWordWebApp\EnglishWordWebApp\Views\Home\Index.cshtml"
                count += 1;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<br>\r\n<br>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Word>> Html { get; private set; }
    }
}
#pragma warning restore 1591
