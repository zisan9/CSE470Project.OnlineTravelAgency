#pragma checksum "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Agents\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e504dc27fa8b08508605062fa16b1e77c278f86c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Agents_Delete), @"mvc.1.0.view", @"/Views/Agents/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Agents/Delete.cshtml", typeof(AspNetCore.Views_Agents_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e504dc27fa8b08508605062fa16b1e77c278f86c", @"/Views/Agents/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfc5dd6d3fd7f789f6f56895dee830dc59aecabd", @"/Views/_ViewImports.cshtml")]
    public class Views_Agents_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeamLID.TravelExperts.Repository.Domain.Agents>
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
            BeginContext(54, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Agents\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(94, 167, true);
            WriteLiteral("\n<h1>Delete</h1>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>Agents</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(262, 48, false);
#line 15 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Agents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AgtFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(310, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(371, 44, false);
#line 18 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Agents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AgtFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(415, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(475, 52, false);
#line 21 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Agents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AgtMiddleInitial));

#line default
#line hidden
            EndContext();
            BeginContext(527, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(588, 48, false);
#line 24 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Agents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AgtMiddleInitial));

#line default
#line hidden
            EndContext();
            BeginContext(636, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(696, 47, false);
#line 27 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Agents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AgtLastName));

#line default
#line hidden
            EndContext();
            BeginContext(743, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(804, 43, false);
#line 30 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Agents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AgtLastName));

#line default
#line hidden
            EndContext();
            BeginContext(847, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(907, 47, false);
#line 33 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Agents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AgtBusPhone));

#line default
#line hidden
            EndContext();
            BeginContext(954, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1015, 43, false);
#line 36 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Agents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AgtBusPhone));

#line default
#line hidden
            EndContext();
            BeginContext(1058, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1118, 44, false);
#line 39 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Agents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AgtEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1162, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1223, 40, false);
#line 42 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Agents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AgtEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1263, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1323, 47, false);
#line 45 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Agents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AgtPosition));

#line default
#line hidden
            EndContext();
            BeginContext(1370, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1431, 43, false);
#line 48 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Agents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AgtPosition));

#line default
#line hidden
            EndContext();
            BeginContext(1474, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1534, 42, false);
#line 51 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Agents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Agency));

#line default
#line hidden
            EndContext();
            BeginContext(1576, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1637, 47, false);
#line 54 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Agents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Agency.AgencyId));

#line default
#line hidden
            EndContext();
            BeginContext(1684, 40, true);
            WriteLiteral("\n        </dd class>\n    </dl>\n    \n    ");
            EndContext();
            BeginContext(1724, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e504dc27fa8b08508605062fa16b1e77c278f86c12061", async() => {
                BeginContext(1750, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(1759, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e504dc27fa8b08508605062fa16b1e77c278f86c12451", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 59 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Agents\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AgentId);

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
                BeginContext(1800, 81, true);
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\n        ");
                EndContext();
                BeginContext(1881, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e504dc27fa8b08508605062fa16b1e77c278f86c14424", async() => {
                    BeginContext(1903, 12, true);
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
                BeginContext(1919, 5, true);
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
            BeginContext(1931, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeamLID.TravelExperts.Repository.Domain.Agents> Html { get; private set; }
    }
}
#pragma warning restore 1591
