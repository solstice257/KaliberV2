#pragma checksum "D:\Git\KaliberV2\Kaliber\Views\Author\AuthorToevoegen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c1f99d85aa357d7c8430e0881e0fa0d52b54844"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_AuthorToevoegen), @"mvc.1.0.view", @"/Views/Author/AuthorToevoegen.cshtml")]
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
#line 1 "D:\Git\KaliberV2\Kaliber\Views\_ViewImports.cshtml"
using Kaliber;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Git\KaliberV2\Kaliber\Views\_ViewImports.cshtml"
using Kaliber.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c1f99d85aa357d7c8430e0881e0fa0d52b54844", @"/Views/Author/AuthorToevoegen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6496985b50163bee9e0358f602f0984f27443260", @"/Views/_ViewImports.cshtml")]
    public class Views_Author_AuthorToevoegen : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kaliber.Models.AuthorView>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Git\KaliberV2\Kaliber\Views\Author\AuthorToevoegen.cshtml"
  
    ViewData["Title"] = "AuthorToevoegen";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Auteur toevoegen</h2>\r\n<br />\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c1f99d85aa357d7c8430e0881e0fa0d52b548443525", async() => {
                WriteLiteral("\r\n    <title>Index</title>\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width,initial-scale=1\">\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"css/bootstrap.min.css\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c1f99d85aa357d7c8430e0881e0fa0d52b548444712", async() => {
                WriteLiteral("\r\n    <div>\r\n        <span style=\"color:red; font-style:oblique; display:block; padding-top:10px;\">  ");
#nullable restore
#line 21 "D:\Git\KaliberV2\Kaliber\Views\Author\AuthorToevoegen.cshtml"
                                                                                   Write(Html.ValidationMessage("Alert"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>\r\n        <span style=\"color:green; font-style:oblique; display:block;\"> ");
#nullable restore
#line 22 "D:\Git\KaliberV2\Kaliber\Views\Author\AuthorToevoegen.cshtml"
                                                                  Write(Html.ValidationMessage("Succes"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n    </div>\r\n    <br />\r\n    <div class=\"col-6\" style=\"float:left;\">\r\n");
#nullable restore
#line 26 "D:\Git\KaliberV2\Kaliber\Views\Author\AuthorToevoegen.cshtml"
         using (Html.BeginForm("AddAuthor", "Author", FormMethod.Post, new { enctype = "multiplart/form-data" }))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <table cellpadding=\"0\" cellspacing=\"0\" style=\"width:320px; border-spacing:\">\r\n                <tr>\r\n                    <td>Voornaam: </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 32 "D:\Git\KaliberV2\Kaliber\Views\Author\AuthorToevoegen.cshtml"
                   Write(Html.TextBoxFor(m => m.Firstname));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Tussenvoegsel: </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 38 "D:\Git\KaliberV2\Kaliber\Views\Author\AuthorToevoegen.cshtml"
                   Write(Html.TextBoxFor(m => m.Preposition));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Achternaam: </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "D:\Git\KaliberV2\Kaliber\Views\Author\AuthorToevoegen.cshtml"
                   Write(Html.TextBoxFor(m => m.Lastname));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Stad: </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "D:\Git\KaliberV2\Kaliber\Views\Author\AuthorToevoegen.cshtml"
                   Write(Html.TextBoxFor(m => m.City));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Geboortejaar: </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 56 "D:\Git\KaliberV2\Kaliber\Views\Author\AuthorToevoegen.cshtml"
                   Write(Html.TextBoxFor(m => m.Year_of_birth));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Sterftejaar: </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 62 "D:\Git\KaliberV2\Kaliber\Views\Author\AuthorToevoegen.cshtml"
                   Write(Html.TextBoxFor(m => m.Year_of_death));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td><input type=\"submit\" value=\"Toevoegen\" /></td>\r\n                </tr>\r\n\r\n            </table>\r\n");
#nullable restore
#line 70 "D:\Git\KaliberV2\Kaliber\Views\Author\AuthorToevoegen.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kaliber.Models.AuthorView> Html { get; private set; }
    }
}
#pragma warning restore 1591
