#pragma checksum "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2972333c02a82c6300f11ac0920720ff89c08066"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articles_Edit), @"mvc.1.0.view", @"/Views/Articles/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2972333c02a82c6300f11ac0920720ff89c08066", @"/Views/Articles/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c91d8ec7f0f8721ab626cbbde0ab953af67b7e41", @"/Views/_ViewImports.cshtml")]
    public class Views_Articles_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Portal.Data.ViewModels.Article.ArticleAddEditViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "file", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("custom-file-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("accept", new global::Microsoft.AspNetCore.Html.HtmlString(".gif,.jpg,.jpeg,.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary fa-pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 style=\"text-align:center\">Edit article</h1>\r\n<hr />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2972333c02a82c6300f11ac0920720ff89c080666718", async() => {
                WriteLiteral("\r\n    <div class=\"col-md-12 col-sm-12 col-xs-12\">\r\n\r\n        ");
#nullable restore
#line 11 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
   Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 12 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
   Write(Html.HiddenFor(model => model.UserId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 13 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
   Write(Html.HiddenFor(model => model.CreateOn));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
         if (!Model.IsEditor)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
       Write(Html.HiddenFor(model => model.Active));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
                                                  
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"col-md-12 col-sm-12 col-xs-12\">\r\n                    <div class=\"col-md-9 col-md-6 p-4 shadow-lg  mb-5 bg-white rounded\" style=\"margin-left:130px;\">\r\n                        <div class=\"form-group\">\r\n                            ");
#nullable restore
#line 23 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
                       Write(Html.LabelFor(model => model.Title, new { @class = "control-label col-md-4 col-sm-3" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 24 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
                       Write(Html.TextBoxFor(model => model.Title, new { @class = "form-control", autocomplete = "off" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 25 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
#nullable restore
#line 28 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
                       Write(Html.LabelFor(model => model.CategoryId, new { @class = "control-label col-md-4 col-sm-3" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 29 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
                       Write(Html.DropDownListFor(model => model.CategoryId, new SelectList(Model.Categories, "Id", "Name"), "-", new { @Class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 30 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.CategoryId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
#nullable restore
#line 33 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
                       Write(Html.LabelFor(model => model.Content, new { @class = "control-label col-md-4 col-sm-3" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 34 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
                       Write(Html.TextAreaFor(model => model.Content, new { @class = "form-control", @cols = 50, @rows = 15, autocomplete = "off" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 35 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Content, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"row\" style=\"margin-left:1px;\">\r\n");
#nullable restore
#line 38 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
                             foreach (var item in Model.PhotoList)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"column\">\r\n                                    <img");
                BeginWriteAttribute("src", " src=\"", 2397, "\"", 2412, 1);
#nullable restore
#line 41 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
WriteAttributeValue("", 2403, item.Url, 2403, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Error\" width=\"100\" height=\"100\" style=\"margin:5px;\" />\r\n                                    <br />\r\n                                    <a type=\"button\"");
                BeginWriteAttribute("href", " href=\"", 2571, "\"", 2612, 3);
                WriteAttributeValue("", 2578, "javascript:deletePhoto(\'", 2578, 24, true);
#nullable restore
#line 43 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
WriteAttributeValue("", 2602, item.Id, 2602, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2610, "\')", 2610, 2, true);
                EndWriteAttribute();
                WriteLiteral(@" id=""deleteFiles"" style=""display:block;  width: 40px;height: 40px; margin-left:10px"" class=""btn btn-danger btn-xs fa-pull-right"">
                                        <i class=""fa fa-trash-o text-center""></i>
                                    </a>
                                    <br />
                                </div>
");
#nullable restore
#line 48 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </div>
                        <div class=""form-group"">
                            <div class=""custom-file  col-md-11 col-sm-11"">
                                <label id=""photo-lbl"" class=""custom-file-label"">No file selected</label>
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2972333c02a82c6300f11ac0920720ff89c0806614846", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 53 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Photos);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("multiple", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </div>
                            <div class=""col-md-1 col-sm-3"" style=""float:right;"">
                                <button type=""button"" id=""deleteAllFiles"" class=""btn btn-danger btn-xs"">
                                    <i class=""fa fa-trash-o""></i>
                                </button>
                            </div>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2972333c02a82c6300f11ac0920720ff89c0806617466", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 60 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Photos);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
#nullable restore
#line 63 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
                       Write(Html.LabelFor(model => model.Active, new { @class = "control-label col-md-2 col-sm-3" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 64 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
                             if (Model.IsEditor)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
                           Write(Html.CheckBoxFor(model => model.Active, new { @style = "width: 30px;height: 30px;" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
                                                                                                                      
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
                           Write(Html.CheckBoxFor(model => model.Active, new { @disabled = "disabled", @style = "width: 30px;height: 30px;" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
                                                                                                                                              
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>
                        <div class=""col-md-12"">
                            <div class=""btn-group "">
                                <button type=""submit"" class=""btn btn-primary fa-pull-right"">Submit</button>
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2972333c02a82c6300f11ac0920720ff89c0806621571", async() => {
                    WriteLiteral("Cancel");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"<div id=""confirm"" class=""modal hide fade"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title text-danger"">Delete photo</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <input id=""baseDeleteUrl"" type=""hidden""");
            BeginWriteAttribute("value", " value=\"", 5537, "\"", 5594, 1);
#nullable restore
#line 96 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
WriteAttributeValue("", 5545, Url.Action("DeleteArticlePhoto", "ArticlePhoto"), 5545, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
            <div class=""modal-body"">
                <p class=""text-danger"">Do you really want to delete this photo?</p>
            </div>
            <div class=""modal-footer"">
                <a id=""delete"" name=""delete"" class=""btn btn-danger"">Delete</a>
                <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Cancel</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 109 "C:\Users\lejla.begluk\source\repos\webapp\web-app-mvc\Portal.Web\Views\Articles\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <script>
        $(document).ready(function () {
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

            $('.custom-file-input').on(""change"", function () {
                var files = $(this)[0].files;
                if (files.length > 1) {
                    $('#photo-lbl').html(files.length + ' files selected');
                }
                else if (files.le");
                WriteLiteral(@"ngth == 1) {
                    $('#photo-lbl').html(files[0].name);

                }
            });
            document.getElementById('deleteAllFiles').onclick = function () {
                var file = document.getElementById(""Photos"");
                file.value = file.defaultValue;
                $('#photo-lbl').html(""No file selected"");
            }

        });

          var deletePhoto = function (Id) {
            console.log(Id)
            $(""#confirm"").modal(""show"");

            var baseDeleteUrl = $(""#baseDeleteUrl"").val();

            var fullDeleteUrl = baseDeleteUrl + ""?id="" + Id;

            $(""#delete"").attr(""href"", fullDeleteUrl);
           
        }

    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Portal.Data.ViewModels.Article.ArticleAddEditViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
