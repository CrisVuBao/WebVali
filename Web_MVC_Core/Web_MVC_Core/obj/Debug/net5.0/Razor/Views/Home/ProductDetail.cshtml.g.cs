#pragma checksum "C:\Users\mobil\OneDrive\Máy tính\WebBanVali\Web_MVC_Core\Web_MVC_Core\Views\Home\ProductDetail.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "57d4d2b114fb86264b239013b42bb36bd1a00a4dee2e5c4b03e43058261501e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProductDetail), @"mvc.1.0.view", @"/Views/Home/ProductDetail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\mobil\OneDrive\Máy tính\WebBanVali\Web_MVC_Core\Web_MVC_Core\Views\_ViewImports.cshtml"
using Web_MVC_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mobil\OneDrive\Máy tính\WebBanVali\Web_MVC_Core\Web_MVC_Core\Views\_ViewImports.cshtml"
using Web_MVC_Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"57d4d2b114fb86264b239013b42bb36bd1a00a4dee2e5c4b03e43058261501e7", @"/Views/Home/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a6d3b87b508d61c655ed10c0878b7d20159c8dcbe560c874c1ae738539a21447", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web_MVC_Core.ViewModels.HomeProductDetailViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\mobil\OneDrive\Máy tính\WebBanVali\Web_MVC_Core\Web_MVC_Core\Views\Home\ProductDetail.cshtml"
  
    ViewData["Title"] = "ProductDetail";
    Layout = "~/Views/Shared/_LayoutOgani.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<section class=""product-details spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 col-md-6"">
                <div class=""product__details__pic"">
                    <div class=""product__details__pic__item"">
                        <img class=""product__details__pic__item--large""");
            BeginWriteAttribute("src", "\r\n                             src=\"", 494, "\"", 558, 2);
            WriteAttributeValue("", 530, "/", 530, 1, true);
#nullable restore
#line 16 "C:\Users\mobil\OneDrive\Máy tính\WebBanVali\Web_MVC_Core\Web_MVC_Core\Views\Home\ProductDetail.cshtml"
WriteAttributeValue("", 531, Model.danhMucSp.AnhDaiDien, 531, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 559, "\"", 565, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                   \r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-6 col-md-6\">\r\n                <div class=\"product__details__text\">\r\n                    <h3>");
#nullable restore
#line 23 "C:\Users\mobil\OneDrive\Máy tính\WebBanVali\Web_MVC_Core\Web_MVC_Core\Views\Home\ProductDetail.cshtml"
                   Write(Model.danhMucSp.TenSp);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                    <div class=""product__details__rating"">
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star-half-o""></i>
                        <span>(18 reviews)</span>
                    </div>
                    <div class=""product__details__price"">");
#nullable restore
#line 32 "C:\Users\mobil\OneDrive\Máy tính\WebBanVali\Web_MVC_Core\Web_MVC_Core\Views\Home\ProductDetail.cshtml"
                                                    Write(Model.danhMucSp.GiaLonNhat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <p>\r\n                        ");
#nullable restore
#line 34 "C:\Users\mobil\OneDrive\Máy tính\WebBanVali\Web_MVC_Core\Web_MVC_Core\Views\Home\ProductDetail.cshtml"
                   Write(Model.danhMucSp.GioiThieuSp);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                    <div class=""product__details__quantity"">
                        <div class=""quantity"">
                            <div class=""pro-qty"">
                                <input type=""text"" value=""1"">
                            </div>
                        </div>
                    </div>
                    <a href=""#"" class=""primary-btn"">ADD TO CARD</a>
                    <a href=""#"" class=""heart-icon""><span class=""icon_heart_alt""></span></a>
                    <ul>
                        <li><b>Availability</b> <span>In Stock</span></li>
                        <li><b>Shipping</b> <span>01 day shipping. <samp>Free pickup today</samp></span></li>
                        <li><b>Weight</b> <span>0.5 kg</span></li>
                        <li>
                            <b>Share on</b>
                            <div class=""share"">
                                <a href=""#""><i class=""fa fa-facebook""></i></a>
                             ");
            WriteLiteral(@"   <a href=""#""><i class=""fa fa-twitter""></i></a>
                                <a href=""#""><i class=""fa fa-instagram""></i></a>
                                <a href=""#""><i class=""fa fa-pinterest""></i></a>
                            </div>
                        </li>
                    </ul>
                </div>
            </div>
            <div class=""col-lg-12"">
                <div class=""product__details__tab"">
                    <ul class=""nav nav-tabs"" role=""tablist"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" data-toggle=""tab"" href=""#tabs-1"" role=""tab""
                               aria-selected=""true"">Description</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" data-toggle=""tab"" href=""#tabs-2"" role=""tab""
                               aria-selected=""false"">Information</a>
                        </li>
                        <li class=");
            WriteLiteral(@"""nav-item"">
                            <a class=""nav-link"" data-toggle=""tab"" href=""#tabs-3"" role=""tab""
                               aria-selected=""false"">Reviews <span>(1)</span></a>
                        </li>
                    </ul>
                    <div class=""tab-content"">
                        <div class=""tab-pane active"" id=""tabs-1"" role=""tabpanel"">
                            <div class=""product__details__tab__desc"">
                                <h6>Products Infomation</h6>
                                <p>
                                    ");
#nullable restore
#line 82 "C:\Users\mobil\OneDrive\Máy tính\WebBanVali\Web_MVC_Core\Web_MVC_Core\Views\Home\ProductDetail.cshtml"
                               Write(Model.danhMucSp.GioiThieuSp);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <p>\r\n                                    ");
#nullable restore
#line 85 "C:\Users\mobil\OneDrive\Máy tính\WebBanVali\Web_MVC_Core\Web_MVC_Core\Views\Home\ProductDetail.cshtml"
                               Write(Model.danhMucSp.GioiThieuSp);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                        </div>
                        <div class=""tab-pane"" id=""tabs-2"" role=""tabpanel"">
                            <div class=""product__details__tab__desc"">
                                <h6>Products Infomation</h6>
                                <p>
                                    ");
#nullable restore
#line 93 "C:\Users\mobil\OneDrive\Máy tính\WebBanVali\Web_MVC_Core\Web_MVC_Core\Views\Home\ProductDetail.cshtml"
                               Write(Model.danhMucSp.GioiThieuSp);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <p>\r\n                                    ");
#nullable restore
#line 96 "C:\Users\mobil\OneDrive\Máy tính\WebBanVali\Web_MVC_Core\Web_MVC_Core\Views\Home\ProductDetail.cshtml"
                               Write(Model.danhMucSp.GioiThieuSp);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                        </div>
                        <div class=""tab-pane"" id=""tabs-3"" role=""tabpanel"">
                            <div class=""product__details__tab__desc"">
                                <h6>Products Infomation</h6>
                                <p>
                                    ");
#nullable restore
#line 104 "C:\Users\mobil\OneDrive\Máy tính\WebBanVali\Web_MVC_Core\Web_MVC_Core\Views\Home\ProductDetail.cshtml"
                               Write(Model.danhMucSp.GioiThieuSp);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web_MVC_Core.ViewModels.HomeProductDetailViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591