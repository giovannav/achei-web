#pragma checksum "C:\Users\giova\OneDrive\Documentos\8semestre\desenvolvimento web 2\2022-09-20\achei-web\achei-web\Views\Iten\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "086f5869c49d7aaa2e8920b778dc6a87f1009e0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Iten_List), @"mvc.1.0.view", @"/Views/Iten/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"086f5869c49d7aaa2e8920b778dc6a87f1009e0b", @"/Views/Iten/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff9ea4c0ded319976fdc96f66d9a11a60734065f", @"/Views/_ViewImports.cshtml")]
    public class Views_Iten_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<achei_web.Models.POJO.Student>, achei_web.Models.POJO.Person, List<achei_web.Models.POJO.Iten>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Iten", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Read", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary ml-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\giova\OneDrive\Documentos\8semestre\desenvolvimento web 2\2022-09-20\achei-web\achei-web\Views\Iten\List.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "086f5869c49d7aaa2e8920b778dc6a87f1009e0b7631", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/css/bootstrap.min.css""
          integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
    <title>Itens</title>
    <style>
        body {
            background-color: rgb(255, 246, 229);
        }

        .card {
            border: none;
            border-radius: 10px
        }

        img {
            max-height: 200px;
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "086f5869c49d7aaa2e8920b778dc6a87f1009e0b9289", async() => {
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
    <div class=""container mt-5 mb-3"">
        <h3>Olá, ");
#nullable restore
#line 54 "C:\Users\giova\OneDrive\Documentos\8semestre\desenvolvimento web 2\2022-09-20\achei-web\achei-web\Views\Iten\List.cshtml"
            Write(Model.Item2.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("!</h3>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "086f5869c49d7aaa2e8920b778dc6a87f1009e0b10828", async() => {
                    WriteLiteral("Criar item");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\giova\OneDrive\Documentos\8semestre\desenvolvimento web 2\2022-09-20\achei-web\achei-web\Views\Iten\List.cshtml"
                                                                          WriteLiteral(Model.Item2.id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <div class=\"row\">\r\n            <!--Início card-->\r\n            <!--Fim card-->\r\n            <!--Início card-->\r\n");
#nullable restore
#line 60 "C:\Users\giova\OneDrive\Documentos\8semestre\desenvolvimento web 2\2022-09-20\achei-web\achei-web\Views\Iten\List.cshtml"
              
                foreach (var iten in Model.Item3)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""col-md-4 mt-5"">
                        <div class=""card p-3 mb-2"">
                            <div class=""d-flex justify-content-between"">
                                <div class=""d-flex flex-row align-items-center"">
                                    <div class=""ms-2 c-details"">
                                        <h6 class=""mb-0"">Postado por: ");
#nullable restore
#line 68 "C:\Users\giova\OneDrive\Documentos\8semestre\desenvolvimento web 2\2022-09-20\achei-web\achei-web\Views\Iten\List.cshtml"
                                                                 Write(iten.student_record);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h6> <span>Há 1 dia</span>
                                    </div>
                                </div>
                            </div>
                            <div class=""mt-5"">
                                <div class=""d-flex flex-row align-items-center justify-content-center"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "086f5869c49d7aaa2e8920b778dc6a87f1009e0b15204", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2964, "~/", 2964, 2, true);
#nullable restore
#line 74 "C:\Users\giova\OneDrive\Documentos\8semestre\desenvolvimento web 2\2022-09-20\achei-web\achei-web\Views\Iten\List.cshtml"
AddHtmlAttributeValue("", 2966, iten.image_path, 2966, 16, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                                <h3 class=\"heading\">");
#nullable restore
#line 76 "C:\Users\giova\OneDrive\Documentos\8semestre\desenvolvimento web 2\2022-09-20\achei-web\achei-web\Views\Iten\List.cshtml"
                                               Write(iten.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                                <div class=\"d-flex flex-row align-items-center justify-content-center\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "086f5869c49d7aaa2e8920b778dc6a87f1009e0b17515", async() => {
                    WriteLiteral("Ver mais");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\giova\OneDrive\Documentos\8semestre\desenvolvimento web 2\2022-09-20\achei-web\achei-web\Views\Iten\List.cshtml"
                                                                                                                 WriteLiteral(iten.id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 80 "C:\Users\giova\OneDrive\Documentos\8semestre\desenvolvimento web 2\2022-09-20\achei-web\achei-web\Views\Iten\List.cshtml"
                                      
                                        if (@Model.Item1[0].student_record == @iten.student_record)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "086f5869c49d7aaa2e8920b778dc6a87f1009e0b20943", async() => {
                    WriteLiteral("Editar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\giova\OneDrive\Documentos\8semestre\desenvolvimento web 2\2022-09-20\achei-web\achei-web\Views\Iten\List.cshtml"
                                                                                                                              WriteLiteral(iten.id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 84 "C:\Users\giova\OneDrive\Documentos\8semestre\desenvolvimento web 2\2022-09-20\achei-web\achei-web\Views\Iten\List.cshtml"
                                        }
                                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 91 "C:\Users\giova\OneDrive\Documentos\8semestre\desenvolvimento web 2\2022-09-20\achei-web\achei-web\Views\Iten\List.cshtml"
                }
            

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            <!--Fim card-->
            <!--Início card-->
            <!--<div class=""col-md-4 mt-5"">
        <div class=""card p-3 mb-2"">
            <div class=""d-flex justify-content-between"">
                <div class=""d-flex flex-row align-items-center"">
                    <div class=""ms-2 c-details"">
                        <h6 class=""mb-0"">Postado por: Maria</h6> <span>Há 1 dia</span>
                    </div>
                </div>
            </div>

            <div class=""mt-5"">
                <div class=""d-flex flex-row align-items-center justify-content-center"">
                    <img src=""fotos/carteira.jpg"" class=""img-fluid"" alt="""">
                </div>
                <h3 class=""heading"">Carteira</h3>
                <div class=""d-flex flex-row align-items-center justify-content-center"">
                    <a href=""pagina_item.html"" type=""button"" class=""btn btn-primary"">Ver mais</a>
                </div>
            </div>
        </div>
    </div>-->
       ");
                WriteLiteral(@"     <!--Fim card-->
            <!--Início card-->
            <!--<div class=""col-md-4 mt-5"">
        <div class=""card p-3 mb-2"">
            <div class=""d-flex justify-content-between"">
                <div class=""d-flex flex-row align-items-center"">
                    <div class=""ms-2 c-details"">
                        <h6 class=""mb-0"">Postado por: Maria</h6> <span>Há 1 dia</span>
                    </div>
                </div>
            </div>
            <div class=""mt-5"">
                <div class=""d-flex flex-row align-items-center justify-content-center"">
                    <img src=""fotos/garrafa.jpg"" class=""img-fluid"" alt="""">
                </div>
                <h3 class=""heading"">Garrafa</h3>
                <div class=""d-flex flex-row align-items-center justify-content-center"">
                    <a href=""pagina_item.html"" type=""button"" class=""btn btn-primary"">Ver mais</a>
                </div>
            </div>
        </div>
    </div>-->
            <!--Fim ");
                WriteLiteral(@"card-->
            <!--Início card-->
            <!--<div class=""col-md-4 mt-5"">
        <div class=""card p-3 mb-2"">
            <div class=""d-flex justify-content-between"">
                <div class=""d-flex flex-row align-items-center"">
                    <div class=""ms-2 c-details"">
                        <h6 class=""mb-0"">Postado por: Maria</h6> <span>Há 1 dia</span>
                    </div>
                </div>
            </div>

            <div class=""mt-5"">
                <div class=""d-flex flex-row align-items-center justify-content-center"">
                    <img src=""fotos/mouse.webp"" class=""img-fluid"" alt="""">
                </div>
                <h3 class=""heading"">Mouse</h3>
                <div class=""d-flex flex-row align-items-center justify-content-center"">
                    <a href=""pagina_item.html"" type=""button"" class=""btn btn-primary"">Ver mais</a>
                </div>
            </div>
        </div>
    </div>-->
            <!--Fim card-->
     ");
                WriteLiteral(@"       <!--Início card-->
            <!--<div class=""col-md-4 mt-5"">
        <div class=""card p-3 mb-2"">
            <div class=""d-flex justify-content-between"">
                <div class=""d-flex flex-row align-items-center"">
                    <div class=""ms-2 c-details"">
                        <h6 class=""mb-0"">Postado por: Maria</h6> <span>Há 1 dia</span>
                    </div>
                </div>
            </div>
            <div class=""mt-5"">
                <div class=""d-flex flex-row align-items-center justify-content-center"">
                    <img src=""fotos/oculos.jpg"" class=""img-fluid"" alt="""">
                </div>
                <h3 class=""heading"">Óculos</h3>
                <div class=""d-flex flex-row align-items-center justify-content-center"">
                    <a href=""pagina_item.html"" type=""button"" class=""btn btn-primary"">Ver mais</a>
                </div>
            </div>
        </div>
    </div>-->
            <!--Fim card-->

        </div>
  ");
                WriteLiteral("  </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<achei_web.Models.POJO.Student>, achei_web.Models.POJO.Person, List<achei_web.Models.POJO.Iten>>> Html { get; private set; }
    }
}
#pragma warning restore 1591