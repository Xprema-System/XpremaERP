#pragma checksum "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Layout/_SideBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "216cec970e23ac28145d8e054b455f8061c21b00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Layout__SideBar), @"mvc.1.0.view", @"/Views/Shared/Layout/_SideBar.cshtml")]
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
#line 1 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Layout/_SideBar.cshtml"
using Xprema.ERP.Web.Views.Shared.Components.SideBarMenu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Layout/_SideBar.cshtml"
using Xprema.ERP.Web.Views.Shared.Components.SideBarUserArea;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"216cec970e23ac28145d8e054b455f8061c21b00", @"/Views/Shared/Layout/_SideBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a52065cad192dfdc66712ec4755fee75e8484b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Layout__SideBar : Xprema.ERP.Web.Views.ERPRazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<aside class=\"main-sidebar sidebar-dark-primary elevation-4\">\n    ");
#nullable restore
#line 4 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Layout/_SideBar.cshtml"
Write(await Html.PartialAsync("_SideBar.Logo.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"sidebar\">\n        ");
#nullable restore
#line 6 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Layout/_SideBar.cshtml"
   Write(await Component.InvokeAsync(typeof(SideBarUserAreaViewComponent)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 7 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Layout/_SideBar.cshtml"
   Write(await Component.InvokeAsync(typeof(SideBarMenuViewComponent)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n</aside>\n");
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
