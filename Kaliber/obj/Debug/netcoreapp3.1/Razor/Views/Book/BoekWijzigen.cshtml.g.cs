#pragma checksum "D:\Git\KaliberV2\Kaliber\Views\Book\BoekWijzigen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fc22d2b4e1517119a6589ca47aa1b16140209f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_BoekWijzigen), @"mvc.1.0.view", @"/Views/Book/BoekWijzigen.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fc22d2b4e1517119a6589ca47aa1b16140209f5", @"/Views/Book/BoekWijzigen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6496985b50163bee9e0358f602f0984f27443260", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_BoekWijzigen : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Interfaces.DTO.BookDTO>
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
#line 2 "D:\Git\KaliberV2\Kaliber\Views\Book\BoekWijzigen.cshtml"
  
    ViewData["Title"] = "BoekWijzigen";
    var id = Url.ActionContext.RouteData.Values["id"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>BoekWijzigen</h1>\r\n\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fc22d2b4e1517119a6589ca47aa1b16140209f53535", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fc22d2b4e1517119a6589ca47aa1b16140209f54722", async() => {
                WriteLiteral("\r\n    <div class=\"col-5\">\r\n");
#nullable restore
#line 22 "D:\Git\KaliberV2\Kaliber\Views\Book\BoekWijzigen.cshtml"
         using (Html.BeginForm("UpdateBook", "Book", FormMethod.Post, new { enctype = "multiplart/form-data" }))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <table cellpadding=""0"" cellspacing=""0"">
                <tr>
                    <th colspan=""2"" align=""center"">Book</th>
                </tr>
                <tr>
                    <td>Titel: </td>
                    <td>
                        ");
#nullable restore
#line 31 "D:\Git\KaliberV2\Kaliber\Views\Book\BoekWijzigen.cshtml"
                   Write(Html.TextBoxFor(m => m.Title, new { id = "Title" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Ondertitel: </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 37 "D:\Git\KaliberV2\Kaliber\Views\Book\BoekWijzigen.cshtml"
                   Write(Html.TextBoxFor(m => m.Subtitle, new { id = "Sub" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Voornaam auteur: </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 43 "D:\Git\KaliberV2\Kaliber\Views\Book\BoekWijzigen.cshtml"
                   Write(Html.TextBoxFor(m => m.author.Firstname, new { id = "Firstname"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Tussenvoegsel: </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 49 "D:\Git\KaliberV2\Kaliber\Views\Book\BoekWijzigen.cshtml"
                   Write(Html.TextBoxFor(m => m.author.Preposition, new { id = "Prep" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Achternaam auteur: </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 55 "D:\Git\KaliberV2\Kaliber\Views\Book\BoekWijzigen.cshtml"
                   Write(Html.TextBoxFor(m => m.author.Lastname, new { id = "Lastname" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Uitgever: </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 61 "D:\Git\KaliberV2\Kaliber\Views\Book\BoekWijzigen.cshtml"
                   Write(Html.TextBoxFor(m => m.publisher, new { id = "Publisher" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Categorie: </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 67 "D:\Git\KaliberV2\Kaliber\Views\Book\BoekWijzigen.cshtml"
                   Write(Html.TextBoxFor(m => m.Category, new { id = "Category" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Jaar van Uitgave: </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 73 "D:\Git\KaliberV2\Kaliber\Views\Book\BoekWijzigen.cshtml"
                   Write(Html.TextBoxFor(m => m.Year_of_publication, new { id = "Year" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td><input type=\"submit\" value=\"Submit\" /></td>\r\n                </tr>\r\n            </table>\r\n");
#nullable restore
#line 80 "D:\Git\KaliberV2\Kaliber\Views\Book\BoekWijzigen.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n    <div id=\"list\" class=\"col-5\">\r\n\r\n    </div>\r\n");
                WriteLiteral(@"    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"" type=""text/javascript""></script>

    <script>
        $(document).ready(function () {

            $.ajax({
                type: ""GET"",
                traditional: true,
                url: ""/Book/SearchBookByTitle"",
                data: { 'title': '");
#nullable restore
#line 96 "D:\Git\KaliberV2\Kaliber\Views\Book\BoekWijzigen.cshtml"
                             Write(Html.Raw(@id.ToString()));

#line default
#line hidden
#nullable disable
                WriteLiteral("\' },\r\n                dataType: \"json\",\r\n            }).done(function (arrayBook) {\r\n\r\n                console.log(\'");
#nullable restore
#line 100 "D:\Git\KaliberV2\Kaliber\Views\Book\BoekWijzigen.cshtml"
                        Write(Html.Raw(@id.ToString()));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"');
                document.getElementById(""list"").innerHTML = """";

                for (var i = 0; i < arrayBook[""books""].length; i++) {

                    document.getElementById(""Title"").value = arrayBook[""books""][i][""title""];
                    document.getElementById(""Sub"").value = arrayBook[""books""][i][""subtitle""];
                    document.getElementById(""Firstname"").value = arrayBook[""books""][i][""author""][""firstname""];
                    document.getElementById(""Prep"").value = arrayBook[""books""][i][""author""][""preposition""];
                    document.getElementById(""Lastname"").value = arrayBook[""books""][i][""author""][""lastname""];
                    document.getElementById(""Publisher"").value = arrayBook[""books""][i][""publisher""];
                    document.getElementById(""Category"").value = arrayBook[""books""][i][""category""];
                    document.getElementById(""Year"").value = arrayBook[""books""][i][""year_of_publication""];
                    console.log(arrayBook[""books""]");
                WriteLiteral(@"[i][""year_of_publication""]);

                    //var br = document.createElement(""br"");
                    //var button = document.createElement('button')

                    //button.addEventListener(""click"", function () {
                    //    document.getElementById(""Title"").value = this.firstChild.textContent;
                    //});

                    //button.appendChild(t);

                    //if (t2 != null) {
                    //    button.appendChild(t2);
                    //}

                    //if (t3 != null) {
                    //    button.appendChild(t3);
                    //}

                    //if (t4 != null) {
                    //    button.appendChild(t4);
                    //}

                    //if (t5 != null) {
                    //    button.appendChild(t5);
                    //}

                    //if (t6 != null) {
                    //    button.appendChild(t6);
                    //}

                    ");
                WriteLiteral(@"//if (t7 != null) {
                    //    button.appendChild(t7);
                    //}

                    //if (t8 != null) {
                    //    button.appendChild(t8);
                    //}

                    //t = null;
                    //t2 = null;
                    //t3 = null;
                    //t4 = null;
                    //t5 = null;
                    //t6 = null;
                    //t7 = null;
                    //t8 = null;

                    //document.getElementById(""list"").appendChild(button);
                    //document.getElementById(""list"").appendChild(br);
                }

            }).fail(function (e) {
                console.log(e.responseText);
            });
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Interfaces.DTO.BookDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591