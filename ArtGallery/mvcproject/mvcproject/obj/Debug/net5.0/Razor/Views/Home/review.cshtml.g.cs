#pragma checksum "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Home\review.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16eb0113a21a6accab55905b17c008f4afc1bce5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_review), @"mvc.1.0.view", @"/Views/Home/review.cshtml")]
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
#line 1 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\_ViewImports.cshtml"
using mvcproject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\_ViewImports.cshtml"
using mvcproject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16eb0113a21a6accab55905b17c008f4afc1bce5", @"/Views/Home/review.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"899233e96cc852233039d0981f740e8b0d2d7dc6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_review : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<mvcproject.Models.ArtWork>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row justify-content-center\">\r\n    <div class=\"col-md-7 col-lg-4 mb-5 mb-lg-0 wow fadeIn\">\r\n        <div class=\"card border-0 shadow\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 199, "\"", 225, 1);
#nullable restore
#line 6 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Home\review.cshtml"
WriteAttributeValue("", 205, Model.file_location, 205, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 7 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Home\review.cshtml"
             foreach (var users in Model.Users)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card-body p-1-9 p-xl-5\">\r\n                    <div class=\"mb-4\">\r\n                        <h3 class=\"h4 mb-0\">");
#nullable restore
#line 11 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Home\review.cshtml"
                                       Write(users.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Home\review.cshtml"
                                                   Write(users.surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Home\review.cshtml"
                                                                  Write(users.age);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        <span class=""text-primary"">Artist</span>
                    </div>
                    <ul class=""list-unstyled mb-4"">

                        <li class=""mb-3""><i class=""far fa-envelope display-25 me-3 text-secondary""></i>  ");
#nullable restore
#line 16 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Home\review.cshtml"
                                                                                                    Write(users.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li class=\"mb-3\"><i class=\"fas fa-mobile-alt display-25 me-3 text-secondary\"></i>  ");
#nullable restore
#line 17 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Home\review.cshtml"
                                                                                                      Write(users.phone_number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><i class=\"fas fa-map-marker-alt display-25 me-3 text-secondary\"></i>  ");
#nullable restore
#line 18 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Home\review.cshtml"
                                                                                             Write(users.street);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 18 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Home\review.cshtml"
                                                                                                           Write(users.city);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 18 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Home\review.cshtml"
                                                                                                                       Write(users.country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n                    </ul>\r\n                </div>\r\n");
#nullable restore
#line 22 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Home\review.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>

    <div class=""col-lg-8"">
        <div class=""ps-lg-1-6 ps-xl-5"">
            <div class=""mb-5 wow fadeIn"">
                <div class=""text-start mb-1-6 wow fadeIn"">
                    <h2 class=""h1 mb-0"" style=""color: #566573"" >Product Explanation</h2>
                </div>
                <p>");
#nullable restore
#line 32 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Home\review.cshtml"
              Write(Model.product_explanation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Home\review.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<mvcproject.Models.ArtWork> Html { get; private set; }
    }
}
#pragma warning restore 1591