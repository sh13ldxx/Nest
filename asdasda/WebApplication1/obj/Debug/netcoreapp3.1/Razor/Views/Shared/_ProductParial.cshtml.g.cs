#pragma checksum "C:\Users\sh13ld\Desktop\HomeTask\ManyToMany\ManyToMany\WebApplication1\WebApplication1\Views\Shared\_ProductParial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8331ed2d802b7cbe574f15f4a60e8af4609c12a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductParial), @"mvc.1.0.view", @"/Views/Shared/_ProductParial.cshtml")]
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
#line 1 "C:\Users\sh13ld\Desktop\HomeTask\ManyToMany\ManyToMany\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sh13ld\Desktop\HomeTask\ManyToMany\ManyToMany\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sh13ld\Desktop\HomeTask\ManyToMany\ManyToMany\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8331ed2d802b7cbe574f15f4a60e8af4609c12a", @"/Views/Shared/_ProductParial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dc9bdb69e3be835c01fb39ce31d0d03864af570", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__ProductParial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("add-cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sh13ld\Desktop\HomeTask\ManyToMany\ManyToMany\WebApplication1\WebApplication1\Views\Shared\_ProductParial.cshtml"
 foreach (var product in Model)
                       {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-lg-1-5 col-md-4 col-12 col-sm-6"">
                                <div class=""product-cart-wrap mb-30"">
                                    <div class=""product-img-action-wrap"">
                                        <div class=""product-img product-img-zoom"">
                                            <a href=""shop-product-right.html"">
                                                <img class=""default-img""");
            BeginWriteAttribute("src", " src=\"", 573, "\"", 671, 2);
            WriteAttributeValue("", 579, "/assets/imgs/ProductImages/", 579, 27, true);
#nullable restore
#line 9 "C:\Users\sh13ld\Desktop\HomeTask\ManyToMany\ManyToMany\WebApplication1\WebApplication1\Views\Shared\_ProductParial.cshtml"
WriteAttributeValue("", 606, product.ProdutcImages.FirstOrDefault(pi=>pi.IsFront==true).Image, 606, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 672, "\"", 678, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                <img class=\"hover-img\"");
            BeginWriteAttribute("src", " src=\"", 754, "\"", 851, 2);
            WriteAttributeValue("", 760, "/assets/imgs/ProductImages/", 760, 27, true);
#nullable restore
#line 10 "C:\Users\sh13ld\Desktop\HomeTask\ManyToMany\ManyToMany\WebApplication1\WebApplication1\Views\Shared\_ProductParial.cshtml"
WriteAttributeValue("", 787, product.ProdutcImages.FirstOrDefault(pi=>pi.IsBack==true).Image, 787, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 852, "\"", 858, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                            </a>
                                        </div>
                                        <div class=""product-action-1"">
                                            <a aria-label=""Add To Wishlist"" class=""action-btn"" href=""shop-wishlist.html""><i class=""fi-rs-heart""></i></a>
                                            <a aria-label=""Compare"" class=""action-btn"" href=""shop-compare.html""><i class=""fi-rs-shuffle""></i></a>
                                            <a aria-label=""Quick view"" class=""action-btn"" data-bs-toggle=""modal"" data-bs-target=""#quickViewModal""><i class=""fi-rs-eye""></i></a>
                                        </div>
                                        <div class=""product-badges product-badges-position product-badges-mrg"">
");
#nullable restore
#line 19 "C:\Users\sh13ld\Desktop\HomeTask\ManyToMany\ManyToMany\WebApplication1\WebApplication1\Views\Shared\_ProductParial.cshtml"
                                         if (product.StockCount == 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"hot\">Sold</span>\r\n");
#nullable restore
#line 22 "C:\Users\sh13ld\Desktop\HomeTask\ManyToMany\ManyToMany\WebApplication1\WebApplication1\Views\Shared\_ProductParial.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                    </div>
                                    <div class=""product-content-wrap"">
                                        <div class=""product-category"">
                                            <a href=""shop-grid-right.html"">");
#nullable restore
#line 28 "C:\Users\sh13ld\Desktop\HomeTask\ManyToMany\ManyToMany\WebApplication1\WebApplication1\Views\Shared\_ProductParial.cshtml"
                                                                      Write(product.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </div>\r\n                                        <h2><a href=\"shop-product-right.html\">");
#nullable restore
#line 30 "C:\Users\sh13ld\Desktop\HomeTask\ManyToMany\ManyToMany\WebApplication1\WebApplication1\Views\Shared\_ProductParial.cshtml"
                                                                         Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                                        <div class=\"product-rate-cover\">\r\n                                            <div class=\"product-rate d-inline-block\">\r\n                                                <div class=\"product-rating\"");
            BeginWriteAttribute("style", " style=\"", 2632, "\"", 2667, 2);
            WriteAttributeValue("", 2640, "width:", 2640, 6, true);
#nullable restore
#line 33 "C:\Users\sh13ld\Desktop\HomeTask\ManyToMany\ManyToMany\WebApplication1\WebApplication1\Views\Shared\_ProductParial.cshtml"
WriteAttributeValue(" ", 2646, product.Rating*20, 2647, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                                            </div>\r\n                                            <span class=\"font-small ml-5 text-muted\"> (");
#nullable restore
#line 35 "C:\Users\sh13ld\Desktop\HomeTask\ManyToMany\ManyToMany\WebApplication1\WebApplication1\Views\Shared\_ProductParial.cshtml"
                                                                                  Write(product.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span>\r\n                                        </div>\r\n");
            WriteLiteral("                                        <div class=\"product-card-bottom\">\r\n                                            <div class=\"product-price\">\r\n                                                <span>$");
#nullable restore
#line 42 "C:\Users\sh13ld\Desktop\HomeTask\ManyToMany\ManyToMany\WebApplication1\WebApplication1\Views\Shared\_ProductParial.cshtml"
                                                  Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("                                            </div>\r\n                                            <div class=\"add-cart\">\r\n                                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8331ed2d802b7cbe574f15f4a60e8af4609c12a11768", async() => {
                WriteLiteral("\r\n                        <button type=\"submit\" style=\"background-color: #7ecc57\" class=\"add btn\"><i class=\"fi-rs-shopping-cart mr-5\"></i>Add </button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\sh13ld\Desktop\HomeTask\ManyToMany\ManyToMany\WebApplication1\WebApplication1\Views\Shared\_ProductParial.cshtml"
                                                                                                                                          WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 54 "C:\Users\sh13ld\Desktop\HomeTask\ManyToMany\ManyToMany\WebApplication1\WebApplication1\Views\Shared\_ProductParial.cshtml"
                       }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
