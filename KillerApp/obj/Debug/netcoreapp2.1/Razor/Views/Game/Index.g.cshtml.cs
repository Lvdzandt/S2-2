#pragma checksum "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ae0d2ffd6bbc31e4fc45b5432199cf09fc0de29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_Index), @"mvc.1.0.view", @"/Views/Game/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Game/Index.cshtml", typeof(AspNetCore.Views_Game_Index))]
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
#line 1 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\_ViewImports.cshtml"
using KillerApp;

#line default
#line hidden
#line 2 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\_ViewImports.cshtml"
using KillerApp.Models;

#line default
#line hidden
#line 2 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
using KillerApp.Objects;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ae0d2ffd6bbc31e4fc45b5432199cf09fc0de29", @"/Views/Game/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6edb7dff1f122510935cd3a16f7b84d2cb7d151d", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KillerApp.Models.AllGameViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/datatables.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/datatables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/DataTableSearch.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/GameMoreInfo.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
  
    ViewData["Title"] = "Game";

#line default
#line hidden
            BeginContext(108, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c62e21ead9864aa981a36e8c106ad889", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(150, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(152, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a9ae8fca91ff4f96981937d0da8971c4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(225, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(227, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e206c7d4adc4466aabd76cd786f31174", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(301, 325, true);
            WriteLiteral(@"
<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.19/css/jquery.dataTables.css"">

<script type=""text/javascript"" charset=""utf8"" src=""https://cdn.datatables.net/1.10.19/js/jquery.dataTables.js""></script>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
");
            EndContext();
            BeginContext(626, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63c2ffe5294e436dab7ce1554e02cdf5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(693, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(699, 13, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0a7f35a1a45497d85ac7f630d36681d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(712, 45, true);
            WriteLiteral("\r\n<div>\r\n    <div>\r\n        <h2>Game</h2>\r\n\r\n");
            EndContext();
#line 21 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
          
            var sessionName = new Byte[20];
            bool nameOK = Context.Session.TryGetValue("_Name", out sessionName);
        

#line default
#line hidden
            BeginContext(907, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 25 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
         if (nameOK)
        {
            //TODO: FIX addgame label same row H2   

#line default
#line hidden
            BeginContext(994, 94, true);
            WriteLiteral("            <div id=\"new-game\" style=\"float:right;\">\r\n                <br />\r\n                ");
            EndContext();
            BeginContext(1089, 38, false);
#line 30 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
           Write(Html.ActionLink("Add Game", "AddGame"));

#line default
#line hidden
            EndContext();
            BeginContext(1127, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 32 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1160, 565, true);
            WriteLiteral(@"        <hr />
    </div>
</div>

<div>
    <h3>Search table</h3>
    <input class=""form-control"" type=""text"" id=""prodId"" style=""width:300px"" />
    <h4 id=""searchedProduct"" class=""modal-dialog""></h4>
</div>

<div class=""container-fluid"">

    <table id=""example"" class=""table table-striped table-bordered nowrap"">
        <thead>
            <tr>
                <th></th>
                <th>Game ID</th>
                <th>Game Name</th>
                <th>Description</th>
            </tr>
        </thead>
        <tbody id=""myTable"">
");
            EndContext();
#line 55 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
             foreach (var item in Model.Game)
            {
                string tablerowclass = "cat" + item.ID;

#line default
#line hidden
            BeginContext(1844, 116, true);
            WriteLiteral("                <tr id=\"tablerow\">\r\n                    <td id=\"MoreInf\"><a href=\"#\" class=\"toggler\" data-prod-cat=\"");
            EndContext();
            BeginContext(1961, 7, false);
#line 59 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
                                                                           Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1968, 53, true);
            WriteLiteral("\">*</a></td>\r\n                    <td class=\"search\">");
            EndContext();
            BeginContext(2022, 33, false);
#line 60 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
                                  Write(Html.DisplayFor(Model => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(2055, 48, true);
            WriteLiteral("</td>\r\n                    <td class=\"search\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2103, "\"", 2129, 2);
            WriteAttributeValue("", 2110, "/Game/Game/", 2110, 11, true);
#line 61 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
WriteAttributeValue("", 2121, item.ID, 2121, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2130, 2, true);
            WriteLiteral(")>");
            EndContext();
            BeginContext(2133, 35, false);
#line 61 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
                                                                 Write(Html.DisplayFor(Model => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2168, 50, true);
            WriteLiteral("</a></td>\r\n                    <td class=\"search\">");
            EndContext();
            BeginContext(2219, 42, false);
#line 62 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
                                  Write(Html.DisplayFor(Model => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2261, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
            BeginContext(2295, 50, true);
            WriteLiteral("                <tr id=\"test\" style=\"display:none\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2345, "\"", 2367, 1);
#line 66 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
WriteAttributeValue("", 2353, tablerowclass, 2353, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2368, 70, true);
            WriteLiteral(">\r\n                    <td></td>\r\n                    <td>Speedruns:  ");
            EndContext();
            BeginContext(2439, 31, false);
#line 68 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
                               Write(item.Leaderbord.Speedruns.Count);

#line default
#line hidden
            EndContext();
            BeginContext(2470, 92, true);
            WriteLiteral("</td>\r\n                    <td></td>\r\n                    <td></td>\r\n                </tr>\r\n");
            EndContext();
#line 72 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2577, 48, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KillerApp.Models.AllGameViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
