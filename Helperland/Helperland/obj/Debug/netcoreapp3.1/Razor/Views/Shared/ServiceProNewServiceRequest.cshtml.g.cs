#pragma checksum "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\Shared\ServiceProNewServiceRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "613de985c439217cac5d0ffac147671da5f95c50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ServiceProNewServiceRequest), @"mvc.1.0.view", @"/Views/Shared/ServiceProNewServiceRequest.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"613de985c439217cac5d0ffac147671da5f95c50", @"/Views/Shared/ServiceProNewServiceRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f94cf04a7ec23f27ac33992ef127038e0b3154", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ServiceProNewServiceRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"

<div id=""newServiceRequest"" class=""allPageMain tableContents"">

    <div class=""customer-page-title-export"">
        <div class=""customer-page-title"">
            <h2>
                New Service Request
            </h2>
        </div>
        <div id=""export-btn"">
            <a href=""#"" role=""button"" id=""export"">Export</a>
        </div>
    </div>

    <table id=""newServiceRequestTable"">
        <thead>
            <tr>
                <th>
                    Service ID
                </th>
                <th>
                    Service Date
                </th>
                <th>
                    Customer Details
                </th>
                <th>
                    Payment
                </th>
                <th>
                    Time Conflict
                </th>
                <th>
                    Actions
                </th>
            </tr>
        </thead>
        <tbody>

            <tr>
                <td>
             ");
            WriteLiteral("       323436\r\n                </td>\r\n                <td>\r\n                    <div>\r\n                        <span><img src=\"/img/upcomingService/calendar2.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1310, "\"", 1316, 0);
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                        <span class=\"upcoming-date\"><b>04/09/2018</b></span>\r\n                    </div>\r\n                    <div>\r\n                        <span><img src=\"/img/upcomingService/timer.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1531, "\"", 1537, 0);
            EndWriteAttribute();
            WriteLiteral("></span> <span class=\"upcoming-time\">12:00-18:00</span>\r\n                    </div>\r\n                </td>\r\n                <td>\r\n                    <div>David Bough</div>\r\n                    <div><span><img src=\"img/upcomingService/home.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1782, "\"", 1788, 0);
            EndWriteAttribute();
            WriteLiteral(@"></span> <span class=""upcoming-address"">Okhlahoma 16, 54321</span> </div>
                </td>
                <td>
                    <span>15</span> &euro;
                </td>
                <td>
                </td>
                <td class=""allPageActionButtons"">
                    <a href=""#"">Accept</a>
                </td>

            </tr>


        </tbody>
    </table>
</div>");
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
