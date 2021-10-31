#pragma checksum "/Users/alexandro/Downloads/CasaDoCodigo/CasaDoCodigo/Views/Pedido/Carrinho.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db82264bd7967a7b9613503d1b6c6e9f47a04944"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Carrinho), @"mvc.1.0.view", @"/Views/Pedido/Carrinho.cshtml")]
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
#line 1 "/Users/alexandro/Downloads/CasaDoCodigo/CasaDoCodigo/Views/_ViewImports.cshtml"
using CasaDoCodigo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/alexandro/Downloads/CasaDoCodigo/CasaDoCodigo/Views/_ViewImports.cshtml"
using CasaDoCodigo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db82264bd7967a7b9613503d1b6c6e9f47a04944", @"/Views/Pedido/Carrinho.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f425103b9042481fbdd49f3917720d72e9a0d106", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Carrinho : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<ItemPedido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "carrossel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "resumo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/carrinho.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/alexandro/Downloads/CasaDoCodigo/CasaDoCodigo/Views/Pedido/Carrinho.cshtml"
  
    ViewData["Title"] = "Carrinho";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Meu Carrinho</h3>

<div class=""panel panel-default"">
    <div class=""panel-heading"">

        <div class=""row"">
            <div class=""col-md-6"">
                Item
            </div>
            <div class=""col-md-2 text-center"">
                Preço Unitário
            </div>
            <div class=""col-md-2 text-center"">
                Quantidade
            </div>
            <div class=""col-md-2"">
                <span class=""pull-right"">
                    Subtotal
                </span>
            </div>
        </div>
    </div>
    <div class=""panel-body"">

");
#nullable restore
#line 30 "/Users/alexandro/Downloads/CasaDoCodigo/CasaDoCodigo/Views/Pedido/Carrinho.cshtml"
         foreach (var item in Model)
        {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row row-center linha-produto\"");
            BeginWriteAttribute("item-id", " item-id=\"", 799, "\"", 817, 1);
#nullable restore
#line 33 "/Users/alexandro/Downloads/CasaDoCodigo/CasaDoCodigo/Views/Pedido/Carrinho.cshtml"
WriteAttributeValue("", 809, item.Id, 809, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"col-md-3\">\r\n                    <img class=\"img-produto-carrinho\"");
            BeginWriteAttribute("src", " src=\"", 914, "\"", 969, 3);
            WriteAttributeValue("", 920, "/images/produtos/large_", 920, 23, true);
#nullable restore
#line 35 "/Users/alexandro/Downloads/CasaDoCodigo/CasaDoCodigo/Views/Pedido/Carrinho.cshtml"
WriteAttributeValue("", 943, item.Produto.Codigo, 943, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 965, ".jpg", 965, 4, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"col-md-3\">");
#nullable restore
#line 37 "/Users/alexandro/Downloads/CasaDoCodigo/CasaDoCodigo/Views/Pedido/Carrinho.cshtml"
                                  Write(item.Produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"col-md-2 text-center\">R$ ");
#nullable restore
#line 38 "/Users/alexandro/Downloads/CasaDoCodigo/CasaDoCodigo/Views/Pedido/Carrinho.cshtml"
                                                 Write(item.PrecoUnitario);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                <div class=""col-md-2 text-center"">
                    <div class=""input-group"">
                        <span class=""input-group-btn"">
                            <button class=""btn btn-default""
                                    onclick=""carrinho.clickDecremento(this)"">
                                <span class=""glyphicon-minus""></span>
                            </button>
                        </span>
                        <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 1627, "\"", 1653, 1);
#nullable restore
#line 47 "/Users/alexandro/Downloads/CasaDoCodigo/CasaDoCodigo/Views/Pedido/Carrinho.cshtml"
WriteAttributeValue("", 1635, item.Quantidade, 1635, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                               class=""form-control text-center"" 
                               onblur=""carrinho.updateQuantidade(this)""/>
                        <span class=""input-group-btn"">
                            <button class=""btn btn-default""
                                    onclick=""carrinho.clickIncremento(this)"">
                                <span class=""glyphicon-plus""></span>
                            </button>
                        </span>
                    </div>
                </div>
                <div class=""col-md-2"">
                    R$ <span class=""pull-right"" subtotal>
                        ");
#nullable restore
#line 60 "/Users/alexandro/Downloads/CasaDoCodigo/CasaDoCodigo/Views/Pedido/Carrinho.cshtml"
                    Write(item.Quantidade * item.PrecoUnitario);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 64 "/Users/alexandro/Downloads/CasaDoCodigo/CasaDoCodigo/Views/Pedido/Carrinho.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"panel-footer\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-10\">\r\n                <span numero-itens>\r\n                    Total: ");
#nullable restore
#line 72 "/Users/alexandro/Downloads/CasaDoCodigo/CasaDoCodigo/Views/Pedido/Carrinho.cshtml"
                       Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    itens\r\n                </span>\r\n            </div>\r\n            <div class=\"col-md-2\">\r\n                Total: R$ <span class=\"pull-right\" total>\r\n                    ");
#nullable restore
#line 78 "/Users/alexandro/Downloads/CasaDoCodigo/CasaDoCodigo/Views/Pedido/Carrinho.cshtml"
                Write(Model.Sum(i => i.Quantidade * i.PrecoUnitario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"pull-right\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db82264bd7967a7b9613503d1b6c6e9f47a0494410409", async() => {
                WriteLiteral("\r\n                Adicionar Produtos\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db82264bd7967a7b9613503d1b6c6e9f47a0494411691", async() => {
                WriteLiteral("\r\n                Finalizar Pedido\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db82264bd7967a7b9613503d1b6c6e9f47a0494413101", async() => {
                    WriteLiteral("\r\n\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<ItemPedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591