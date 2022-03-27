#pragma checksum "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Blog\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee76a833e4c868cada843d3e714c7d89e3dc55b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Details), @"mvc.1.0.view", @"/Views/Blog/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee76a833e4c868cada843d3e714c7d89e3dc55b6", @"/Views/Blog/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9d0241900b74c67b1ab47b177d7df3857318889", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebGoMarkets.Models.TinDang>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 70px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Blog\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";
    string url = $"/blogs/{Model.Alias}-{Model.PostId}.html";
    List<TinDang> RelatedBlogs = ViewBag.lsRelatedBlogs;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""main-content"">
    <div class=""breadcrumb-area breadcrumb-height"" style=""background-image: url('/assets/images/breadcrumb/bg/1-1-1920x373.jpg'); background-size: cover; background-position: center; "">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <ul>
                            <li>
                                <a href=""/"">Home <i class=""pe-7s-angle-right""></i></a>
                            </li>
                            <li>
                                <a href=""/blogs.html"">Blog list <i class=""pe-7s-angle-right""></i></a>
                            </li>
                            <li>Blog details</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""blog-area section-space-y-axis-100"">
        <div class=""container"">
          ");
            WriteLiteral(@"  <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""blog-detail-item"">
                        <div class=""blog-content text-start pb-0"">
                            <div class=""blog-meta text-dim-gray pb-3"">
                                <ul>
                                    <li class=""date""><i class=""fa fa-calendar-o me-2""></i>");
#nullable restore
#line 38 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Blog\Details.cshtml"
                                                                                     Write(Model.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                    <li>
                                        <span class=""comments me-3"">
                                            <a href=""javascript:void(0)"">2 Comments</a>
                                        </span>
                                        <span class=""link-share"">
                                            <a href=""javascript:void(0)"">Share</a>
                                        </span>
                                    </li>
                                </ul>
                            </div>
                            <h1 class=""breadcrumb-heading"">");
#nullable restore
#line 49 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Blog\Details.cshtml"
                                                      Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            <p class=\"short-desc mb-4 mb-9\">");
#nullable restore
#line 50 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Blog\Details.cshtml"
                                                       Write(Model.Scontents);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            ");
#nullable restore
#line 51 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Blog\Details.cshtml"
                       Write(Html.Raw(Model.Contents));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            <div class=""feedback-area section-space-top-55"">
                                    <h4 class=""heading mb-1"">Related blogs</h4>
                                    <div class=""widgets-area mb-9"">
                                        <div class=""widgets-item"">
                                            <div class=""swiper-container widgets-list-slider style-2 swiper-container-multirow swiper-container-initialized swiper-container-horizontal swiper-container-pointer-events"">
                                                <div class=""swiper-wrapper"" id=""swiper-wrapper-5c69d7105a0579dc2"" aria-live=""polite"" style=""width: 287px; transform: translate3d(0px, 0px, 0px);"">
");
#nullable restore
#line 58 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Blog\Details.cshtml"
                                                     if (RelatedBlogs != null && RelatedBlogs.Count() > 0)
                                                    {
                                                        foreach (var item in RelatedBlogs)
                                                        {
                                                            string _url = $"/blogs/{Model.Alias}-{Model.PostId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                            <div class=""swiper-slide swiper-slide-active"" role=""group"" aria-label=""1 / 3"" style=""width: 262px; margin-right: 25px;"">
                                                                <div class=""product-list-item"">
                                                                    <div class=""product-img img-zoom-effect"">
                                                                        <a");
            BeginWriteAttribute("href", " href=\"", 4072, "\"", 4084, 1);
#nullable restore
#line 66 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Blog\Details.cshtml"
WriteAttributeValue("", 4079, _url, 4079, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ee76a833e4c868cada843d3e714c7d89e3dc55b69825", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4213, "~/images/blogs/", 4213, 15, true);
#nullable restore
#line 67 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Blog\Details.cshtml"
AddHtmlAttributeValue("", 4228, item.Thumb, 4228, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 67 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Blog\Details.cshtml"
AddHtmlAttributeValue("", 4246, item.Title, 4246, 11, false);

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
            WriteLiteral(@"
                                                                        </a>
                                                                    </div>
                                                                    <div class=""product-content"">
                                                                        <h5 class=""title mb-3"">
                                                                            <a");
            BeginWriteAttribute("href", " href=\"", 4689, "\"", 4701, 1);
#nullable restore
#line 72 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Blog\Details.cshtml"
WriteAttributeValue("", 4696, _url, 4696, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 72 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Blog\Details.cshtml"
                                                                                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                                                        </h5>
                                                                        <div class=""blog-meta text-manatee pb-1"">
                                                                            <ul>
                                                                                <li class=""date"">");
#nullable restore
#line 76 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Blog\Details.cshtml"
                                                                                            Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                                                            </ul>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>
");
#nullable restore
#line 82 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Blog\Details.cshtml"
                                                        }
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</main>
");
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
