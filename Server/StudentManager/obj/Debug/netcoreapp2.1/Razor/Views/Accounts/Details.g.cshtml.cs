#pragma checksum "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f92e04155fc418ea12051ad3ea1d50b154a4d6dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Details), @"mvc.1.0.view", @"/Views/Accounts/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Accounts/Details.cshtml", typeof(AspNetCore.Views_Accounts_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f92e04155fc418ea12051ad3ea1d50b154a4d6dd", @"/Views/Accounts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ac888811f5a84fb1adbce488f4184df3fb738ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentManager.Models.Account>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddGrade", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(83, 403, true);
            WriteLiteral(@"
<h2>Details</h2>
<style>
    .avatar {
        vertical-align: middle;
        width: 100px;
        height: 100px;
        border-radius: 100%;
    }
</style>
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
            BeginContext(487, 40, false);
#line 24 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Details.cshtml"
           Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(527, 64, true);
            WriteLiteral("</b>\r\n        </dd>\r\n\r\n        <hr/>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(592, 41, false);
#line 29 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(633, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(677, 37, false);
#line 32 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(714, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(758, 44, false);
#line 35 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(802, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(846, 40, false);
#line 38 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(886, 124, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <br />\r\n\r\n        \r\n        <dt>\r\n            FullName\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1011, 22, false);
#line 48 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Details.cshtml"
       Write(Model.Person.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1033, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1035, 21, false);
#line 48 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Details.cshtml"
                               Write(Model.Person.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1056, 55, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>Grade</dt>\r\n        <dd>\r\n");
            EndContext();
#line 52 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Details.cshtml"
             foreach (var sg in Model.GradeStudents)
            {
                

#line default
#line hidden
            BeginContext(1197, 18, false);
#line 54 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Details.cshtml"
           Write(sg.Grade.GradeName);

#line default
#line hidden
            EndContext();
#line 54 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Details.cshtml"
                                    Write("  ");
            }

#line default
#line hidden
            BeginContext(1245, 91, true);
            WriteLiteral("        </dd>\r\n        <dt>\r\n            Address\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1337, 20, false);
#line 61 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Details.cshtml"
       Write(Model.Person.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1357, 96, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            Birthday\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1454, 16, false);
#line 68 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Details.cshtml"
       Write(Model.Person.BOD);

#line default
#line hidden
            EndContext();
            BeginContext(1470, 91, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Phone\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1562, 18, false);
#line 74 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Details.cshtml"
       Write(Model.Person.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1580, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1626, 42, false);
#line 78 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1668, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1712, 38, false);
#line 81 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1750, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1797, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ac7f5d005bb455a973eb45b7dc58a31", async() => {
                BeginContext(1864, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 86 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1872, 7, true);
            WriteLiteral(" \r\n    ");
            EndContext();
            BeginContext(1879, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73db7dd6340c4a1aaf8d490464b33289", async() => {
                BeginContext(1950, 9, true);
                WriteLiteral("Add Grade");
                EndContext();
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
#line 87 "C:\Users\USER\Desktop\Student_Manager\Server\StudentManager\Views\Accounts\Details.cshtml"
                               WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1963, 7, true);
            WriteLiteral(" \r\n    ");
            EndContext();
            BeginContext(1970, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c01b4168646145ad876cd524fd753ac0", async() => {
                BeginContext(2013, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2029, 10, true);
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
