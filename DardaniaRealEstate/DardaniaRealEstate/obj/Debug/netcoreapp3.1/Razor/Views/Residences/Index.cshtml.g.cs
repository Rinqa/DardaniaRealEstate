#pragma checksum "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\Residences\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbb61b541a5d0c995799373e87242cee352e4b75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Residences_Index), @"mvc.1.0.view", @"/Views/Residences/Index.cshtml")]
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
#line 1 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\_ViewImports.cshtml"
using DardaniaRealEstate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\_ViewImports.cshtml"
using DardaniaRealEstate.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\Residences\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbb61b541a5d0c995799373e87242cee352e4b75", @"/Views/Residences/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"186ca2d7451a24817c60527958a7f3d907b610c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Residences_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DardaniaRealEstate.Models.Residence>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ResRent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ResSell", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Sort", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning  btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\Residences\Index.cshtml"
  
    ViewData["Title"] = "Index";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""path/to/font-awesome/css/font-awesome.min.css"">

<div class=""container"" style=""margin:auto;"">

    <div class=""row"" style=""margin-top:5%"">
        <header class=""header col-md-12"">
            <div class=""header-inner container"">
                <div class=""header"">

                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbb61b541a5d0c995799373e87242cee352e4b756027", async() => {
                WriteLiteral("Rent");
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
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbb61b541a5d0c995799373e87242cee352e4b757283", async() => {
                WriteLiteral("Sell");
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
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbb61b541a5d0c995799373e87242cee352e4b758539", async() => {
                WriteLiteral("Sort");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </header>\r\n");
#nullable restore
#line 24 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\Residences\Index.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-md"">
                <div class=""card border-warning border-1"" style=""margin-top:2%;width:20rem;margin-left:auto;margin-right:auto;"">
                    <div class=""card-body"" style=""height:25%"">
                        <img class=""card-img-top"" style=""height:220px""");
            BeginWriteAttribute("src", " src=\"", 1216, "\"", 1263, 1);
#nullable restore
#line 30 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\Residences\Index.cshtml"
WriteAttributeValue("", 1222, Html.DisplayFor(modelItem => item.Photo), 1222, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n                        <h5 class=\"card-title\">\r\n                            <div class=\"row\">\r\n                                <div class=\"col-sm-5\">\r\n                                    <h5> ");
#nullable restore
#line 34 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\Residences\Index.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" €/m² </h5>\r\n\r\n                                </div>\r\n                                <div class=\"col-sm-4\">\r\n                                    <a class=\"disable\">");
#nullable restore
#line 38 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\Residences\Index.cshtml"
                                                  Write(Html.DisplayFor(modelItem => item.Options));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>

                                </div>
                            </div>
                        </h5>
                        <h6 class=""card-title"">
                            <i class=""fa fa-map-pin"" aria-hidden=""true""></i>
                            ");
#nullable restore
#line 45 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\Residences\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Communes.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <i class=\"fa fa-map-marker\" aria-hidden=\"true\"></i>\r\n                            ");
#nullable restore
#line 47 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\Residences\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </h6>\r\n\r\n                        <p>\r\n                            <i class=\"fa fa-bed\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 52 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\Residences\Index.cshtml"
                                                                    Write(Html.DisplayFor(modelItem => item.SleepingRoom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <i class=\"fa fa-bath\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 53 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\Residences\Index.cshtml"
                                                                     Write(Html.DisplayFor(modelItem => item.Bathrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <i class=\"fa fa-home\" arial-hidden=\"ture\"></i> ");
#nullable restore
#line 54 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\Residences\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.ResidenceSpace));

#line default
#line hidden
#nullable disable
            WriteLiteral(" m²\r\n                            <i class=\"fa fa-tree\" arial-hidden=\"ture\"></i> ");
#nullable restore
#line 55 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\Residences\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.GardenSpace));

#line default
#line hidden
#nullable disable
            WriteLiteral(" m²\r\n\r\n                        </p>\r\n\r\n                        <p class=\"card-text\">Agent: ");
#nullable restore
#line 59 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\Residences\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Agents.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 59 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\Residences\Index.cshtml"
                                                                                               Write(Html.DisplayFor(modelItem => item.Agents.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbb61b541a5d0c995799373e87242cee352e4b7515579", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\Residences\Index.cshtml"
                                                                                             WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 67 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\Residences\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n   \r\n</div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DardaniaRealEstate.Models.Residence>> Html { get; private set; }
    }
}
#pragma warning restore 1591
