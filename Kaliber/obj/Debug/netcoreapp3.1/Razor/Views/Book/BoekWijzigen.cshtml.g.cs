#pragma checksum "D:\Git\KaliberV2\Kaliber\Views\Book\BoekWijzigen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9eedeaaf77af46e1f1718d6e728713d347f50bde"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9eedeaaf77af46e1f1718d6e728713d347f50bde", @"/Views/Book/BoekWijzigen.cshtml")]
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

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>BoekWijzigen</h1>\r\n\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eedeaaf77af46e1f1718d6e728713d347f50bde3479", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eedeaaf77af46e1f1718d6e728713d347f50bde4666", async() => {
                WriteLiteral("\r\n    <div class=\"col-5\">\r\n");
#nullable restore
#line 21 "D:\Git\KaliberV2\Kaliber\Views\Book\BoekWijzigen.cshtml"
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
#line 30 "D:\Git\KaliberV2\Kaliber\Views\Book\BoekWijzigen.cshtml"
                   Write(Html.TextBoxFor(m => m.Title, new { id = "Title", @onkeyup = "OnChangeTitle();" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Ondertitel: </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 36 "D:\Git\KaliberV2\Kaliber\Views\Book\BoekWijzigen.cshtml"
                   Write(Html.TextBoxFor(m => m.Subtitle, new { id = "Sub" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Voornaam auteur: </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 42 "D:\Git\KaliberV2\Kaliber\Views\Book\BoekWijzigen.cshtml"
                   Write(Html.TextBoxFor(m => m.author.Firstname, new { id = "Firstname"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Tussenvoegsel: </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 48 "D:\Git\KaliberV2\Kaliber\Views\Book\BoekWijzigen.cshtml"
                   Write(Html.TextBoxFor(m => m.author.Preposition, new { id = "Prep" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Achternaam auteur: </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 54 "D:\Git\KaliberV2\Kaliber\Views\Book\BoekWijzigen.cshtml"
                   Write(Html.TextBoxFor(m => m.author.Lastname, new { id = "Lastname" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Uitgever: </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 60 "D:\Git\KaliberV2\Kaliber\Views\Book\BoekWijzigen.cshtml"
                   Write(Html.TextBoxFor(m => m.publisher, new { id = "Publisher" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Categorie: </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 66 "D:\Git\KaliberV2\Kaliber\Views\Book\BoekWijzigen.cshtml"
                   Write(Html.TextBoxFor(m => m.Category, new { id = "Category" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Jaar van Uitgave: </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 72 "D:\Git\KaliberV2\Kaliber\Views\Book\BoekWijzigen.cshtml"
                   Write(Html.TextBoxFor(m => m.Year_of_publication, new { id = "Year" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td><input type=\"submit\" value=\"Submit\" /></td>\r\n                </tr>\r\n            </table>\r\n");
#nullable restore
#line 79 "D:\Git\KaliberV2\Kaliber\Views\Book\BoekWijzigen.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n    <div id=\"list\" class=\"col-5\">\r\n\r\n    </div>\r\n");
                WriteLiteral(@"    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"" type=""text/javascript""></script>

    <script>
        function OnChangeTitle() {
            var x = document.getElementById(""Title"").value;
            console.log(x);

            $.ajax({
                type: ""GET"",
                traditional: true,
                url: ""/Book/SearchBookByTitle"",
                data: { 'title': x },
                dataType: ""json"",
            }).done(function (arrayBook) {
                console.log(arrayBook);
                console.log(arrayBook[""books""]);
                console.log(arrayBook[""books""][0]);
                console.log(arrayBook[""books""][0][""author""]);
                console.log(arrayBook[""books""][0][""author""][""firstname""]);

                document.getElementById(""list"").innerHTML = """";


                for (var i = 0; i < arrayBook[""books""].length; i++) {
                    var t = document.createTextNode(arrayBook[""books""][i][""title""])");
                WriteLiteral(@";

                    if (arrayBook[""books""][i][""subtitle""] != null) {
                        var t2 = document.createTextNode(arrayBook[""books""][i][""subtitle""]);
                    }

                    if (arrayBook[""books""][i][""author""][""firstname""] != null) {
                        var t3 = document.createTextNode(arrayBook[""books""][i][""author""][""firstname""]);
                        console.log(t3.textContent);
                    }

                    if (arrayBook[""books""][i][""author""][""preposition""] != null) {
                        var t4 = document.createTextNode(arrayBook[""books""][i][""author""][""preposition""]);
                    }

                    if (arrayBook[""books""][i][""author""][""lastname""] != null) {
                        var t5 = document.createTextNode(arrayBook[""books""][i][""author""][""lastname""]);
                    }

                    if (arrayBook[""books""][i][""publisher""] != null) {
                        var t6 = document.createTextNode(arrayBook[""bo");
                WriteLiteral(@"oks""][i][""publisher""]);
                    }

                    if (arrayBook[""books""][i][""category""] != null) {
                        var t7 = document.createTextNode(arrayBook[""books""][i][""category""]);
                    }

                    if (arrayBook[""books""][i][""year_of_publication""] != null) {
                        var t8 = document.createTextNode(arrayBook[""books""][i][""year_of_publication""]);
                    }

                    var br = document.createElement(""br"");
                    var button = document.createElement('button')

                    button.addEventListener(""click"", function () {
                        document.getElementById(""Title"").value = this.firstChild.textContent;
                    });

                    button.appendChild(t);

                    if (t2 != null) {
                        button.appendChild(t2);
                    }

                    if (t3 != null) {
                        button.appendChild(t3);
        ");
                WriteLiteral(@"            }

                    if (t4 != null) {
                        button.appendChild(t4);
                    }

                    if (t5 != null) {
                        button.appendChild(t5);
                    }

                    if (t6 != null) {
                        button.appendChild(t6);
                    }

                    if (t7 != null) {
                        button.appendChild(t7);
                    }

                    if (t8 != null) {
                        button.appendChild(t8);
                    }

                    t = null;
                    t2 = null;
                    t3 = null;
                    t4 = null;
                    t5 = null;
                    t6 = null;
                    t7 = null;
                    t8 = null;

                    document.getElementById(""list"").appendChild(button);
                    document.getElementById(""list"").appendChild(br);
                }

            }).fail(");
                WriteLiteral("function (e) {\r\n                console.log(e.responseText);\r\n            });\r\n        }\r\n    </script>\r\n");
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
