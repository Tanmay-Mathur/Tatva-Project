#pragma checksum "D:\Tatvasoft\Tatvasoft Project\Helperland\Helperland\Views\Shared\ServiceProModals.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5ab44c86a4863bd3692afe742b4b299a47b154f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ServiceProModals), @"mvc.1.0.view", @"/Views/Shared/ServiceProModals.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5ab44c86a4863bd3692afe742b4b299a47b154f", @"/Views/Shared/ServiceProModals.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f94cf04a7ec23f27ac33992ef127038e0b3154", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ServiceProModals : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<button id=""serviceReqdetailsbtn"" data-bs-toggle=""modal"" data-bs-target=""#serviceRequestDetailsModal"" class=""d-none"">details</button>


<div class=""modal spModal"" tabindex=""-1"" id=""serviceRequestDetailsModal"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Service Details</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <div class=""main"">
                    <div>
                        <h4 id=""CDDetailsDateTime"">05/10/2021 08:00 - 11:30</h4>
                        <p><b>Duration: </b><span id=""CDDetailsDuration""></span> hrs</p>
                    </div>
                    <div>
                        <p><b>Service Id: </b><span id=""CDDetailsId""></span></p>
                        <div class=""d-flex border border-0"">
             ");
            WriteLiteral(@"               <p><b>Extras: </b> </p>
                            <div id=""CDDetailsExtra"" class=""border border-0 p-0 ps-1""></div>
                        </div>
                        <p><b>Net Amount:</b><span class=""amount"" id=""CDDetailsAmount"">8750 &euro;</span></p>
                    </div>
                    <div>
                        <p><b>Customer Name: </b> <span id=""ModalCustomerName""></span></p>
                        <p><b>Service Address: </b> <span class=""customerModalServiceAddress"" id=""ModalAddress""></span></p>
                        <p><b>Phone: </b><span>+91</span><span class=""customerModalPhone"" id=""ModalPhoneNo""></span></p>
                    </div>
                    <div>
                        <p><b>Comments: </b><span class=""customerModalComments"" id=""ModalComments""></span></p>
                        <p id=""dontHavePet"">
                            <svg xmlns=""http://www.w3.org/2000/svg""
                                 class=""x-icon""
                       ");
            WriteLiteral(@"          fill=""red""
                                 viewBox=""0 0 24 24""
                                 stroke=""white"" height=""24px"" width=""24px"">
                                <path stroke-linecap=""round""
                                      stroke-linejoin=""round""
                                      stroke-width=""2""
                                      d=""M10 14l2-2m0 0l2-2m-2 2l-2-2m2 2l2 2m7-2a9 9 0 11-18 0 9 9 0 0118 0z"" />
                            </svg>
                            <span class=""cusomerModalPet"">I don't have pets at home.</span>
                        </p>
                        <p id=""HavePet"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" class=""dog-tick-icon"" viewBox=""0 0 20 20"" fill=""rgb(35, 187, 60)"" stroke=""white"" height=""24px"" width=""24px"">
                                <path fill-rule=""evenodd""
                                      d=""M10 18a8 8 0 100-16 8 8 0 000 16zm3.707-9.293a1 1 0 00-1.414-1.414L9 10.586 7.707 9.293a1 1 0 00");
            WriteLiteral(@"-1.414 1.414l2 2a1 1 0 001.414 0l4-4z""
                                      clip-rule=""evenodd"" />
                            </svg>
                            <span class=""cusomerModalPet"">I have pets at home.</span>
                        </p>
                    </div>
                </div>
                <!-- service provider details -->
                <div class=""myMap"">
                    <div id=""locationMap""></div>
                </div>

            </div>
            <div class=""modal-footer"">
                <button class=""rescheduleBtn"" id=""AcceptBtnModal"">
                    Accept
                </button>
                <button class=""d-none"" style=""background-color: #FF6B6B;"" id=""CancelBtnModal"">
                    <svg xmlns=""http://www.w3.org/2000/svg"" class=""h-5 w-5"" viewBox=""0 0 20 20"" fill=""currentColor"" height=""24px"" width=""24px"">
                        <path fill-rule=""evenodd"" d=""M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414");
            WriteLiteral(@" 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z"" clip-rule=""evenodd"" />
                    </svg>
                    Cancel
                </button>
                <button class=""rescheduleBtn d-none"" id=""CompleteBtnModal"">

                    <svg xmlns=""http://www.w3.org/2000/svg"" class=""h-5 w-5"" viewBox=""0 0 20 20"" fill=""currentColor"" height=""24px"">
                        <path fill-rule=""evenodd"" d=""M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z"" clip-rule=""evenodd"" />
                    </svg>
                    Complete
                </button>
            </div>
        </div>
    </div>
</div>


<!--Cancel Request-->
<div class=""modal"" tabindex=""-1"" id=""serviceRequestCancelModal"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""m");
            WriteLiteral(@"odal-title"">Cancel Service Request</h4>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <input type=""hidden"" id=""CancelRequestId"" name=""CancelRequestId"" />
                <p><label for=""cancelReason"">Why you want to cancel the service request?</label></p>
                <textarea name=""cancelReason"" id=""cancelReason"" cols=""30"" rows=""10""></textarea>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn cancelBtn"" id=""SPCancelRequestBtn"">Cancel Now</button>
            </div>
        </div>
    </div>
</div>
");
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
