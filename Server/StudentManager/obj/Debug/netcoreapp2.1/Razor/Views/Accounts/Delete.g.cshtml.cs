#pragma checksum "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a77940ec8a66a830270eae15b0755479bb138dfe"
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
#line 1 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\_ViewImports.cshtml"
using StudentManager;

#line default
#line hidden
#line 2 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\_ViewImports.cshtml"
using StudentManager.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a77940ec8a66a830270eae15b0755479bb138dfe", @"/Views/Accounts/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ac888811f5a84fb1adbce488f4184df3fb738ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentManager.Models.Account>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(82, 450, true);
            WriteLiteral(@"
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
    <h4>Account</h4>
    <hr />
    <dl class=""dl-horizontal"">
        <dt>
            <img src=""https://www.w3schools.com/howto/img_avatar.png"" alt=""Avatar"" class=""avatar"">
        </dt>
        <dd>
            <b> ");
            EndContext();
            BeginContext(533, 40, false);
#line 25 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Delete.cshtml"
           Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(573, 65, true);
            WriteLiteral("</b>\r\n        </dd>\r\n\r\n        <hr />\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(639, 41, false);
#line 30 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(680, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(724, 37, false);
#line 33 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(761, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(805, 44, false);
#line 36 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(849, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(893, 40, false);
#line 39 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(933, 114, true);
            WriteLiteral("\r\n        </dd>\r\n        <br />\r\n\r\n\r\n        <dt>\r\n            FullName\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1048, 22, false);
#line 48 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Delete.cshtml"
       Write(Model.Person.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1070, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1072, 21, false);
#line 48 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Delete.cshtml"
                               Write(Model.Person.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1093, 55, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>Grade</dt>\r\n        <dd>\r\n");
            EndContext();
#line 52 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Delete.cshtml"
             foreach (var sg in Model.GradeStudents)
            {
                

#line default
#line hidden
            BeginContext(1234, 18, false);
#line 54 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Delete.cshtml"
           Write(sg.Grade.GradeName);

#line default
#line hidden
            EndContext();
#line 54 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Delete.cshtml"
                                    Write("  ");
            }

#line default
#line hidden
            BeginContext(1282, 91, true);
            WriteLiteral("        </dd>\r\n        <dt>\r\n            Address\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1374, 20, false);
#line 61 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Delete.cshtml"
       Write(Model.Person.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1394, 96, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            Birthday\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1491, 16, false);
#line 68 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Delete.cshtml"
       Write(Model.Person.BOD);

#line default
#line hidden
            EndContext();
            BeginContext(1507, 91, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Phone\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1599, 18, false);
#line 74 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Delete.cshtml"
       Write(Model.Person.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1617, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1661, 42, false);
#line 77 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1703, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1747, 38, false);
#line 80 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1785, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
<<<<<<< HEAD
            BeginContext(1819, 245, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96cb739b5fbf4afab334aaf446773eb7", async() => {
                BeginContext(1845, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1855, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "58f95d9213e1434e9aaef2583ae2fad3", async() => {
=======
            BeginContext(1609, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5aae10ee82e419d8efe0f03953938de", async() => {
                BeginContext(1635, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1645, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0cb1c84551334991bae528022c25bdfc", async() => {
>>>>>>> f7fb4d50cd92c2c25435ba7d5ebc4c327785c431
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 85 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1912, 80, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-info\" /> \r\n        ");
                EndContext();
<<<<<<< HEAD
                BeginContext(1992, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d661ddbe4cdf455a8a0e893bc64abb45", async() => {
                    BeginContext(2035, 12, true);
=======
                BeginContext(1765, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8599c354ef024cfe98ed49eb0c1a8b99", async() => {
                    BeginContext(1787, 12, true);
>>>>>>> f7fb4d50cd92c2c25435ba7d5ebc4c327785c431
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2051, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2064, 10, true);
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
