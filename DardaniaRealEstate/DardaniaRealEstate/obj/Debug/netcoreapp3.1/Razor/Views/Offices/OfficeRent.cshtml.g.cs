#pragma checksum "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\Offices\OfficeRent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eea39f3585fc85c6b8fd159e800dd40ccd50b2f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Offices_OfficeRent), @"mvc.1.0.view", @"/Views/Offices/OfficeRent.cshtml")]
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
#line 1 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\Offices\OfficeRent.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eea39f3585fc85c6b8fd159e800dd40ccd50b2f8", @"/Views/Offices/OfficeRent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"186ca2d7451a24817c60527958a7f3d907b610c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Offices_OfficeRent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DardaniaRealEstate.Models.Office>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary  btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\Offices\OfficeRent.cshtml"
  
    ViewData["Title"] = "ResRent";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container"">
    <table class=""table bg-light"">
        <thead>
            
                <td></td>
                <td>Price</td>
                <td>Square Meters</td>
                <td>City</td>
                <td>Location</td>
                <td></td>
             
        </thead>
        <tbody>
");
#nullable restore
#line 24 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\Offices\OfficeRent.cshtml"
             foreach (var item in Model)
            {
                if (item.Options == "Rent")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\"><img");
            BeginWriteAttribute("src", " src=\"", 764, "\"", 811, 1);
#nullable restore
#line 29 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\Offices\OfficeRent.cshtml"
WriteAttributeValue("", 770, Html.DisplayFor(modelItem => item.Photo), 770, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\" height=\"100\" /></th>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\Offices\OfficeRent.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ??? / m??</td>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\Offices\OfficeRent.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Squaremetres));

#line default
#line hidden
#nullable disable
            WriteLiteral(" m??</td>\r\n\r\n                        <td>");
#nullable restore
#line 33 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\Offices\OfficeRent.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Communes.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\Offices\OfficeRent.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eea39f3585fc85c6b8fd159e800dd40ccd50b2f87055", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\Offices\OfficeRent.cshtml"
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
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 37 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Views\Offices\OfficeRent.cshtml"

                }

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DardaniaRealEstate.Models.Office>> Html { get; private set; }
    }
}
#pragma warning restore 1591
