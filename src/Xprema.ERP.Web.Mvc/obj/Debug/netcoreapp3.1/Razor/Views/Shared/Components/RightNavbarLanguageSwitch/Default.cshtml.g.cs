#pragma checksum "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/RightNavbarLanguageSwitch/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2526e1482e28b121f06a0a24ebb29d0c86c9d5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_RightNavbarLanguageSwitch_Default), @"mvc.1.0.view", @"/Views/Shared/Components/RightNavbarLanguageSwitch/Default.cshtml")]
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
#line 1 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/RightNavbarLanguageSwitch/Default.cshtml"
using Xprema.ERP.Web.Views.Shared.Components.RightNavbarLanguageSwitch;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2526e1482e28b121f06a0a24ebb29d0c86c9d5c", @"/Views/Shared/Components/RightNavbarLanguageSwitch/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a52065cad192dfdc66712ec4755fee75e8484b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_RightNavbarLanguageSwitch_Default : Xprema.ERP.Web.Views.ERPRazorPage<RightNavbarLanguageSwitchViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<li class=\"nav-item dropdown\">\n    <a href=\"javascript:void(0);\" class=\"nav-link\" data-toggle=\"dropdown\" role=\"button\">\n        <i");
            BeginWriteAttribute("class", " class=\"", 245, "\"", 280, 1);
#nullable restore
#line 6 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/RightNavbarLanguageSwitch/Default.cshtml"
WriteAttributeValue("", 253, Model.CurrentLanguage.Icon, 253, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 281, "\"", 323, 1);
#nullable restore
#line 6 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/RightNavbarLanguageSwitch/Default.cshtml"
WriteAttributeValue("", 289, Model.CurrentLanguage.DisplayName, 289, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\n        <span class=\"d-none d-md-inline-block\">");
#nullable restore
#line 7 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/RightNavbarLanguageSwitch/Default.cshtml"
                                          Write(Model.CurrentLanguage.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n    </a>\n    <div class=\"dropdown-menu dropdown-menu-right p-0\">\n");
#nullable restore
#line 10 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/RightNavbarLanguageSwitch/Default.cshtml"
         foreach (var languageInfo in Model.Languages)
        {
            if (languageInfo.Name != Model.CurrentLanguage.Name)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 668, "\"", 973, 1);
#nullable restore
#line 14 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/RightNavbarLanguageSwitch/Default.cshtml"
WriteAttributeValue("", 675, Url.Action("ChangeCulture", "AbpLocalization", new {
                                                  cultureName = languageInfo.Name,
                                                  returnUrl = Context.Request.Path + Context.Request.QueryString
                                              }), 675, 298, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    <i");
            BeginWriteAttribute("class", " class=\"", 998, "\"", 1029, 2);
            WriteAttributeValue("", 1006, "mr-2", 1006, 4, true);
#nullable restore
#line 18 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/RightNavbarLanguageSwitch/Default.cshtml"
WriteAttributeValue(" ", 1010, languageInfo.Icon, 1011, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> ");
#nullable restore
#line 18 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/RightNavbarLanguageSwitch/Default.cshtml"
                                                       Write(languageInfo.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </a>\n");
#nullable restore
#line 20 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/RightNavbarLanguageSwitch/Default.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</li>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RightNavbarLanguageSwitchViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
