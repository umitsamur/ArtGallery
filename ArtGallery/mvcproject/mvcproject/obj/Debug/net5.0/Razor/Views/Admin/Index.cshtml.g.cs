#pragma checksum "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7af5f0857da9f8367fe37f84b6eec8b801aa5320"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7af5f0857da9f8367fe37f84b6eec8b801aa5320", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"899233e96cc852233039d0981f740e8b0d2d7dc6", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<mvcproject.Models.ArtWork>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-block "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Admin\Index.cshtml"
   
    ViewBag.Title = "Product List";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7af5f0857da9f8367fe37f84b6eec8b801aa53204008", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    Title\r\n                    <!--\r\n                    ");
            WriteLiteral("@Html.DisplayNameFor(model => model.title)\r\n                    -->\r\n                </th>\r\n                <th>\r\n                    Category Name\r\n                    <!--\r\n                    ");
            WriteLiteral("@Html.DisplayNameFor(model => model.category_id)\r\n                    -->\r\n                </th>\r\n                <th>\r\n                    Price\r\n                    <!--\r\n                    ");
            WriteLiteral("@Html.DisplayNameFor(model => model.price)\r\n                    -->\r\n                </th>\r\n                <th>\r\n                    File Location\r\n                    <!--\r\n                    ");
            WriteLiteral("@Html.DisplayNameFor(model => model.file_location)\r\n                    -->\r\n                </th>\r\n                <th>\r\n                    User Name\r\n                    <!--\r\n                    ");
            WriteLiteral("@Html.DisplayNameFor(model => model.user_id)\r\n                    -->\r\n                </th>\r\n                <th>\r\n                    Product Explanation\r\n                    <!--\r\n                    ");
            WriteLiteral("@Html.DisplayNameFor(model => model.product_explanation)\r\n                    -->\r\n                </th>\r\n                <th>Operation</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 51 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Admin\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 55 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Admin\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 58 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Admin\Index.cshtml"
                         foreach (var category in item.Categories)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Admin\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => category.cName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Admin\Index.cshtml"
                                                                         
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 66 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Admin\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL\r\n                    </td>\r\n                    <td>\r\n                        <img class=\"card-img-top\" style=\"width:130px;height:130px;\"");
            BeginWriteAttribute("src", " src=\"", 2296, "\"", 2321, 1);
#nullable restore
#line 69 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Admin\Index.cshtml"
WriteAttributeValue("", 2302, item.file_location, 2302, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 72 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Admin\Index.cshtml"
                         foreach(var user in item.Users)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Admin\Index.cshtml"
               Write(Html.DisplayFor(modelItem => user.name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Admin\Index.cshtml"
                                                            
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 79 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Admin\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.product_explanation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 82 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Admin\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id = item.art_id }, new { @class = "btn btn-success btn-block" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <!--");
            WriteLiteral("@Html.ActionLink(\"Details\", \"Details\", new { /* id=item.PrimaryKey */ }) |-->\r\n                        ");
#nullable restore
#line 84 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Admin\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { id = item.art_id }, new { onclick = "return confirm('Are you sure want to delete ?')", @class = "btn btn-danger btn-block" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 87 "C:\Users\DELL\Desktop\proje\mvcproject\mvcproject\mvcproject\Views\Admin\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<mvcproject.Models.ArtWork>> Html { get; private set; }
    }
}
#pragma warning restore 1591
