#pragma checksum "B:\Users\exis\Desktop\Ejercicios\Library\Libros\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35b66d4b548aefdf72ed26666d0cd1cb61b9a4e3"
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
#line 1 "B:\Users\exis\Desktop\Ejercicios\Library\Libros\Views\_ViewImports.cshtml"
using Libros;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "B:\Users\exis\Desktop\Ejercicios\Library\Libros\Views\_ViewImports.cshtml"
using Libros.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35b66d4b548aefdf72ed26666d0cd1cb61b9a4e3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47f284a82499c1cd33601f88b5720bbacd3ea98f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "B:\Users\exis\Desktop\Ejercicios\Library\Libros\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<header class=""masthead"">
    <div class=""container position-relative"">
        <div class=""row justify-content-center"">
            <div class=""col-xl-6 text-center"">
                <div class=""text-center text-white"">
                    <h2 class=""mb-5"" style=""font-weight:bold"">Registrar y gestionar la información de los libros</h2>
                    <div class=""row text-center"">
                        <div class=""text-center""><a role=""button""");
            BeginWriteAttribute("href", " href=\"", 508, "\"", 547, 1);
#nullable restore
#line 12 "B:\Users\exis\Desktop\Ejercicios\Library\Libros\Views\Home\Index.cshtml"
WriteAttributeValue("", 515, Url.Action("LibrosList","Home"), 515, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success btn-lg\">Ver libros</a></div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</header>");
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
