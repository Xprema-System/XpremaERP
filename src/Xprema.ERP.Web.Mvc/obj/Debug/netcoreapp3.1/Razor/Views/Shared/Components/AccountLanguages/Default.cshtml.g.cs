#pragma checksum "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/AccountLanguages/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92fec8ca1c26f24a30ed42943142488a4da6d873"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AccountLanguages_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AccountLanguages/Default.cshtml")]
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
#line 1 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/AccountLanguages/Default.cshtml"
using Xprema.ERP.Web.Views.Shared.Components.AccountLanguages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92fec8ca1c26f24a30ed42943142488a4da6d873", @"/Views/Shared/Components/AccountLanguages/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a52065cad192dfdc66712ec4755fee75e8484b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AccountLanguages_Default : Xprema.ERP.Web.Views.ERPRazorPage<LanguageSelectionViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/AccountLanguages/Default.cshtml"
 if (Model.Languages.Count > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\">\n");
#nullable restore
#line 6 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/AccountLanguages/Default.cshtml"
         foreach (var languageInfo in Model.Languages)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 240, "\"", 455, 1);
#nullable restore
#line 8 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/AccountLanguages/Default.cshtml"
WriteAttributeValue("", 247, Url.Action("ChangeCulture", "AbpLocalization", new {
                    cultureName = languageInfo.Name,
                    returnUrl = Context.Request.Path + Context.Request.QueryString
                }), 247, 208, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                <span");
            BeginWriteAttribute("class", " class=\"", 479, "\"", 568, 1);
#nullable restore
#line 12 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/AccountLanguages/Default.cshtml"
WriteAttributeValue("", 487, languageInfo.Name == Model.CurrentLanguage.Name ? "current-language-icon" : "", 487, 81, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 569, "\"", 602, 1);
#nullable restore
#line 12 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/AccountLanguages/Default.cshtml"
WriteAttributeValue("", 577, languageInfo.DisplayName, 577, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    <i");
            BeginWriteAttribute("class", " class=\"", 627, "\"", 653, 1);
#nullable restore
#line 13 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/AccountLanguages/Default.cshtml"
WriteAttributeValue("", 635, languageInfo.Icon, 635, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\n                </span>\n            </a>\n");
#nullable restore
#line 16 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/AccountLanguages/Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n");
#nullable restore
#line 18 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/AccountLanguages/Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LanguageSelectionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
