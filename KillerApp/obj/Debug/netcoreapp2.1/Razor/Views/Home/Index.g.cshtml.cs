#pragma checksum "C:\Users\Luc\Desktop\git\Speedrun\KillerApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7040fa55ef62382c9b44e8a47e85874fbfe044f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7040fa55ef62382c9b44e8a47e85874fbfe044f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6edb7dff1f122510935cd3a16f7b84d2cb7d151d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Luc\Desktop\git\Speedrun\KillerApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 7 "C:\Users\Luc\Desktop\git\Speedrun\KillerApp\Views\Home\Index.cshtml"
  
    var sessionName = new Byte[20];
    bool nameOK = Context.Session.TryGetValue("name", out sessionName);
    

#line default
#line hidden
#line 10 "C:\Users\Luc\Desktop\git\Speedrun\KillerApp\Views\Home\Index.cshtml"
     if (!nameOK)
    {
        

#line default
#line hidden
            BeginContext(205, 697, true);
            WriteLiteral(@" Lorem ipsum dolor sit amet, consectetur adipiscing elit.Mauris vitae imperdiet ligula. Suspendisse potenti. Vivamus eget tellus facilisis, dignissim velit in, rhoncus augue. Nulla arcu nulla, condimentum nec rutrum ac, accumsan sed urna. Duis non purus porttitor, vestibulum ligula sed, feugiat diam.Maecenas pharetra semper justo at lobortis. Aliquam tristique dignissim eros non venenatis. Quisque iaculis viverra orci non feugiat. Phasellus lacinia lacinia luctus. Donec non mauris aliquet, aliquam turpis vitae, cursus leo.Suspendisse fermentum leo ut tellus pulvinar, sodales tincidunt elit pharetra.Praesent suscipit condimentum massa in ultrices.Maecenas accumsan convallis nisl in mollis ");
            EndContext();
#line 12 "C:\Users\Luc\Desktop\git\Speedrun\KillerApp\Views\Home\Index.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
    }

#line default
#line hidden
#line 14 "C:\Users\Luc\Desktop\git\Speedrun\KillerApp\Views\Home\Index.cshtml"
     if (nameOK)
    {
        string result = System.Text.Encoding.UTF8.GetString(sessionName);

#line default
#line hidden
            BeginContext(1018, 12, true);
            WriteLiteral("        <p> ");
            EndContext();
            BeginContext(1031, 6, false);
#line 17 "C:\Users\Luc\Desktop\git\Speedrun\KillerApp\Views\Home\Index.cshtml"
       Write(result);

#line default
#line hidden
            EndContext();
            BeginContext(1037, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 18 "C:\Users\Luc\Desktop\git\Speedrun\KillerApp\Views\Home\Index.cshtml"

        }

#line default
#line hidden
            BeginContext(1063, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
