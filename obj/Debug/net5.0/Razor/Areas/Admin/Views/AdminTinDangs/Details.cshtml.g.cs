#pragma checksum "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Areas\Admin\Views\AdminTinDangs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36a9dbe6399b6076df9d046ea9cc0d97cf4b8b4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminTinDangs_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminTinDangs/Details.cshtml")]
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
#line 1 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Areas\Admin\Views\_ViewImports.cshtml"
using WebGoMarkets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Areas\Admin\Views\_ViewImports.cshtml"
using WebGoMarkets.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36a9dbe6399b6076df9d046ea9cc0d97cf4b8b4b", @"/Areas/Admin/Views/AdminTinDangs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9d0241900b74c67b1ab47b177d7df3857318889", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminTinDangs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebGoMarkets.Models.TinDang>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("breadcrumb-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminTinDangs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Areas\Admin\Views\AdminTinDangs\Details.cshtml"
  
    ViewData["Title"] = "Blog infomation: " + Model.Title;
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"Blog-header\">\r\n    <div class=\"header-sub-title\">\r\n        <nav class=\"breadcrumb breadcrumb-dash\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36a9dbe6399b6076df9d046ea9cc0d97cf4b8b4b6105", async() => {
                WriteLiteral("<i class=\"anticon anticon-home m-r-5\"></i>Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36a9dbe6399b6076df9d046ea9cc0d97cf4b8b4b7803", async() => {
                WriteLiteral("Blog list");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <span class=""breadcrumb-item active"">Blog infomation</span>
        </nav>
    </div>
</div>

<div class=""Blog-header no-gutters has-tab"">
    <div class=""d-md-flex m-b-15 align-items-center justify-content-between"">
        <div class=""media align-items-center m-b-15"">
            <div class=""avatar avatar-image rounded"" style=""height: 70px; width: 70px"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "36a9dbe6399b6076df9d046ea9cc0d97cf4b8b4b9857", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 962, "~/images/blogs/", 962, 15, true);
#nullable restore
#line 23 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Areas\Admin\Views\AdminTinDangs\Details.cshtml"
AddHtmlAttributeValue("", 977, Model.Thumb, 977, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 23 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Areas\Admin\Views\AdminTinDangs\Details.cshtml"
AddHtmlAttributeValue("", 996, Model.Title, 996, 12, false);

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
            WriteLiteral("\r\n            </div>\r\n            <div class=\"m-l-15\">\r\n                <h4 class=\"m-b-0\">");
#nullable restore
#line 26 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Areas\Admin\Views\AdminTinDangs\Details.cshtml"
                             Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <p class=\"text-muted m-b-0\">ID: #");
#nullable restore
#line 27 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Areas\Admin\Views\AdminTinDangs\Details.cshtml"
                                            Write(Model.PostId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"m-b-15\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36a9dbe6399b6076df9d046ea9cc0d97cf4b8b4b12636", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Areas\Admin\Views\AdminTinDangs\Details.cshtml"
                                                                                                           WriteLiteral(Model.PostId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
    <ul class=""nav nav-tabs"">
        <li class=""nav-item"">
            <a class=""nav-link active"" data-toggle=""tab"" href=""#Blog-overview"">Overview</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-toggle=""tab"" href=""#Blog-content"">Content</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-toggle=""tab"" href=""#Blog-images"">Blog Images</a>
        </li>
    </ul>
</div>
<div class=""container-fluid"">
    <div class=""tab-content m-t-15"">
        <div class=""tab-pane fade show active"" id=""Blog-overview"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""table-responsive"">
                        <table class=""product-info-table"">
                            <tbody>
                                <tr>
                                    <td>Blog Name:</td>
                                    <td class=""text-dark font-weight-semibold"">");
#nullable restore
#line 56 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Areas\Admin\Views\AdminTinDangs\Details.cshtml"
                                                                          Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>Alias:</td>\r\n                                    <td>");
#nullable restore
#line 60 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Areas\Admin\Views\AdminTinDangs\Details.cshtml"
                                   Write(Model.Alias);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>Date Created:</td>\r\n                                    <td>");
#nullable restore
#line 64 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Areas\Admin\Views\AdminTinDangs\Details.cshtml"
                                   Write(Model.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>Public:</td>\r\n                                    <td>\r\n                                        <div class=\"checkbox\">\r\n");
#nullable restore
#line 70 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Areas\Admin\Views\AdminTinDangs\Details.cshtml"
                                             if (Model.Published)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <div class=""d-flex align-items-center"">
                                                    <div class=""switch d-inline m-r-10"">
                                                        <input type=""checkbox""");
            BeginWriteAttribute("disabled", " disabled=\"", 3428, "\"", 3439, 0);
            EndWriteAttribute();
            BeginWriteAttribute("checked", " checked=\"", 3440, "\"", 3450, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        <label></label>\r\n                                                    </div>\r\n                                                </div>\r\n");
#nullable restore
#line 78 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Areas\Admin\Views\AdminTinDangs\Details.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"d-flex align-items-center\">\r\n                                                    <div class=\"switch m-r-10\">\r\n                                                        <input type=\"checkbox\"");
            BeginWriteAttribute("disabled", " disabled=\"", 4035, "\"", 4046, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        <label></label>\r\n                                                    </div>\r\n                                                </div>\r\n");
#nullable restore
#line 87 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Areas\Admin\Views\AdminTinDangs\Details.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </div>
                                    </td>
                                <tr>
                                    <td>Is Hot:</td>
                                    <td>
                                        <div class=""checkbox"">
");
#nullable restore
#line 94 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Areas\Admin\Views\AdminTinDangs\Details.cshtml"
                                             if (Model.IsHot)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <div class=""d-flex align-items-center"">
                                                    <div class=""switch d-inline m-r-10"">
                                                        <input type=""checkbox""");
            BeginWriteAttribute("disabled", " disabled=\"", 4942, "\"", 4953, 0);
            EndWriteAttribute();
            BeginWriteAttribute("checked", " checked=\"", 4954, "\"", 4964, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        <label></label>\r\n                                                    </div>\r\n                                                </div>\r\n");
#nullable restore
#line 102 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Areas\Admin\Views\AdminTinDangs\Details.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"d-flex align-items-center\">\r\n                                                    <div class=\"switch m-r-10\">\r\n                                                        <input type=\"checkbox\"");
            BeginWriteAttribute("disabled", " disabled=\"", 5549, "\"", 5560, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        <label></label>\r\n                                                    </div>\r\n                                                </div>\r\n");
#nullable restore
#line 111 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Areas\Admin\Views\AdminTinDangs\Details.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </div>
                                    </td>
                                <tr>
                                    <td>Is New:</td>
                                    <td>
                                        <div class=""checkbox"">
");
#nullable restore
#line 118 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Areas\Admin\Views\AdminTinDangs\Details.cshtml"
                                             if (Model.IsNewfeed)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <div class=""d-flex align-items-center"">
                                                    <div class=""switch d-inline m-r-10"">
                                                        <input type=""checkbox""");
            BeginWriteAttribute("disabled", " disabled=\"", 6460, "\"", 6471, 0);
            EndWriteAttribute();
            BeginWriteAttribute("checked", " checked=\"", 6472, "\"", 6482, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        <label></label>\r\n                                                    </div>\r\n                                                </div>\r\n");
#nullable restore
#line 126 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Areas\Admin\Views\AdminTinDangs\Details.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"d-flex align-items-center\">\r\n                                                    <div class=\"switch m-r-10\">\r\n                                                        <input type=\"checkbox\"");
            BeginWriteAttribute("disabled", " disabled=\"", 7067, "\"", 7078, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        <label></label>\r\n                                                    </div>\r\n                                                </div>\r\n");
#nullable restore
#line 135 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Areas\Admin\Views\AdminTinDangs\Details.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </div>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
        <div class=""tab-pane fade"" id=""Blog-content"">
            <div class=""card"">
                <div class=""card-body"">
                    ");
#nullable restore
#line 148 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Areas\Admin\Views\AdminTinDangs\Details.cshtml"
               Write(Html.Raw(Model.Contents));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""tab-pane fade"" id=""Blog-images"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <img class=""img-fluid""");
            BeginWriteAttribute("src", " src=\"", 8108, "\"", 8140, 2);
            WriteAttributeValue("", 8114, "/images/blogs/", 8114, 14, true);
#nullable restore
#line 157 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Areas\Admin\Views\AdminTinDangs\Details.cshtml"
WriteAttributeValue("", 8128, Model.Thumb, 8128, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 8141, "\"", 8159, 1);
#nullable restore
#line 157 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Areas\Admin\Views\AdminTinDangs\Details.cshtml"
WriteAttributeValue("", 8147, Model.Title, 8147, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebGoMarkets.Models.TinDang> Html { get; private set; }
    }
}
#pragma warning restore 1591
