#pragma checksum "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Bookings\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14e8590efcf559f215965533175584d82905207f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookings_Details), @"mvc.1.0.view", @"/Views/Bookings/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bookings/Details.cshtml", typeof(AspNetCore.Views_Bookings_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14e8590efcf559f215965533175584d82905207f", @"/Views/Bookings/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfc5dd6d3fd7f789f6f56895dee830dc59aecabd", @"/Views/_ViewImports.cshtml")]
    public class Views_Bookings_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeamLID.TravelExperts.Repository.Domain.Bookings>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(56, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Bookings\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(97, 123, true);
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>Bookings</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(221, 47, false);
#line 14 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Bookings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BookingDate));

#line default
#line hidden
            EndContext();
            BeginContext(268, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(329, 43, false);
#line 17 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Bookings\Details.cshtml"
       Write(Html.DisplayFor(model => model.BookingDate));

#line default
#line hidden
            EndContext();
            BeginContext(372, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(432, 45, false);
#line 20 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Bookings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BookingNo));

#line default
#line hidden
            EndContext();
            BeginContext(477, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(538, 41, false);
#line 23 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Bookings\Details.cshtml"
       Write(Html.DisplayFor(model => model.BookingNo));

#line default
#line hidden
            EndContext();
            BeginContext(579, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(639, 49, false);
#line 26 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Bookings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TravelerCount));

#line default
#line hidden
            EndContext();
            BeginContext(688, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(749, 45, false);
#line 29 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Bookings\Details.cshtml"
       Write(Html.DisplayFor(model => model.TravelerCount));

#line default
#line hidden
            EndContext();
            BeginContext(794, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(854, 44, false);
#line 32 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Bookings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer));

#line default
#line hidden
            EndContext();
            BeginContext(898, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(959, 52, false);
#line 35 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Bookings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.CustAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1071, 43, false);
#line 38 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Bookings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Package));

#line default
#line hidden
            EndContext();
            BeginContext(1114, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1175, 47, false);
#line 41 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Bookings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Package.PkgName));

#line default
#line hidden
            EndContext();
            BeginContext(1222, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1282, 44, false);
#line 44 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Bookings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TripType));

#line default
#line hidden
            EndContext();
            BeginContext(1326, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1387, 51, false);
#line 47 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Bookings\Details.cshtml"
       Write(Html.DisplayFor(model => model.TripType.TripTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(1438, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1480, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14e8590efcf559f215965533175584d82905207f10402", async() => {
                BeginContext(1533, 4, true);
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
#line 52 "C:\Users\mypc\Downloads\Compressed\Travel-Agency-Web-App-master\Travel-Agency-Web-App-master\TeamLID.TravelExperts.App\Views\Bookings\Details.cshtml"
                           WriteLiteral(Model.BookingId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1541, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(1548, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14e8590efcf559f215965533175584d82905207f12798", async() => {
                BeginContext(1570, 12, true);
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
            BeginContext(1586, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeamLID.TravelExperts.Repository.Domain.Bookings> Html { get; private set; }
    }
}
#pragma warning restore 1591
