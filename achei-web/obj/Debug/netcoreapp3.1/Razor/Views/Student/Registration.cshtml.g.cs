#pragma checksum "C:\Users\giova\OneDrive\Documentos\8semestre\desenvolvimento web 2\2022-09-20\achei-web\achei-web\Views\Student\Registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d084be46b9f5d9028f9a84073c14476b9fce3eb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Registration), @"mvc.1.0.view", @"/Views/Student/Registration.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d084be46b9f5d9028f9a84073c14476b9fce3eb5", @"/Views/Student/Registration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff9ea4c0ded319976fdc96f66d9a11a60734065f", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<achei_web.Models.POJO.Course>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/logos/cat_sfundo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Logo tapt"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("course.id"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("course.id"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Registration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mx-1 mx-md-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--View tipada-->\r\n\r\n");
#nullable restore
#line 3 "C:\Users\giova\OneDrive\Documentos\8semestre\desenvolvimento web 2\2022-09-20\achei-web\achei-web\Views\Student\Registration.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\giova\OneDrive\Documentos\8semestre\desenvolvimento web 2\2022-09-20\achei-web\achei-web\Views\Student\Registration.cshtml"
  
    ViewBag.Title = "Início";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d084be46b9f5d9028f9a84073c14476b9fce3eb58023", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/css/bootstrap.min.css""
          integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
    <title>Cadastro</title>
    <style>
        body {
            background-color: rgb(255, 246, 229);
        }

        .logo {
            max-width: 30%;
            max-height: 30%;
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d084be46b9f5d9028f9a84073c14476b9fce3eb59623", async() => {
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
                                    <p class=""text-center h3 fw-bold mb-2 mx-1 mx-md-4 mt-4"">Cadastro</p>
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d084be46b9f5d9028f9a84073c14476b9fce3eb511509", async() => {
                    WriteLiteral("\r\n                                        <div class=\"d-flex flex-row align-items-center justify-content-center\">\r\n                                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d084be46b9f5d9028f9a84073c14476b9fce3eb511937", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                                        </div>
                                        <div class=""d-flex flex-row align-items-center mb-4"">
                                            <div class=""form-outline flex-fill mb-0"">
                                                <label class=""form-label"" for=""name"">Nome</label>
                                                <input type=""text"" name=""name"" id=""name"" class=""form-control"" />
                                            </div>
                                        </div>
                                        <div class=""d-flex flex-row align-items-center mb-4"">
                                            <div class=""form-outline flex-fill mb-0"">
                                                <label class=""form-label"" for=""email"">E-mail</label>
                                                <input type=""email"" id=""email"" name=""email"" class=""form-control"" />
                                            </div>
                          ");
                    WriteLiteral(@"              </div>
                                        <div class=""d-flex flex-row align-items-center mb-4"">
                                            <div class=""form-outline flex-fill mb-0"">
                                                <label class=""form-label"" for=""student_record"">Prontuário</label>
                                                <input type=""text"" id=""student_record"" name=""student_record""
                                                       class=""form-control"" />
                                            </div>
                                        </div>
                                        <div class=""d-flex flex-row align-items-center mb-4"">
                                            <div class=""form-outline flex-fill mb-0"">
                                                <label class=""form-label"" for=""password"">Senha</label>
                                                <input type=""password"" id=""password"" name=""password"" class=""form-control"" />
   ");
                    WriteLiteral(@"                                         </div>
                                        </div>
                                        <div class=""d-flex flex-row align-items-center mb-4"">
                                            <div class=""form-outline flex-fill mb-0"">
                                                <label class=""form-label"" for=""phone"">Telefone</label>
                                                <input type=""text"" id=""phone"" name=""phone""
                                                       class=""form-control"" />
                                            </div>
                                        </div>
                                        <div class=""d-flex flex-row align-items-center mb-4"">
                                            <div class=""form-outline flex-fill mb-0"">
                                                <label class=""form-label"" for=""birthday"">Data nascimento</label>
                                                <input type=""date"" id=""bi");
                    WriteLiteral(@"rthday"" name=""birthday""
                                                       class=""form-control"" />
                                            </div>
                                        </div>
                                        <div class=""d-flex flex-row align-items-center mb-4"">
                                            <div class=""form-outline flex-fill mb-0"">
                                                <label class=""form-label"" for=""course"">Curso</label>
");
                    WriteLiteral("                                                <select name=\"course.id\" id=\"course.id\">\r\n");
#nullable restore
#line 112 "C:\Users\giova\OneDrive\Documentos\8semestre\desenvolvimento web 2\2022-09-20\achei-web\achei-web\Views\Student\Registration.cshtml"
                                                      
                                                        foreach (var course in Model.Item1)
                                                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d084be46b9f5d9028f9a84073c14476b9fce3eb517701", async() => {
#nullable restore
#line 115 "C:\Users\giova\OneDrive\Documentos\8semestre\desenvolvimento web 2\2022-09-20\achei-web\achei-web\Views\Student\Registration.cshtml"
                                                                                                                  Write(course.name);

#line default
#line hidden
#nullable disable
                        WriteLiteral(" - ");
#nullable restore
#line 115 "C:\Users\giova\OneDrive\Documentos\8semestre\desenvolvimento web 2\2022-09-20\achei-web\achei-web\Views\Student\Registration.cshtml"
                                                                                                                                 Write(course.course_time);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 115 "C:\Users\giova\OneDrive\Documentos\8semestre\desenvolvimento web 2\2022-09-20\achei-web\achei-web\Views\Student\Registration.cshtml"
                                                               WriteLiteral(course.id);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 116 "C:\Users\giova\OneDrive\Documentos\8semestre\desenvolvimento web 2\2022-09-20\achei-web\achei-web\Views\Student\Registration.cshtml"
                                                        }
                                                    

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                                                </select>
                                            </div>
                                        </div> 
                                        <div class=""d-flex justify-content-center mx-4 mb-3 mb-lg-4"">
                                            <input type=""submit"" class=""btn btn-primary btn-lg"" value=""Cadastrar"" />
");
                    WriteLiteral("                                        </div>\r\n                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<achei_web.Models.POJO.Course>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
