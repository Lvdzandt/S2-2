#pragma checksum "C:\Users\Luc\Desktop\git\Speedrun\KillerApp\Views\Login\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39f8612e42a0058867316349598f7ad017796eb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Login), @"mvc.1.0.view", @"/Views/Login/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Login.cshtml", typeof(AspNetCore.Views_Login_Login))]
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
#line 1 "C:\Users\Luc\Desktop\git\Speedrun\KillerApp\Views\_ViewImports.cshtml"
using KillerApp;

#line default
#line hidden
#line 2 "C:\Users\Luc\Desktop\git\Speedrun\KillerApp\Views\_ViewImports.cshtml"
using KillerApp.Models;

#line default
#line hidden
#line 2 "C:\Users\Luc\Desktop\git\Speedrun\KillerApp\Views\Login\Login.cshtml"
using KillerApp.Objects;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39f8612e42a0058867316349598f7ad017796eb3", @"/Views/Login/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6edb7dff1f122510935cd3a16f7b84d2cb7d151d", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KillerApp.Models.LoginViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Luc\Desktop\git\Speedrun\KillerApp\Views\Login\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
            BeginContext(107, 41, true);
            WriteLiteral("<div>\r\n    \r\n</div>\r\n\r\n<div id=\"login\">\r\n");
            EndContext();
#line 11 "C:\Users\Luc\Desktop\git\Speedrun\KillerApp\Views\Login\Login.cshtml"
     using (Html.BeginForm("Login", "Login",FormMethod.Post))
    {

#line default
#line hidden
            BeginContext(218, 159, true);
            WriteLiteral("    <table>\r\n        <tr>\r\n            <td>\r\n                <h2>Login</h2>\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(378, 43, false);
#line 21 "C:\Users\Luc\Desktop\git\Speedrun\KillerApp\Views\Login\Login.cshtml"
           Write(Html.LabelFor(Model => Model.user.Username));

#line default
#line hidden
            EndContext();
            BeginContext(421, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(477, 44, false);
#line 24 "C:\Users\Luc\Desktop\git\Speedrun\KillerApp\Views\Login\Login.cshtml"
           Write(Html.EditorFor(Model => Model.user.Username));

#line default
#line hidden
            EndContext();
            BeginContext(521, 84, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(606, 43, false);
#line 29 "C:\Users\Luc\Desktop\git\Speedrun\KillerApp\Views\Login\Login.cshtml"
           Write(Html.LabelFor(Model => Model.user.Password));

#line default
#line hidden
            EndContext();
            BeginContext(649, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(705, 44, false);
#line 32 "C:\Users\Luc\Desktop\git\Speedrun\KillerApp\Views\Login\Login.cshtml"
           Write(Html.EditorFor(Model => Model.user.Password));

#line default
#line hidden
            EndContext();
            BeginContext(749, 206, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>\r\n                <input type=\"submit\" name=\"name\" value=\"login\" />\r\n            </td>\r\n        </tr>\r\n    </table>\r\n");
            EndContext();
#line 42 "C:\Users\Luc\Desktop\git\Speedrun\KillerApp\Views\Login\Login.cshtml"
    }

#line default
#line hidden
            BeginContext(962, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KillerApp.Models.LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591