#pragma checksum "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d9c6aab1ec760d1166558fe5226997255ff6494"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d9c6aab1ec760d1166558fe5226997255ff6494", @"/Views/Game/Index.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cd95ae58bdb421fa9af9e70c77ba9e9", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fc0adea17a7b46788efed713807819b3", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "04101fa146f64780ac1d0b02db9d64a7", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc15f60f82f045c9837fb24c7e0eef98", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f882fdc97bac4301ba20e4d8180dfc3e", async() => {
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
            BeginContext(712, 74, true);
            WriteLiteral("\r\n<div>\r\n    <div style=\"float:left\">\r\n        <h2>Game</h2>\r\n    </div>\r\n");
            EndContext();
#line 21 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
      
        var sessionName = new Byte[20];
        bool nameOK = Context.Session.TryGetValue("_Name", out sessionName);
    

#line default
#line hidden
            BeginContext(920, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 25 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
     if (nameOK)
    {

#line default
#line hidden
            BeginContext(945, 81, true);
            WriteLiteral("        <div id=\"new-game\" style=\"float:right\">\r\n            <br />\r\n            ");
            EndContext();
            BeginContext(1027, 38, false);
#line 29 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
       Write(Html.ActionLink("Add Game", "AddGame"));

#line default
#line hidden
            EndContext();
            BeginContext(1065, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 31 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1090, 343, true);
            WriteLiteral(@"
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
        <tbody>
");
            EndContext();
#line 46 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
             foreach (var item in Model.Game)
            {

#line default
#line hidden
            BeginContext(1495, 105, true);
            WriteLiteral("                <tr id=\"tablerow\">\r\n                    <td id=\"MoreInf\">*</td>\r\n                    <td>");
            EndContext();
            BeginContext(1601, 33, false);
#line 50 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
                   Write(Html.DisplayFor(Model => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1634, 33, true);
            WriteLiteral("</td>\r\n                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1667, "\"", 1693, 2);
            WriteAttributeValue("", 1674, "/Game/Game/", 1674, 11, true);
#line 51 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
WriteAttributeValue("", 1685, item.ID, 1685, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1694, 2, true);
            WriteLiteral(")>");
            EndContext();
            BeginContext(1697, 35, false);
#line 51 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
                                                  Write(Html.DisplayFor(Model => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1732, 35, true);
            WriteLiteral("</a></td>\r\n                    <td>");
            EndContext();
            BeginContext(1768, 42, false);
#line 52 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
                   Write(Html.DisplayFor(Model => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1810, 102, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr id=\"test\" hidden=\"hidden\">\r\n                    <td>");
            EndContext();
            BeginContext(1913, 16, false);
#line 55 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
                   Write(Model.Game.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1929, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 57 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1974, 81, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n<button id=\"hide\">Hide</button>\r\n\r\n\r\n\r\n\r\n");
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
