#pragma checksum "C:\Users\giova\OneDrive\Documentos\8semestre\desenvolvimento web 2\2022-09-20\achei-web\achei-web\Views\Iten\Read.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "627c585572a812b8756423d16fe2132993b44164"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Iten_Read), @"mvc.1.0.view", @"/Views/Iten/Read.cshtml")]
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
#line 1 "C:\Users\giova\OneDrive\Documentos\8semestre\desenvolvimento web 2\2022-09-20\achei-web\achei-web\Views\_ViewImports.cshtml"
using achei_web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\giova\OneDrive\Documentos\8semestre\desenvolvimento web 2\2022-09-20\achei-web\achei-web\Views\_ViewImports.cshtml"
using achei_web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"627c585572a812b8756423d16fe2132993b44164", @"/Views/Iten/Read.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff9ea4c0ded319976fdc96f66d9a11a60734065f", @"/Views/_ViewImports.cshtml")]
    public class Views_Iten_Read : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mx-1 mx-md-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\giova\OneDrive\Documentos\8semestre\desenvolvimento web 2\2022-09-20\achei-web\achei-web\Views\Iten\Read.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "627c585572a812b8756423d16fe2132993b441644238", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/css/bootstrap.min.css""
          integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
    <title>Item</title>
    <style>
        body {
            background-color: rgb(255, 246, 229);
        }

        img {
            max-height: 300px;
        }

        span {
            font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
            font-size: 20px;
        }
    </style>
");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "627c585572a812b8756423d16fe2132993b441645956", async() => {
                WriteLiteral(@"
    <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
        <a class=""navbar-brand"" href=""tela_login_aluno.html"">Tapt!</a>
        <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
            <ul class=""navbar-nav mr-auto"">
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""tela_login_aluno.html"">Index</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""tela_cadastro_aluno.html"">Cadastro aluno</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""tela_cadastro_item.html"">Cadastro item</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""tela_lista_itens.html"">Itens</a>
                </li>
            </ul>
        </div>
    </nav>
    <section>
        <div class=""container h-100 mt-5 mb-5"">
            <div class=""row d-flex justify-content-center align");
                WriteLiteral(@"-items-center h-100"">
                <div class=""col-lg-12 col-xl-11"">
                    <div class=""card text-black"" style=""border-radius: 25px;"">
                        <div class=""card-body p-md-5"">
                            <div class=""row justify-content-center"">

                                <div class=""col-md-10 col-lg-6 col-xl-5 order-2 order-lg-1"">

                                    <p class=""text-center h1 fw-bold mb-5 mx-1 mx-md-4 mt-4"">Caderno</p>

                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "627c585572a812b8756423d16fe2132993b441647847", async() => {
                    WriteLiteral("\r\n\r\n                                        <div class=\"d-flex flex-row align-items-center justify-content-center mb-4\">\r\n                                            <img src=\"fotos/caderno.webp\"");
                    BeginWriteAttribute("alt", " alt=\"", 2590, "\"", 2596, 0);
                    EndWriteAttribute();
                    WriteLiteral(@">
                                        </div>

                                        <div class=""d-flex flex-row align-items-center mb-4"">
                                            <div class=""form-outline flex-fill mb-0"">
                                                <span>Caderno marrom com adesivos com nome Joana</span>
                                            </div>
                                        </div>

                                        <div class=""d-flex flex-row align-items-center mb-4"">
                                            <div class=""form-outline flex-fill mb-0"">
                                                <span>Encontrado em: 10/09/2022</span>
                                            </div>
                                        </div>

                                        <div class=""d-flex flex-row align-items-center mb-4"">
                                            <div class=""form-outline flex-fill mb-0"">
                            ");
                    WriteLiteral(@"                    <span>Status: Ainda não recuperado</span>
                                            </div>
                                        </div>

                                        <div class=""d-flex justify-content-center mx-4 mb-3 mb-lg-4"">
                                            <a href=""chat.html"" type=""button"" class=""btn btn-primary btn-lg"">Iniciar chat</a>
                                        </div>

                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
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
            WriteLiteral("\r\n\r\n</html>");
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
