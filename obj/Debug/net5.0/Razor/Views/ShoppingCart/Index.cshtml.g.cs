#pragma checksum "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19fe1e62b4bf8912489d9598ca916bfd75e664cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19fe1e62b4bf8912489d9598ca916bfd75e664cd", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9d0241900b74c67b1ab47b177d7df3857318889", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebGoMarkets.ModelViews.CartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 100px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("javascript:void(0)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\ShoppingCart\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""breadcrumb-area breadcrumb-height"" style=""background-image: url('/assets/images/breadcrumb/bg/1-1-1920x373.jpg'); background-size: cover; background-position: center; "">
    <div class=""container h-100"">
        <div class=""row h-100"">
            <div class=""col-lg-12"">
                <div class=""breadcrumb-item"">
                    <h2 class=""breadcrumb-heading"">Cart</h2>
                    <ul>
                        <li>
                            <a href=""/"">Home <i class=""pe-7s-angle-right""></i></a>
                        </li>
                        <li>Cart</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""cart-area section-space-y-axis-100"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
");
#nullable restore
#line 28 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\ShoppingCart\Index.cshtml"
                 if (Model != null && Model.Count() > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19fe1e62b4bf8912489d9598ca916bfd75e664cd5587", async() => {
                WriteLiteral(@"
                        <div class=""table-content table-responsive"">
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th class=""product_remove"">Remove</th>
                                        <th class=""product-thumbnail"">Images</th>
                                        <th class=""cart-product-name"">Product</th>
                                        <th class=""product-price"">Unit Price</th>
                                        <th class=""product-quantity"">Quantity</th>
                                        <th class=""product-subtotal"">Total</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 44 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\ShoppingCart\Index.cshtml"
                                     if (Model != null && Model.Count() > 0)
                                    {
                                        foreach (var item in Model)
                                        {
                                            string url = $"/{item.product.Alias}-{item.product.ProductId}.html";

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            <tr>
                                                <td class=""product_remove"">
                                                    <a href=""javascript:void(0)"">
                                                        <input type=""button"" value=""X"" class=""removecart btn btn-primary"" data-mahh=""");
#nullable restore
#line 52 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\ShoppingCart\Index.cshtml"
                                                                                                                                Write(item.product.ProductId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" />\r\n                                                    </a>\r\n                                                </td>\r\n                                                <td class=\"product-thumbnail\">\r\n                                                    <a");
                BeginWriteAttribute("href", " href=\"", 2911, "\"", 2922, 1);
#nullable restore
#line 56 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 2918, url, 2918, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "19fe1e62b4bf8912489d9598ca916bfd75e664cd8647", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3015, "~/images/products/", 3015, 18, true);
#nullable restore
#line 57 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\ShoppingCart\Index.cshtml"
AddHtmlAttributeValue("", 3033, item.product.Thumb, 3033, 19, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 57 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\ShoppingCart\Index.cshtml"
AddHtmlAttributeValue("", 3059, item.product.Title, 3059, 19, false);

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
                WriteLiteral("\r\n                                                    </a>\r\n                                                </td>\r\n                                                <td class=\"product-name\"><a");
                BeginWriteAttribute("href", " href=\"", 3270, "\"", 3281, 1);
#nullable restore
#line 60 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 3277, url, 3277, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 60 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\ShoppingCart\Index.cshtml"
                                                                                   Write(item.product.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                                                <td class=\"product-price\"><span class=\"amount\">$");
#nullable restore
#line 61 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\ShoppingCart\Index.cshtml"
                                                                                           Write(item.product.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></td>
                                                <td class=""quantity"">
                                                    <div class=""d-flex justify-content-center"">
                                                        <input style=""width: 70px; margin:0;"" data-mahh=""");
#nullable restore
#line 64 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\ShoppingCart\Index.cshtml"
                                                                                                    Write(item.product.ProductId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-dongia=\"");
#nullable restore
#line 64 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\ShoppingCart\Index.cshtml"
                                                                                                                                          Write(item.product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" class=\"cartItem form-control\"");
                BeginWriteAttribute("value", " value=\"", 3833, "\"", 3853, 1);
#nullable restore
#line 64 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 3841, item.amount, 3841, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"1\" type=\"number\" />\r\n                                                    </div>\r\n                                                </td>\r\n                                                <td class=\"product-subtotal\"><span class=\"amount\">$");
#nullable restore
#line 67 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\ShoppingCart\Index.cshtml"
                                                                                              Write(item.TotalMoney.ToString("#,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></td>\r\n                                            </tr>\r\n");
#nullable restore
#line 69 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\ShoppingCart\Index.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                        <div class=""row"">
                            <div class=""col-12"">
                                <div class=""coupon-all"">
                                    <div class=""coupon"">
                                        <input id=""coupon_code"" class=""input-text"" name=""coupon_code""");
                BeginWriteAttribute("value", " value=\"", 4698, "\"", 4706, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Coupon code\" type=\"text\">\r\n                                        <input class=\"button mt-xxs-30\" name=\"apply_coupon\" value=\"Apply coupon\" type=\"submit\">\r\n                                    </div>\r\n");
                WriteLiteral(@"                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-5 ml-auto"">
                                <div class=""cart-page-total"">
                                    <h2>Cart totals</h2>
                                    <ul>
                                        <li>
                                            Into Money <span>$");
#nullable restore
#line 93 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\ShoppingCart\Index.cshtml"
                                                         Write(Model.Sum(x => x.TotalMoney));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                        </li>\r\n                                    </ul>\r\n");
#nullable restore
#line 96 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\ShoppingCart\Index.cshtml"
                                     if (User.Identity.IsAuthenticated)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <a href=\"/checkout.html\" class=\"btn btn-secondary btn-primary-hover\">Checkout</a>\r\n");
#nullable restore
#line 99 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\ShoppingCart\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <a href=\"/login.html?returnUrl=/checkout.html\" class=\"btn btn-secondary btn-primary-hover\">Checkout</a>\r\n");
#nullable restore
#line 103 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\ShoppingCart\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 108 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\ShoppingCart\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>There are no products in the cart.</p>\r\n");
#nullable restore
#line 112 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\ShoppingCart\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            function loadHeaderCart() {
                $(""#miniCart"").load(""/AjaxContent/HeaderCart"");
                $(""#numberCart"").load(""/AjaxContent/NumberCart"");
            }

            $("".removecart"").click(function () {
                var productid = $(this).attr(""data-mahh"");
                $.ajax({
                    url: ""api/cart/remove"",
                    type: ""POST"",
                    dataType: ""JSON"",
                    data: { productID: productid },
                    success: function (result) {
                        if (result.success) {
                            loadHeaderCart();//Reload l???i gi??? h??ng
                            window.location = ""cart.html"";
                        }
                    },
                    error: function (rs) {
                        alert(""Remove Cart Error !"");
                    }
                });
            });

            $("".cartItem"").clic");
                WriteLiteral(@"k(function () {
                var productid = $(this).attr(""data-mahh"");
                var soluong = parseInt($(this).val());
                $.ajax({
                    url: ""api/cart/update"",
                    type: ""POST"",
                    dataType: ""JSON"",
                    data: {
                        productID: productid,
                        amount: soluong
                    },
                    success: function (result) {
                        if (result.success) {
                            loadHeaderCart();//Reload l???i gi?? h??ng
                            window.location = ""cart.html"";
                        }
                    },
                    error: function (rs) {
                        alert(""C???p nh???t Cart Error !"");
                    }
                });
            });

        });
    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebGoMarkets.ModelViews.CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
