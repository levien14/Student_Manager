#pragma checksum "C:\Users\Admin\Desktop\Student_Manager\Server\StudentManager\Views\Grades\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70af3bd2d019a04d4c0f4cd11404424e5a6c50e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grades_Details), @"mvc.1.0.view", @"/Views/Grades/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Grades/Details.cshtml", typeof(AspNetCore.Views_Grades_Details))]
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
#line 1 "C:\Users\Admin\Desktop\Student_Manager\Server\StudentManager\Views\_ViewImports.cshtml"
using StudentManager;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\Student_Manager\Server\StudentManager\Views\_ViewImports.cshtml"
using StudentManager.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70af3bd2d019a04d4c0f4cd11404424e5a6c50e5", @"/Views/Grades/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ac888811f5a84fb1adbce488f4184df3fb738ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Grades_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentManager.Models.Grade>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Admin\Desktop\Student_Manager\Server\StudentManager\Views\Grades\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(81, 119, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Grade</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(201, 45, false);
#line 14 "C:\Users\Admin\Desktop\Student_Manager\Server\StudentManager\Views\Grades\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GradeName));

#line default
#line hidden
            EndContext();
            BeginContext(246, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(290, 41, false);
#line 17 "C:\Users\Admin\Desktop\Student_Manager\Server\StudentManager\Views\Grades\Details.cshtml"
       Write(Html.DisplayFor(model => model.GradeName));

#line default
#line hidden
            EndContext();
            BeginContext(331, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(375, 45, false);
#line 20 "C:\Users\Admin\Desktop\Student_Manager\Server\StudentManager\Views\Grades\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(420, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(464, 41, false);
#line 23 "C:\Users\Admin\Desktop\Student_Manager\Server\StudentManager\Views\Grades\Details.cshtml"
       Write(Html.DisplayFor(model => model.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(505, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(549, 42, false);
#line 26 "C:\Users\Admin\Desktop\Student_Manager\Server\StudentManager\Views\Grades\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(591, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(635, 38, false);
#line 29 "C:\Users\Admin\Desktop\Student_Manager\Server\StudentManager\Views\Grades\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(673, 538, true);
            WriteLiteral(@"
        </dd>

    </dl>
</div>
<br />
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""col-md-6"" style=""width:20%"">
            <fieldset>
                <legend>Subject</legend>
                <table class=""table"">
                    <thead>
                        <tr class=""success"">
                            <th scope=""col"">Subject</th>

                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>
");
            EndContext();
#line 50 "C:\Users\Admin\Desktop\Student_Manager\Server\StudentManager\Views\Grades\Details.cshtml"
                                 foreach (var su in Model.SubjectGrades)
                                {

#line default
#line hidden
            BeginContext(1320, 81, true);
            WriteLiteral("                                    <p>\r\n                                        ");
            EndContext();
            BeginContext(1402, 15, false);
#line 53 "C:\Users\Admin\Desktop\Student_Manager\Server\StudentManager\Views\Grades\Details.cshtml"
                                   Write(su.Subject.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1417, 44, true);
            WriteLiteral("\r\n                                    </p>\r\n");
            EndContext();
#line 55 "C:\Users\Admin\Desktop\Student_Manager\Server\StudentManager\Views\Grades\Details.cshtml"
                                }

#line default
#line hidden
            BeginContext(1496, 728, true);
            WriteLiteral(@"                            </td>
                        </tr>
                    </tbody>
                </table>
            </fieldset>
        </div>


        <div class=""col-md-6"" style=""width:80%;"">
            <fieldset>
                <legend>Information Student</legend>
                <table class=""table"">
                    <thead>
                        <tr class=""success"">
                            <th>FullName</th>
                            <th>Email</th>
                            <th>Address</th>
                            <th>Gender</th>
                            <th>Phone</th>

                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 79 "C:\Users\Admin\Desktop\Student_Manager\Server\StudentManager\Views\Grades\Details.cshtml"
                         foreach (var su in Model.GradeStudents)
                        {

#line default
#line hidden
            BeginContext(2317, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(2388, 27, false);
#line 82 "C:\Users\Admin\Desktop\Student_Manager\Server\StudentManager\Views\Grades\Details.cshtml"
                               Write(su.Account.Person.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2415, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2417, 26, false);
#line 82 "C:\Users\Admin\Desktop\Student_Manager\Server\StudentManager\Views\Grades\Details.cshtml"
                                                            Write(su.Account.Person.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(2443, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2487, 16, false);
#line 83 "C:\Users\Admin\Desktop\Student_Manager\Server\StudentManager\Views\Grades\Details.cshtml"
                               Write(su.Account.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2503, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2547, 25, false);
#line 84 "C:\Users\Admin\Desktop\Student_Manager\Server\StudentManager\Views\Grades\Details.cshtml"
                               Write(su.Account.Person.Address);

#line default
#line hidden
            EndContext();
            BeginContext(2572, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2616, 24, false);
#line 85 "C:\Users\Admin\Desktop\Student_Manager\Server\StudentManager\Views\Grades\Details.cshtml"
                               Write(su.Account.Person.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(2640, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2684, 23, false);
#line 86 "C:\Users\Admin\Desktop\Student_Manager\Server\StudentManager\Views\Grades\Details.cshtml"
                               Write(su.Account.Person.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(2707, 44, true);
            WriteLiteral("</td>\r\n\r\n                            </tr>\r\n");
            EndContext();
#line 89 "C:\Users\Admin\Desktop\Student_Manager\Server\StudentManager\Views\Grades\Details.cshtml"
                        }

#line default
#line hidden
            BeginContext(2778, 72, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                ");
            EndContext();
            BeginContext(2850, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "704f2fad5502448481613384a59e7994", async() => {
                BeginContext(2920, 4, true);
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
#line 92 "C:\Users\Admin\Desktop\Student_Manager\Server\StudentManager\Views\Grades\Details.cshtml"
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
            BeginContext(2928, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2946, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c8557214262486e9478922ac5459a09", async() => {
                BeginContext(2991, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            EndContext();
            BeginContext(3007, 65, true);
            WriteLiteral("\r\n            </fieldset>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentManager.Models.Grade> Html { get; private set; }
    }
}
#pragma warning restore 1591
