#pragma checksum "C:\Users\43706052881\Documents\Aulas C#\WebMVC\Views\Musica\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3aa0c45d0a1ca746c7c5decf3daabebc86c35b02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Musica_Welcome), @"mvc.1.0.view", @"/Views/Musica/Welcome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Musica/Welcome.cshtml", typeof(AspNetCore.Views_Musica_Welcome))]
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
#line 1 "C:\Users\43706052881\Documents\Aulas C#\WebMVC\Views\_ViewImports.cshtml"
using WebMVC;

#line default
#line hidden
#line 2 "C:\Users\43706052881\Documents\Aulas C#\WebMVC\Views\_ViewImports.cshtml"
using WebMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3aa0c45d0a1ca746c7c5decf3daabebc86c35b02", @"/Views/Musica/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d07e873f05b36c9d83cd6a184d4bfbe1720fee4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Musica_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<WebMVC.Models.Musica>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\43706052881\Documents\Aulas C#\WebMVC\Views\Musica\Welcome.cshtml"
  
    ViewData["Title"] = "MUSIC APP";

#line default
#line hidden
            BeginContext(109, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(116, 17, false);
#line 7 "C:\Users\43706052881\Documents\Aulas C#\WebMVC\Views\Musica\Welcome.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(133, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(145, 16, false);
#line 8 "C:\Users\43706052881\Documents\Aulas C#\WebMVC\Views\Musica\Welcome.cshtml"
Write(ViewData["Nome"]);

#line default
#line hidden
            EndContext();
            BeginContext(161, 53, true);
            WriteLiteral(", seja bem vindo!</h3>\r\n\r\n<p>Sua Playlist</p>\r\n<ul>\r\n");
            EndContext();
#line 12 "C:\Users\43706052881\Documents\Aulas C#\WebMVC\Views\Musica\Welcome.cshtml"
 foreach (var item in @Model){

#line default
#line hidden
            BeginContext(246, 46, true);
            WriteLiteral("    <ul>\r\n        <li><strong>Título:</strong>");
            EndContext();
            BeginContext(293, 11, false);
#line 14 "C:\Users\43706052881\Documents\Aulas C#\WebMVC\Views\Musica\Welcome.cshtml"
                               Write(item.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(304, 47, true);
            WriteLiteral("</li>\r\n        <li><strong>Compositor:</strong>");
            EndContext();
            BeginContext(352, 15, false);
#line 15 "C:\Users\43706052881\Documents\Aulas C#\WebMVC\Views\Musica\Welcome.cshtml"
                                   Write(item.Compositor);

#line default
#line hidden
            EndContext();
            BeginContext(367, 43, true);
            WriteLiteral("</li>\r\n        <li><strong>Estilo:</strong>");
            EndContext();
            BeginContext(411, 11, false);
#line 16 "C:\Users\43706052881\Documents\Aulas C#\WebMVC\Views\Musica\Welcome.cshtml"
                               Write(item.Estilo);

#line default
#line hidden
            EndContext();
            BeginContext(422, 18, true);
            WriteLiteral("</li>\r\n    </ul>\r\n");
            EndContext();
#line 18 "C:\Users\43706052881\Documents\Aulas C#\WebMVC\Views\Musica\Welcome.cshtml"

}

#line default
#line hidden
            BeginContext(445, 5, true);
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<WebMVC.Models.Musica>> Html { get; private set; }
    }
}
#pragma warning restore 1591