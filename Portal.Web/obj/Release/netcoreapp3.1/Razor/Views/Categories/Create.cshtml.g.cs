#pragma checksum "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Categories\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9b57148852b5328217b86765393f4f8fb4c1b5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Create), @"mvc.1.0.view", @"/Views/Categories/Create.cshtml")]
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
#line 1 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\_ViewImports.cshtml"
using Portal.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\_ViewImports.cshtml"
using Portal.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9b57148852b5328217b86765393f4f8fb4c1b5a", @"/Views/Categories/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c91d8ec7f0f8721ab626cbbde0ab953af67b7e41", @"/Views/_ViewImports.cshtml")]
    public class Views_Categories_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Portal.Data.ViewModels.Category.CategoryViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Categories\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"text-align:center\">New Category</h1>\r\n<hr />\r\n<br />\r\n<div class=\"col-md-12 col-sm-12 col-xs-12\">\r\n    <div class=\"col-md-12\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9b57148852b5328217b86765393f4f8fb4c1b5a5678", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9b57148852b5328217b86765393f4f8fb4c1b5a5948", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 14 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Categories\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            <div class=""col-md-12 col-sm-12 col-xs-12"">
                <div class=""col-md-6 shadow-lg  mb-5 bg-white rounded"" style=""margin:auto;"">
                    <br /><br />
                    <div class=""form-group"">
                        ");
#nullable restore
#line 19 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Categories\Create.cshtml"
                   Write(Html.LabelFor(model => model.Name, new { @class = "control-label col-md-2 col-sm-3" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <div class=\"col-md-8 col-sm-4\">\r\n                            ");
#nullable restore
#line 21 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Categories\Create.cshtml"
                       Write(Html.TextBoxFor(model => model.Name, new { @class = "form-control", autocomplete = "off" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 22 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Categories\Create.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 26 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Categories\Create.cshtml"
                   Write(Html.LabelFor(model => model.Active, new { @class = "control-label col-md-2 col-sm-3" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Categories\Create.cshtml"
                         if (Model.IsEditor)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Categories\Create.cshtml"
                       Write(Html.CheckBoxFor(model => model.Active, new { @style = "width: 30px;height: 30px;" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Categories\Create.cshtml"
                                                                                                                  
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Categories\Create.cshtml"
                       Write(Html.CheckBoxFor(model => model.Active, new { @disabled = "disabled", @style = "width: 30px;height: 30px;" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Categories\Create.cshtml"
                                                                                                                                          
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"button-group fa-pull-right\" style=\"margin-left:15px;\">\r\n                        <button type=\"submit\" value=\"Create\" class=\"btn btn-primary\">Submit</button>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9b57148852b5328217b86765393f4f8fb4c1b5a11425", async() => {
                    WriteLiteral("Cancel");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                    </div>\r\n                    <br /><br />\r\n                </div>\r\n            </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
    <script>
        $('input[type=text], input[type=password], input[type=email], input[type=tel], select, textarea').each(function () {
            var req = $(this).attr('data-val-required');
            if (undefined != req) {
                var label = $('label[for=""' + $(this).attr('name') + '""]');
                if (label.length == 0) {
                    label = $(this).parent().parent().children(""label"");
                }
                var text = label.text();
                if (text.length > 0) {
                    if (!text.includes(""*"")) {
                        label.append('<span>*</span>');
                    }
                }
            }
        });
    </script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Portal.Data.ViewModels.Category.CategoryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
