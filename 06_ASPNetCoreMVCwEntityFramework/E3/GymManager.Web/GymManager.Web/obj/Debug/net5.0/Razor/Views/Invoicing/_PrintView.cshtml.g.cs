#pragma checksum "C:\Users\jonat\OneDrive\Documentos\GitHub\DN7_Jonatan_Barcenas\06_ASPNetCoreMVCwEntityFramework\E4\GymManager.Web\GymManager.Web\Views\Invoicing\_PrintView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2e0a18cfd9de9628f8072b3ea30985995e820d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoicing__PrintView), @"mvc.1.0.view", @"/Views/Invoicing/_PrintView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2e0a18cfd9de9628f8072b3ea30985995e820d4", @"/Views/Invoicing/_PrintView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Invoicing__PrintView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container mt-5 mb-3"">
    <div class=""row d-flex justify-content-center"">
        <div class=""col-md-8"">
            <div class=""card"">
                <div class=""d-flex flex-row p-2"">
                    <img src=""https://localhost:44388/images/11247.jpg"" width=""68"" style=""margin-right:10px;"">
                    <div class=""d-flex flex-column""> <span class=""font-weight-bold"">Tax Invoice</span> <small>INV-001</small> </div>
                </div>
                <hr>
                <div class=""table-responsive p-2"">
                    <table class=""table table-borderless"">
                        <tbody>
                            <tr class=""add"">
                                <td>To</td>
                                <td>From</td>
                            </tr>
                            <tr class=""content"">
                                <td class=""font-weight-bold"">Google <br>Attn: John Smith Pymont <br>Australia</td>
                                <td class=""");
            WriteLiteral(@"font-weight-bold"">Facebook <br> Attn: John Right Polymont <br> USA</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <hr>
                <div class=""products p-2"">
                    <table class=""table table-borderless"">
                        <tbody>
                            <tr class=""add"">
                                <td>Description</td>
                                <td>Days</td>
                                <td>Price</td>
                                <td class=""text-center"">Total</td>
                            </tr>
                            <tr class=""content"">
                                <td>Website Redesign</td>
                                <td>15</td>
                                <td>$1,500</td>
                                <td class=""text-center"">$22,500</td>
                            </tr>
                            <tr class=""content"">
             ");
            WriteLiteral(@"                   <td>Logo & Identity</td>
                                <td>10</td>
                                <td>$1,500</td>
                                <td class=""text-center"">$15,000</td>
                            </tr>
                            <tr class=""content"">
                                <td>Marketing Collateral</td>
                                <td>3</td>
                                <td>$1,500</td>
                                <td class=""text-center"">$4,500</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <hr>
                <div class=""products p-2"">
                    <table class=""table table-borderless"">
                        <tbody>
                            <tr class=""add"">
                                <td></td>
                                <td>Subtotal</td>
                                <td>GST(10%)</td>
                                ");
            WriteLiteral(@"<td class=""text-center"">Total</td>
                            </tr>
                            <tr class=""content"">
                                <td></td>
                                <td>$40,000</td>
                                <td>2,500</td>
                                <td class=""text-center"">$42,500</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <hr>
                <div class=""address p-2"">
                    <table class=""table table-borderless"">
                        <tbody>
                            <tr class=""add"">
                                <td>Bank Details</td>
                            </tr>
                            <tr class=""content"">
                                <td> Bank Name : ADS BANK <br> Swift Code : ADS1234Q <br> Account Holder : Jelly Pepper <br> Account Number : 5454542WQR <br> </td>
                            </tr>
                        <");
            WriteLiteral("/tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
