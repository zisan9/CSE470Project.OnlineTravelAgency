#pragma checksum "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e6ad718f8cbbd7f8c1357a74d335e782fe75ffa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Delete), @"mvc.1.0.view", @"/Views/Customers/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customers/Delete.cshtml", typeof(AspNetCore.Views_Customers_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e6ad718f8cbbd7f8c1357a74d335e782fe75ffa", @"/Views/Customers/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfc5dd6d3fd7f789f6f56895dee830dc59aecabd", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeamLID.TravelExperts.Repository.Domain.Customers>
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
            BeginContext(57, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(97, 170, true);
            WriteLiteral("\n<h1>Delete</h1>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>Customers</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(268, 49, false);
#line 15 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(317, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(378, 45, false);
#line 18 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(423, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(483, 48, false);
#line 21 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustLastName));

#line default
#line hidden
            EndContext();
            BeginContext(531, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(592, 44, false);
#line 24 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustLastName));

#line default
#line hidden
            EndContext();
            BeginContext(636, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(696, 47, false);
#line 27 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustAddress));

#line default
#line hidden
            EndContext();
            BeginContext(743, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(804, 43, false);
#line 30 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustAddress));

#line default
#line hidden
            EndContext();
            BeginContext(847, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(907, 44, false);
#line 33 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustCity));

#line default
#line hidden
            EndContext();
            BeginContext(951, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1012, 40, false);
#line 36 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustCity));

#line default
#line hidden
            EndContext();
            BeginContext(1052, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1112, 44, false);
#line 39 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustProv));

#line default
#line hidden
            EndContext();
            BeginContext(1156, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1217, 40, false);
#line 42 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustProv));

#line default
#line hidden
            EndContext();
            BeginContext(1257, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1317, 46, false);
#line 45 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustPostal));

#line default
#line hidden
            EndContext();
            BeginContext(1363, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1424, 42, false);
#line 48 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustPostal));

#line default
#line hidden
            EndContext();
            BeginContext(1466, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1526, 47, false);
#line 51 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustCountry));

#line default
#line hidden
            EndContext();
            BeginContext(1573, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1634, 43, false);
#line 54 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustCountry));

#line default
#line hidden
            EndContext();
            BeginContext(1677, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1737, 49, false);
#line 57 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustHomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(1786, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1847, 45, false);
#line 60 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustHomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(1892, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1952, 48, false);
#line 63 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustBusPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2000, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2061, 44, false);
#line 66 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustBusPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2105, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2165, 45, false);
#line 69 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CustEmail));

#line default
#line hidden
            EndContext();
            BeginContext(2210, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2271, 41, false);
#line 72 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CustEmail));

#line default
#line hidden
            EndContext();
            BeginContext(2312, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2372, 44, false);
#line 75 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
            EndContext();
            BeginContext(2416, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2477, 40, false);
#line 78 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Username));

#line default
#line hidden
            EndContext();
            BeginContext(2517, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2577, 44, false);
#line 81 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(2621, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2682, 40, false);
#line 84 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(2722, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2782, 41, false);
#line 87 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Agent));

#line default
#line hidden
            EndContext();
            BeginContext(2823, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2884, 45, false);
#line 90 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Agent.AgentId));

#line default
#line hidden
            EndContext();
            BeginContext(2929, 40, true);
            WriteLiteral("\n        </dd class>\n    </dl>\n    \n    ");
            EndContext();
            BeginContext(2969, 210, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e6ad718f8cbbd7f8c1357a74d335e782fe75ffa17992", async() => {
                BeginContext(2995, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(3004, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7e6ad718f8cbbd7f8c1357a74d335e782fe75ffa18382", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 95 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Customers\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerId);

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
                BeginContext(3048, 81, true);
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\n        ");
                EndContext();
                BeginContext(3129, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e6ad718f8cbbd7f8c1357a74d335e782fe75ffa20361", async() => {
                    BeginContext(3151, 12, true);
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
                BeginContext(3167, 5, true);
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
            BeginContext(3179, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeamLID.TravelExperts.Repository.Domain.Customers> Html { get; private set; }
    }
}
#pragma warning restore 1591
