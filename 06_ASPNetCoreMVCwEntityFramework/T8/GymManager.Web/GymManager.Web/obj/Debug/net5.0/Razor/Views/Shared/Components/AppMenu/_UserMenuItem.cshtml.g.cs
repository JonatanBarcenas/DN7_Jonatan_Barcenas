#pragma checksum "C:\Users\jonat\OneDrive\Documentos\GitHub\DN7_Jonatan_Barcenas\06_ASPNetCoreMVCwEntityFramework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12f3c0a6fa95ff5e09d34a364fbf9ac63c9f2711"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AppMenu__UserMenuItem), @"mvc.1.0.view", @"/Views/Shared/Components/AppMenu/_UserMenuItem.cshtml")]
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
#line 1 "C:\Users\jonat\OneDrive\Documentos\GitHub\DN7_Jonatan_Barcenas\06_ASPNetCoreMVCwEntityFramework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
using GymManager.Core.Navigation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12f3c0a6fa95ff5e09d34a364fbf9ac63c9f2711", @"/Views/Shared/Components/AppMenu/_UserMenuItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_AppMenu__UserMenuItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GymManager.Web.Models.UserMenuItemViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\jonat\OneDrive\Documentos\GitHub\DN7_Jonatan_Barcenas\06_ASPNetCoreMVCwEntityFramework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
  
	var orderedChildMenuItems = Model.MenuItem.Items.OrderBy(x => x.Order);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\jonat\OneDrive\Documentos\GitHub\DN7_Jonatan_Barcenas\06_ASPNetCoreMVCwEntityFramework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
 if(Model.MenuItem.Items.Count < 1)
{
	

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<li class=\"nav-item\">\r\n\t\t<a");
            BeginWriteAttribute("class", " class=\"", 245, "\"", 331, 2);
            WriteAttributeValue("", 253, "nav-link", 253, 8, true);
#nullable restore
#line 13 "C:\Users\jonat\OneDrive\Documentos\GitHub\DN7_Jonatan_Barcenas\06_ASPNetCoreMVCwEntityFramework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue(" ", 261, Model.MenuItem.IsMenuActive(Model.CurrentPageName) ? "active" : "", 262, 69, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\jonat\OneDrive\Documentos\GitHub\DN7_Jonatan_Barcenas\06_ASPNetCoreMVCwEntityFramework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
                                                                                              Write(Model.MenuItem.IsMenuActive(Model.CurrentPageName) ? "aria-current=\"page\"" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" href=\"");
#nullable restore
#line 13 "C:\Users\jonat\OneDrive\Documentos\GitHub\DN7_Jonatan_Barcenas\06_ASPNetCoreMVCwEntityFramework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
                                                                                                                                                                                        Write(Model.MenuItem.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 13 "C:\Users\jonat\OneDrive\Documentos\GitHub\DN7_Jonatan_Barcenas\06_ASPNetCoreMVCwEntityFramework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
                                                                                                                                                                                                             Write(Model.MenuItem.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t</li>\r\n");
#nullable restore
#line 15 "C:\Users\jonat\OneDrive\Documentos\GitHub\DN7_Jonatan_Barcenas\06_ASPNetCoreMVCwEntityFramework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"

}
else
{
	string currentElementId = "menu-" + new Random().Next();


#line default
#line hidden
#nullable disable
            WriteLiteral("\t<li class=\"nav-item dropdown\">\r\n\t\t<a");
            BeginWriteAttribute("class", " class=\"", 598, "\"", 700, 3);
            WriteAttributeValue("", 606, "nav-link", 606, 8, true);
            WriteAttributeValue(" ", 614, "dropdown-toggle", 615, 16, true);
#nullable restore
#line 22 "C:\Users\jonat\OneDrive\Documentos\GitHub\DN7_Jonatan_Barcenas\06_ASPNetCoreMVCwEntityFramework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue(" ", 630, Model.MenuItem.IsMenuActive(Model.CurrentPageName) ? "active" : "", 631, 69, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"#\"");
            BeginWriteAttribute("id", " id=\"", 710, "\"", 732, 1);
#nullable restore
#line 22 "C:\Users\jonat\OneDrive\Documentos\GitHub\DN7_Jonatan_Barcenas\06_ASPNetCoreMVCwEntityFramework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue("", 715, currentElementId, 715, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-bs-toggle=\"dropdown\" aria-expanded=\"false\">");
#nullable restore
#line 22 "C:\Users\jonat\OneDrive\Documentos\GitHub\DN7_Jonatan_Barcenas\06_ASPNetCoreMVCwEntityFramework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
                                                                                                                                                                                             Write(Model.MenuItem.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t<ul class=\"dropdown-menu\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 842, "\"", 877, 1);
#nullable restore
#line 23 "C:\Users\jonat\OneDrive\Documentos\GitHub\DN7_Jonatan_Barcenas\06_ASPNetCoreMVCwEntityFramework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue("", 860, currentElementId, 860, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n");
#nullable restore
#line 25 "C:\Users\jonat\OneDrive\Documentos\GitHub\DN7_Jonatan_Barcenas\06_ASPNetCoreMVCwEntityFramework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
             foreach(var subMenu in Model.MenuItem.Items)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<li><a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 971, "\"", 990, 1);
#nullable restore
#line 27 "C:\Users\jonat\OneDrive\Documentos\GitHub\DN7_Jonatan_Barcenas\06_ASPNetCoreMVCwEntityFramework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue("", 978, subMenu.Url, 978, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "C:\Users\jonat\OneDrive\Documentos\GitHub\DN7_Jonatan_Barcenas\06_ASPNetCoreMVCwEntityFramework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
                                                            Write(subMenu.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 28 "C:\Users\jonat\OneDrive\Documentos\GitHub\DN7_Jonatan_Barcenas\06_ASPNetCoreMVCwEntityFramework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\r\n\t\t\t\r\n\t\t</ul>\r\n\t</li>\r\n");
#nullable restore
#line 33 "C:\Users\jonat\OneDrive\Documentos\GitHub\DN7_Jonatan_Barcenas\06_ASPNetCoreMVCwEntityFramework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GymManager.Web.Models.UserMenuItemViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
