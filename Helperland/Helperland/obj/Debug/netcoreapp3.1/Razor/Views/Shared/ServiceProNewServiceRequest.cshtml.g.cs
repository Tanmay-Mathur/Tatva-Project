#pragma checksum "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\Shared\ServiceProNewServiceRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d76155d3e6c0ff3e00d32482471a11d1e1bfdf3"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d76155d3e6c0ff3e00d32482471a11d1e1bfdf3", @"/Views/Shared/ServiceProNewServiceRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f94cf04a7ec23f27ac33992ef127038e0b3154", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ServiceProNewServiceRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Helperland.ViewModels.NewServiceRequestTable>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
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

    <div>
        <input type=""checkbox"" id=""havepetCheckbox"" checked/>
        <label for=""havepetCheckbox"">Including Pet at home</label>
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
     ");
            WriteLiteral("               Actions\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n\r\n");
#nullable restore
#line 50 "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\Shared\ServiceProNewServiceRequest.cshtml"
             if (Model.Count() > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\Shared\ServiceProNewServiceRequest.cshtml"
                 foreach (var row in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr data-value=\"");
#nullable restore
#line 54 "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\Shared\ServiceProNewServiceRequest.cshtml"
                               Write(row.ServiceRequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <td>\r\n                            ");
#nullable restore
#line 56 "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\Shared\ServiceProNewServiceRequest.cshtml"
                       Write(row.ServiceRequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <div>\r\n                                <span><img src=\"/img/upcomingService/calendar2.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1752, "\"", 1758, 0);
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                                <span class=\"upcoming-date\"><b>");
#nullable restore
#line 61 "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\Shared\ServiceProNewServiceRequest.cshtml"
                                                          Write(row.ServiceStartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></span>\r\n                            </div>\r\n                            <div>\r\n                                <span><img src=\"/img/upcomingService/timer.png\"");
            BeginWriteAttribute("alt", " alt=\"", 2016, "\"", 2022, 0);
            EndWriteAttribute();
            WriteLiteral("></span> <span class=\"upcoming-time\">");
#nullable restore
#line 64 "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\Shared\ServiceProNewServiceRequest.cshtml"
                                                                                                                      Write(row.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 64 "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\Shared\ServiceProNewServiceRequest.cshtml"
                                                                                                                                     Write(row.EndTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </td>\r\n                        <td>\r\n                            <div>");
#nullable restore
#line 68 "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\Shared\ServiceProNewServiceRequest.cshtml"
                            Write(row.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div><span><img src=\"/img/upcomingService/home.png\"");
            BeginWriteAttribute("alt", " alt=\"", 2330, "\"", 2336, 0);
            EndWriteAttribute();
            WriteLiteral("></span> <span class=\"upcoming-address\">");
#nullable restore
#line 69 "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\Shared\ServiceProNewServiceRequest.cshtml"
                                                                                                                         Write(row.AddressLine2);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 69 "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\Shared\ServiceProNewServiceRequest.cshtml"
                                                                                                                                            Write(row.AddressLine1);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>");
#nullable restore
#line 69 "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\Shared\ServiceProNewServiceRequest.cshtml"
                                                                                                                                                                 Write(row.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 69 "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\Shared\ServiceProNewServiceRequest.cshtml"
                                                                                                                                                                             Write(row.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </div>\r\n                        </td>\r\n                        <td>\r\n                            <span>");
#nullable restore
#line 72 "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\Shared\ServiceProNewServiceRequest.cshtml"
                             Write(row.TotalCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> &euro;\r\n                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 75 "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\Shared\ServiceProNewServiceRequest.cshtml"
                             if (row.TimeConflict != 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button type=\"button\" data-value=\"");
#nullable restore
#line 77 "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\Shared\ServiceProNewServiceRequest.cshtml"
                                                             Write(row.TimeConflict);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn timeConflict\">Conflicted</button>\r\n");
#nullable restore
#line 78 "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\Shared\ServiceProNewServiceRequest.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\Shared\ServiceProNewServiceRequest.cshtml"
                             if (row.HasPet == false)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"d-none dontHavePet\">dontHavePet</div>\r\n");
#nullable restore
#line 82 "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\Shared\ServiceProNewServiceRequest.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td class=\"allPageActionButtons\">\r\n");
#nullable restore
#line 85 "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\Shared\ServiceProNewServiceRequest.cshtml"
                             if (row.TimeConflict != 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a href=\"#\" class=\"btn disabled\">Accept</a>\r\n");
#nullable restore
#line 88 "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\Shared\ServiceProNewServiceRequest.cshtml"
                                    }
                                    else
                                    {
                                        string myid = "newAcceptBtn" + row.ServiceRequestId;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a href=\"#\" class=\"btn acceptService\"");
            BeginWriteAttribute("id", " id=", 3634, "", 3643, 1);
#nullable restore
#line 92 "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\Shared\ServiceProNewServiceRequest.cshtml"
WriteAttributeValue("", 3638, myid, 3638, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >Accept</a>\r\n");
#nullable restore
#line 93 "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\Shared\ServiceProNewServiceRequest.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 97 "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\Shared\ServiceProNewServiceRequest.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\Shared\ServiceProNewServiceRequest.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Helperland.ViewModels.NewServiceRequestTable>> Html { get; private set; }
    }
}
#pragma warning restore 1591
