#pragma checksum "B:\Users\exis\Desktop\Ejercicios\Library\Libros\Views\Home\LibrosList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d1f8836171cf74724d8e29b74a4ca3c4b9b6701"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LibrosList), @"mvc.1.0.view", @"/Views/Home/LibrosList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d1f8836171cf74724d8e29b74a4ca3c4b9b6701", @"/Views/Home/LibrosList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47f284a82499c1cd33601f88b5720bbacd3ea98f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_LibrosList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Libros.Models.Libro>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8d1f8836171cf74724d8e29b74a4ca3c4b9b67014203", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d1f8836171cf74724d8e29b74a4ca3c4b9b67015317", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div class=""container"">
    <br />
    <br />
    <div class=""panel panel-default"">
        <div class=""panel-heading"">
            <strong>LISTADO GENERAL DE LIBROS</strong>
        </div>
        <div class=""panel-body"">
            <div class=""row"">
                <div class=""col-sm-12 text-right form-group"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 520, "\"", 554, 1);
#nullable restore
#line 16 "B:\Users\exis\Desktop\Ejercicios\Library\Libros\Views\Home\LibrosList.cshtml"
WriteAttributeValue("", 527, Url.Action("Libro","Home"), 527, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-success"" role=""button"">Añadir Libro</a>
                </div>
            </div>
            <table class=""table table-bordered table-striped table-condensed"" style=""font-size: 14px;"">
                <thead>
                    <tr>
                        <th>Titulo</th>
                        <th>Autor</th>
                        <th>Editorial</th>
                        <th>Idioma</th>
                        <th>Año</th>
                        <th>Numero de paginas</th>
                        <th></th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 33 "B:\Users\exis\Desktop\Ejercicios\Library\Libros\Views\Home\LibrosList.cshtml"
                     if (Model.Count > 0)
                    {
                        foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 38 "B:\Users\exis\Desktop\Ejercicios\Library\Libros\Views\Home\LibrosList.cshtml"
                               Write(item.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 39 "B:\Users\exis\Desktop\Ejercicios\Library\Libros\Views\Home\LibrosList.cshtml"
                               Write(item.Autor.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 39 "B:\Users\exis\Desktop\Ejercicios\Library\Libros\Views\Home\LibrosList.cshtml"
                                                   Write(item.Autor.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 40 "B:\Users\exis\Desktop\Ejercicios\Library\Libros\Views\Home\LibrosList.cshtml"
                               Write(item.Editorial);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 41 "B:\Users\exis\Desktop\Ejercicios\Library\Libros\Views\Home\LibrosList.cshtml"
                               Write(item.Idioma.Idioma1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 42 "B:\Users\exis\Desktop\Ejercicios\Library\Libros\Views\Home\LibrosList.cshtml"
                               Write(item.Año);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 43 "B:\Users\exis\Desktop\Ejercicios\Library\Libros\Views\Home\LibrosList.cshtml"
                               Write(item.NumPaginas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center\"><a class=\"btn btn-success btn-sm\" role=\"button\"");
            BeginWriteAttribute("href", " href=\"", 1870, "\"", 1934, 1);
#nullable restore
#line 44 "B:\Users\exis\Desktop\Ejercicios\Library\Libros\Views\Home\LibrosList.cshtml"
WriteAttributeValue("", 1877, Url.Action("Libro","Home", new {idlibro = item.IdLibro}), 1877, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"glyphicon glyphicon-pencil\"></i> Editar</a></td>\r\n                                <td class=\"text-center\"><a class=\"btn btn-danger btn-sm\" role=\"button\"");
            BeginWriteAttribute("href", " href=\"", 2098, "\"", 2144, 3);
            WriteAttributeValue("", 2105, "javascript:EliminarLibro(", 2105, 25, true);
#nullable restore
#line 45 "B:\Users\exis\Desktop\Ejercicios\Library\Libros\Views\Home\LibrosList.cshtml"
WriteAttributeValue("", 2130, item.IdLibro, 2130, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2143, ")", 2143, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"glyphicon glyphicon-trash\"></i> Eliminar</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 47 "B:\Users\exis\Desktop\Ejercicios\Library\Libros\Views\Home\LibrosList.cshtml"
                        }
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td class=\"text-center\" colspan=\"8\">No se han cargado datos</td>\r\n                        </tr>\r\n");
#nullable restore
#line 54 "B:\Users\exis\Desktop\Ejercicios\Library\Libros\Views\Home\LibrosList.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n    function EliminarLibro(a)\r\n    {\r\n        var txt = confirm(\"Esta seguro/a de eliminar este libro?\");\r\n        if (txt) {\r\n            var url = \"");
#nullable restore
#line 67 "B:\Users\exis\Desktop\Ejercicios\Library\Libros\Views\Home\LibrosList.cshtml"
                  Write(Url.Action("EliminarLibro", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("?idlibro=\" + a;\r\n            location.href = url;\r\n        }\r\n    }\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Libros.Models.Libro>> Html { get; private set; }
    }
}
#pragma warning restore 1591