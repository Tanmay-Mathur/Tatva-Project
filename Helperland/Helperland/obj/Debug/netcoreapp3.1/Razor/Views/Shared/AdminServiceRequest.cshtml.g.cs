#pragma checksum "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\Shared\AdminServiceRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbe37479cc3cb0b047bd131559b89884186fcf23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AdminServiceRequest), @"mvc.1.0.view", @"/Views/Shared/AdminServiceRequest.cshtml")]
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
#line 1 "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\_ViewImports.cshtml"
using Helperland;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\_ViewImports.cshtml"
using Helperland.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbe37479cc3cb0b047bd131559b89884186fcf23", @"/Views/Shared/AdminServiceRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f94cf04a7ec23f27ac33992ef127038e0b3154", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_AdminServiceRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("admin-um-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<!-- service Request div starts -->
<div id=""adminServiceReq"" class=""adminMainDiv"">

    <!-- admin title starts -->
    <div id=""admin-title-outer"" class=""adminTitleOuter"">
        <div id=""admin-title"">
            <h1>Service Requests</h1>
        </div>
    </div>
    <!-- admin title ends -->
    <!-- admin um search starts  -->
    <div id=""admin-um-search"" class=""adminSearch"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbe37479cc3cb0b047bd131559b89884186fcf235985", async() => {
                WriteLiteral(@"
            <input type=""text"" name=""serviceid"" id=""admin-serviceid"" placeholder=""Service ID"">

            <input type=""text"" name=""postalCode"" id=""admin-serviceid"" placeholder=""Service ID"">

            <input type=""text"" name=""email"" id=""admin-serviceid"" placeholder=""Service ID"">


            <input type=""text"" name=""customer"" placeholder=""Customer"" id=""admin-sr-form-customer"">

            <input type=""text"" name=""serviceprovider"" placeholder=""Service Provider"" id=""admin-sr-form-sp"">

            <select name=""servicestatus"" id=""admin-sr-status"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbe37479cc3cb0b047bd131559b89884186fcf236872", async() => {
                    WriteLiteral("Status");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbe37479cc3cb0b047bd131559b89884186fcf238111", async() => {
                    WriteLiteral("New");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbe37479cc3cb0b047bd131559b89884186fcf239347", async() => {
                    WriteLiteral("Completed");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbe37479cc3cb0b047bd131559b89884186fcf2310589", async() => {
                    WriteLiteral("Cancelled");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbe37479cc3cb0b047bd131559b89884186fcf2311832", async() => {
                    WriteLiteral("Pending");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </select>
            <div id=""fdate"">
                <input type=""date"" id=""admin-sr-fdatepicker"" name=""fromdate"" onchange=""writefDate();"">
                <input type=""text"" name=""fromdate"" id=""admin-sr-fdate"" placeholder=""From Date"" onblur=""if(this.value){this.type='date';}else{this.type='text';}"" onfocus=""this.type='date'"">
            </div>

            <div id=""tdate"">
                <input type=""date"" id=""admin-sr-tdatepicker"" name=""fromdate"" onchange=""writetDate();"">
                <input type=""text"" name=""fromdate"" id=""admin-sr-tdate"" placeholder=""To Date"" onblur=""if(this.value){this.type='date';}else{this.type='text';}"" onfocus=""this.type='date'"">
            </div>

            <button type=""button"" id=""admin-um-form-searchbtn"">Search</button>
            <button type=""reset"" id=""admin-um-form-clearbtn"">Clear</button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <!-- admin um search ends -->

    <div id=""admin-um-exportdiv"" class=""adminExportDiv"">
        <button type=""button"" id=""export"">Export</button>
    </div>

    <!-- admin Service Request table table div starts -->
    <div id=""adminServiceReqTableDiv"" class=""adminTableDiv"">

        <table id=""adminServiceReqTable"">
            <thead>
                <tr>
                    <th>Service ID</th>
                    <th>Service Date</th>
                    <th>Customer Details</th>
                    <th>Service Provider</th>
                    <th>Status</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>
                        323436
                    </td>
                    <td>
                        <div>
                            <span><img src=""/img/upcomingService/calendar2.png""");
            BeginWriteAttribute("alt", " alt=\"", 3233, "\"", 3239, 0);
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                            <span class=\"upcoming-date\"><b>04/09/2018</b></span>\r\n                        </div>\r\n                        <div>\r\n                            <span><img src=\"/img/upcomingService/timer.png\"");
            BeginWriteAttribute("alt", " alt=\"", 3470, "\"", 3476, 0);
            EndWriteAttribute();
            WriteLiteral(@"></span> <span class=""upcoming-time"">12:00-18:00</span>
                        </div>
                    </td>
                    <td>
                        <div>David Bough</div>
                        <div><span><img src=""/img/upcomingService/home.png""");
            BeginWriteAttribute("alt", " alt=\"", 3742, "\"", 3748, 0);
            EndWriteAttribute();
            WriteLiteral(@"></span> <span class=""upcoming-address"">Okhlahoma 16 , 54321</span> </div>
                    </td>
                    <td>
                        <div class=""customer-sh-SP"">
                            <div><span class=""cap-span""><img src=""/img/customer-serviceHistory/cap.png"" class=""cap""");
            BeginWriteAttribute("alt", " alt=\"", 4053, "\"", 4059, 0);
            EndWriteAttribute();
            WriteLiteral("></span></div>\r\n                            <div class=\"sp-detail\">\r\n                                <p class=\"SP-name\">Lyum Watson</p>\r\n                                <span><img src=\"/img/customer-serviceHistory/star1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 4284, "\"", 4290, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"customer-sh-SP-star1\"></span>\r\n                                <span><img src=\"/img/customer-serviceHistory/star1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 4417, "\"", 4423, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"customer-sh-SP-star2\"></span>\r\n                                <span><img src=\"/img/customer-serviceHistory/star1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 4550, "\"", 4556, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"customer-sh-SP-star3\"></span>\r\n                                <span><img src=\"/img/customer-serviceHistory/star1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 4683, "\"", 4689, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"customer-sh-SP-star4\"></span>\r\n                                <span><img src=\"/img/customer-serviceHistory/star1.png\" class=\"customer-sh-SP-star5\"");
            BeginWriteAttribute("alt", " alt=\"", 4845, "\"", 4851, 0);
            EndWriteAttribute();
            WriteLiteral(@"></span>
                                <span class=""SP-stars"">4</span>

                            </div>
                        </div>
                    </td>
                    <td>
                        <p class=""admin-sr-status yellow-status"">new</p>
                    </td>

                    <td class=""admin-table-action dropdown"">
                        <button type=""button"" class=""admin-table-actionbtn"" id=""dropdownMenuButton1"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            <i class=""fa fa-ellipsis-v"" aria-hidden=""true"" style=""color:#646464""></i>
                        </button>
                        <div class=""admin-table-action-menu dropdown-menu"" aria-labelledby=""dropdownMenuButton1"">
                            <ul>
                                <li><a");
            BeginWriteAttribute("href", " href=\"", 5691, "\"", 5698, 0);
            EndWriteAttribute();
            WriteLiteral(">Edit & Reschedule</a> </li>\r\n                                <!--<li><a href=\"\">Refund</a></li>-->\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 5838, "\"", 5845, 0);
            EndWriteAttribute();
            WriteLiteral(">Cancel</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 5902, "\"", 5909, 0);
            EndWriteAttribute();
            WriteLiteral(@">Change SP</a></li>
                                <!--<li><a href="""">Escalate</a></li>
    <li><a href="""">History Log</a></li>
    <li><a href="""">Download Invoice</a></li>-->
                            </ul>
                        </div>
                    </td>
                </tr>

            </tbody>
        </table>

    </div>
    <!-- admin um table div ends -->

    <div id=""admin-um-footer"">
        <p>&copy;2018 Helperland. All rights reserved.</p>
    </div>
</div>
<!-- service Request div -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
