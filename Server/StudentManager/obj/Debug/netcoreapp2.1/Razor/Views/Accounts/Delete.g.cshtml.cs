#pragma checksum "C:\Users\Hp\Desktop\ASMEAP\Server\StudentManager\Views\Accounts\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0738850c0be2e236bfccc3aa260eb9060ed85608"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Delete), @"mvc.1.0.view", @"/Views/Accounts/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Accounts/Delete.cshtml", typeof(AspNetCore.Views_Accounts_Delete))]
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
#line 1 "C:\Users\Hp\Desktop\ASMEAP\Server\StudentManager\Views\_ViewImports.cshtml"
using StudentManager;

#line default
#line hidden
#line 2 "C:\Users\Hp\Desktop\ASMEAP\Server\StudentManager\Views\_ViewImports.cshtml"
using StudentManager.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0738850c0be2e236bfccc3aa260eb9060ed85608", @"/Views/Accounts/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ac888811f5a84fb1adbce488f4184df3fb738ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentManager.Models.Account>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Cancel"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Hp\Desktop\ASMEAP\Server\StudentManager\Views\Accounts\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(82, 481, true);
            WriteLiteral(@"<style>
    h3{
        color:red;
    }
</style>
<h2>Delete</h2>
<style>
    .avatar {
        vertical-align: middle;
        width: 100px;
        height: 100px;
        border-radius: 100%;
    }
</style>
<h3>Are you sure you want to delete this?</h3>
<div>
    <hr />
    <dl class=""dl-horizontal"">
        <dt>
            <img src=""https://www.w3schools.com/howto/img_avatar.png"" alt=""Avatar"" class=""avatar"">
        </dt>
        <dd>
            <b> ");
            EndContext();
            BeginContext(564, 40, false);
#line 28 "C:\Users\Hp\Desktop\ASMEAP\Server\StudentManager\Views\Accounts\Delete.cshtml"
           Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(604, 65, true);
            WriteLiteral("</b>\r\n        </dd>\r\n\r\n        <hr />\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(670, 41, false);
#line 33 "C:\Users\Hp\Desktop\ASMEAP\Server\StudentManager\Views\Accounts\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(711, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(755, 37, false);
#line 36 "C:\Users\Hp\Desktop\ASMEAP\Server\StudentManager\Views\Accounts\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(792, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(836, 44, false);
#line 39 "C:\Users\Hp\Desktop\ASMEAP\Server\StudentManager\Views\Accounts\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(880, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(924, 40, false);
#line 42 "C:\Users\Hp\Desktop\ASMEAP\Server\StudentManager\Views\Accounts\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(964, 114, true);
            WriteLiteral("\r\n        </dd>\r\n        <br />\r\n\r\n\r\n        <dt>\r\n            FullName\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1079, 22, false);
#line 51 "C:\Users\Hp\Desktop\ASMEAP\Server\StudentManager\Views\Accounts\Delete.cshtml"
       Write(Model.Person.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1101, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1103, 21, false);
#line 51 "C:\Users\Hp\Desktop\ASMEAP\Server\StudentManager\Views\Accounts\Delete.cshtml"
                               Write(Model.Person.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1124, 55, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>Grade</dt>\r\n        <dd>\r\n");
            EndContext();
#line 55 "C:\Users\Hp\Desktop\ASMEAP\Server\StudentManager\Views\Accounts\Delete.cshtml"
             foreach (var sg in Model.GradeStudents)
            {
                

#line default
#line hidden
            BeginContext(1265, 18, false);
#line 57 "C:\Users\Hp\Desktop\ASMEAP\Server\StudentManager\Views\Accounts\Delete.cshtml"
           Write(sg.Grade.GradeName);

#line default
#line hidden
            EndContext();
#line 57 "C:\Users\Hp\Desktop\ASMEAP\Server\StudentManager\Views\Accounts\Delete.cshtml"
                                    Write("  ");
            }

#line default
#line hidden
            BeginContext(1313, 91, true);
            WriteLiteral("        </dd>\r\n        <dt>\r\n            Address\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1405, 20, false);
#line 64 "C:\Users\Hp\Desktop\ASMEAP\Server\StudentManager\Views\Accounts\Delete.cshtml"
       Write(Model.Person.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1425, 96, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            Birthday\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1522, 16, false);
#line 71 "C:\Users\Hp\Desktop\ASMEAP\Server\StudentManager\Views\Accounts\Delete.cshtml"
       Write(Model.Person.BOD);

#line default
#line hidden
            EndContext();
            BeginContext(1538, 91, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Phone\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1630, 18, false);
#line 77 "C:\Users\Hp\Desktop\ASMEAP\Server\StudentManager\Views\Accounts\Delete.cshtml"
       Write(Model.Person.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1648, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1692, 42, false);
#line 80 "C:\Users\Hp\Desktop\ASMEAP\Server\StudentManager\Views\Accounts\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1734, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1778, 38, false);
#line 83 "C:\Users\Hp\Desktop\ASMEAP\Server\StudentManager\Views\Accounts\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1816, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(1850, 246, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74d07e0405124ac6b8e78826730e9f24", async() => {
                BeginContext(1876, 12, true);
                WriteLiteral("\r\n\r\n        ");
                EndContext();
                BeginContext(1888, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "81d273e891d44791a50307a37018553b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 89 "C:\Users\Hp\Desktop\ASMEAP\Server\StudentManager\Views\Accounts\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1924, 88, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> &nbsp;\r\n        ");
                EndContext();
                BeginContext(2012, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1875dae75da54402b0dee3cc3b0504b6", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2081, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
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
            EndContext();
            BeginContext(2096, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentManager.Models.Account> Html { get; private set; }
    }
}
#pragma warning restore 1591
