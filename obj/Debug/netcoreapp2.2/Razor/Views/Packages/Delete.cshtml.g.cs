#pragma checksum "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Packages\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "160d7e67af3b9f8589cf07500268d3d5a59eb1ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Packages_Delete), @"mvc.1.0.view", @"/Views/Packages/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Packages/Delete.cshtml", typeof(AspNetCore.Views_Packages_Delete))]
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
#line 1 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\_ViewImports.cshtml"
using TeamLID.TravelExperts.App;

#line default
#line hidden
#line 2 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\_ViewImports.cshtml"
using TeamLID.TravelExperts.App.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"160d7e67af3b9f8589cf07500268d3d5a59eb1ab", @"/Views/Packages/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfc5dd6d3fd7f789f6f56895dee830dc59aecabd", @"/Views/_ViewImports.cshtml")]
    public class Views_Packages_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeamLID.TravelExperts.Repository.Domain.Packages>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(56, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Packages\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(96, 169, true);
            WriteLiteral("\n<h1>Delete</h1>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>Packages</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(266, 43, false);
#line 15 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Packages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PkgName));

#line default
#line hidden
            EndContext();
            BeginContext(309, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(370, 39, false);
#line 18 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Packages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PkgName));

#line default
#line hidden
            EndContext();
            BeginContext(409, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(469, 48, false);
#line 21 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Packages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PkgStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(517, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(578, 44, false);
#line 24 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Packages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PkgStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(622, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(682, 46, false);
#line 27 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Packages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PkgEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(728, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(789, 42, false);
#line 30 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Packages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PkgEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(831, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(891, 43, false);
#line 33 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Packages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PkgDesc));

#line default
#line hidden
            EndContext();
            BeginContext(934, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(995, 39, false);
#line 36 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Packages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PkgDesc));

#line default
#line hidden
            EndContext();
            BeginContext(1034, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1094, 48, false);
#line 39 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Packages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PkgBasePrice));

#line default
#line hidden
            EndContext();
            BeginContext(1142, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1203, 44, false);
#line 42 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Packages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PkgBasePrice));

#line default
#line hidden
            EndContext();
            BeginContext(1247, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1307, 55, false);
#line 45 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Packages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PkgAgencyCommission));

#line default
#line hidden
            EndContext();
            BeginContext(1362, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1423, 51, false);
#line 48 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Packages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PkgAgencyCommission));

#line default
#line hidden
            EndContext();
            BeginContext(1474, 34, true);
            WriteLiteral("\n        </dd>\n    </dl>\n    \n    ");
            EndContext();
            BeginContext(1508, 209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "160d7e67af3b9f8589cf07500268d3d5a59eb1ab11120", async() => {
                BeginContext(1534, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(1543, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "160d7e67af3b9f8589cf07500268d3d5a59eb1ab11510", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 53 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Packages\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PackageId);

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
                BeginContext(1586, 81, true);
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\n        ");
                EndContext();
                BeginContext(1667, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "160d7e67af3b9f8589cf07500268d3d5a59eb1ab13487", async() => {
                    BeginContext(1689, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1705, 5, true);
                WriteLiteral("\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1717, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeamLID.TravelExperts.Repository.Domain.Packages> Html { get; private set; }
    }
}
#pragma warning restore 1591