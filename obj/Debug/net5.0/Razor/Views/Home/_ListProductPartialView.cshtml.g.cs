#pragma checksum "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Home\_ListProductPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e33262820f3d1fc04c8b39f6244e3eb59cc12594"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__ListProductPartialView), @"mvc.1.0.view", @"/Views/Home/_ListProductPartialView.cshtml")]
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
#line 1 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\_ViewImports.cshtml"
using WebGoMarkets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\_ViewImports.cshtml"
using WebGoMarkets.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e33262820f3d1fc04c8b39f6244e3eb59cc12594", @"/Views/Home/_ListProductPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9d0241900b74c67b1ab47b177d7df3857318889", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__ListProductPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 200px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Home\_ListProductPartialView.cshtml"
 if (Model != null && Model.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"product-item-wrap row\">\r\n");
#nullable restore
#line 5 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Home\_ListProductPartialView.cshtml"
         foreach (var item in Model)
        {
            string url = $"/{item.Alias}-{item.ProductId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-xl-3 col-lg-4 col-sm-6\">\r\n                <div class=\"product-item\">\r\n                    <div class=\"product-img img-zoom-effect\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 408, "\"", 419, 1);
#nullable restore
#line 11 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Home\_ListProductPartialView.cshtml"
WriteAttributeValue("", 415, url, 415, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e33262820f3d1fc04c8b39f6244e3eb59cc125945075", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 501, "~/images/products/", 501, 18, true);
#nullable restore
#line 12 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Home\_ListProductPartialView.cshtml"
AddHtmlAttributeValue("", 519, item.Thumb, 519, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 12 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Home\_ListProductPartialView.cshtml"
AddHtmlAttributeValue("", 537, item.Title, 537, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </a>\r\n                        <div class=\"product-add-action\">\r\n                            <ul>\r\n                                <li>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 750, "\"", 761, 1);
#nullable restore
#line 17 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Home\_ListProductPartialView.cshtml"
WriteAttributeValue("", 757, url, 757, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        <i class=""pe-7s-cart""></i>
                                    </a>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class=""product-content"">
                        <a class=""product-name""");
            BeginWriteAttribute("href", " href=\"", 1107, "\"", 1118, 1);
#nullable restore
#line 25 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Home\_ListProductPartialView.cshtml"
WriteAttributeValue("", 1114, url, 1114, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 25 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Home\_ListProductPartialView.cshtml"
                                                       Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <div class=\"price-box pb-1\">\r\n                            <span class=\"new-price\">$");
#nullable restore
#line 27 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Home\_ListProductPartialView.cshtml"
                                                Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 32 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Home\_ListProductPartialView.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 34 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Home\_ListProductPartialView.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
