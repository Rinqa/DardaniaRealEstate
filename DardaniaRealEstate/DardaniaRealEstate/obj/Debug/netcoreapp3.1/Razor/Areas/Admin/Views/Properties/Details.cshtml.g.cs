#pragma checksum "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Areas\Admin\Views\Properties\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4fb8d1ab374687a2eb7d48942b0a7e2482b65c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Properties_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Properties/Details.cshtml")]
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
#line 1 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Areas\Admin\Views\_ViewImports.cshtml"
using DardaniaRealEstate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Areas\Admin\Views\_ViewImports.cshtml"
using DardaniaRealEstate.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Areas\Admin\Views\_ViewImports.cshtml"
using DardaniaRealEstate.Areas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Areas\Admin\Views\Properties\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4fb8d1ab374687a2eb7d48942b0a7e2482b65c1", @"/Areas/Admin/Views/Properties/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9b29d34a53c436d963047f757af3e34aef0845f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Properties_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DardaniaRealEstate.Models.Properties>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning float-right ml-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Areas\Admin\Views\Properties\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div style=\"margin:1%\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4fb8d1ab374687a2eb7d48942b0a7e2482b65c16495", async() => {
                WriteLiteral("Return Back");
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
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n<iframe style=\"margin:1%\"");
            BeginWriteAttribute("src", " src=\"", 394, "\"", 447, 1);
#nullable restore
#line 21 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Areas\Admin\Views\Properties\Details.cshtml"
WriteAttributeValue("", 400, Html.DisplayFor(model => model.GoogleMapsLink), 400, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"300\" width=\"100%\" style=\"border:0;\"");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 492, "\"", 510, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\"></iframe>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md\">\r\n        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 618, "\"", 660, 1);
#nullable restore
#line 25 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Areas\Admin\Views\Properties\Details.cshtml"
WriteAttributeValue("", 624, Html.DisplayFor(model=>model.Photo), 624, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n\r\n    <div class=\"col-md\">\r\n        <div class=\"row bg-light\">\r\n            <div class=\"col-sm-6\">\r\n                <h5>");
#nullable restore
#line 31 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Areas\Admin\Views\Properties\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Agents));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n            <div class=\"col-sm-6\">\r\n                <h5>\r\n                    ");
#nullable restore
#line 35 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Areas\Admin\Views\Properties\Details.cshtml"
               Write(Html.DisplayFor(model => model.Agents.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 36 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Areas\Admin\Views\Properties\Details.cshtml"
               Write(Html.DisplayFor(model => model.Agents.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h5>\r\n            </div>\r\n            <div class=\"col-sm-6\">\r\n                <h5> ");
#nullable restore
#line 40 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Areas\Admin\Views\Properties\Details.cshtml"
                Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n            <div class=\"col-sm-6\">\r\n                <h5>");
#nullable restore
#line 43 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Areas\Admin\Views\Properties\Details.cshtml"
               Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ???</h5>\r\n            </div>\r\n            <div class=\"col-sm-6\">\r\n                <h5> ");
#nullable restore
#line 46 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Areas\Admin\Views\Properties\Details.cshtml"
                Write(Html.DisplayNameFor(model => model.Squaremeters));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n            <div class=\"col-sm-6\">\r\n                <h5> ");
#nullable restore
#line 49 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Areas\Admin\Views\Properties\Details.cshtml"
                Write(Html.DisplayFor(model => model.Squaremeters));

#line default
#line hidden
#nullable disable
            WriteLiteral(" m??</h5>\r\n            </div>\r\n            <div class=\"col-sm-6\">\r\n                <h5>Location </h5>\r\n            </div>\r\n            <div class=\"col-sm-6\">\r\n                <h5>");
#nullable restore
#line 55 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Areas\Admin\Views\Properties\Details.cshtml"
               Write(Html.DisplayFor(model => model.Communes.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md\">\r\n        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 1926, "\"", 1971, 1);
#nullable restore
#line 60 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Areas\Admin\Views\Properties\Details.cshtml"
WriteAttributeValue("", 1932, Html.DisplayFor(model => model.Sketch), 1932, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n</div>\r\n<br />\r\n<footer class=\"footer col-md-12\">\r\n    <div class=\"header-inner container\">\r\n");
#nullable restore
#line 66 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Areas\Admin\Views\Properties\Details.cshtml"
         if (SignInManager.IsSignedIn(User))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4fb8d1ab374687a2eb7d48942b0a7e2482b65c113342", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Areas\Admin\Views\Properties\Details.cshtml"
                                   WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4fb8d1ab374687a2eb7d48942b0a7e2482b65c115630", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b4fb8d1ab374687a2eb7d48942b0a7e2482b65c115905", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 70 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Areas\Admin\Views\Properties\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <input type=\"submit\" value=\"Delete\" disabled class=\"btn btn-danger float-left\" />\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 73 "C:\Users\RinnqaX\Desktop\Projektet\Full-Stack\DardaniaRealEstate\DardaniaRealEstate\Areas\Admin\Views\Properties\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DardaniaRealEstate.Models.Properties> Html { get; private set; }
    }
}
#pragma warning restore 1591
