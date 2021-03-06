#pragma checksum "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fb8e1598cae3cbe20c3c7b33cc700f8eeb5998e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SideBarMenu__MenuItem), @"mvc.1.0.view", @"/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml")]
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
#line 1 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
using Xprema.ERP.Web.Views;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
using Xprema.ERP.Web.Views.Shared.Components.SideBarMenu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
using Abp.Application.Navigation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fb8e1598cae3cbe20c3c7b33cc700f8eeb5998e", @"/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a52065cad192dfdc66712ec4755fee75e8484b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SideBarMenu__MenuItem : Xprema.ERP.Web.Views.ERPRazorPage<Abp.Application.Navigation.UserMenuItem>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
  
    var isActive = IsActiveMenuItem(Model, ViewBag.CurrentPageName);
    var subMenus = Model.Items.Where(x => x.IsVisible).OrderByCustom().ToList();
    var hasSubMenus = subMenus.Any();

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
 if (!hasSubMenus)
{
    var linkUrl = CalculateMenuUrl(Model.Url);
    var linkClasses = $"nav-link {(isActive ? "active" : null)}";
    var linkTarget = !string.IsNullOrEmpty(Model.Target) ? Html.Raw($" target=\"{Model.Target}\"") : null;


#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"nav-item\">\n        <a");
            BeginWriteAttribute("href", " href=\"", 1249, "\"", 1264, 1);
#nullable restore
#line 39 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
WriteAttributeValue("", 1256, linkUrl, 1256, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1265, "\"", 1285, 1);
#nullable restore
#line 39 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
WriteAttributeValue("", 1273, linkClasses, 1273, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 39 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
                                           Write(linkTarget);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\n");
#nullable restore
#line 40 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
             if (!string.IsNullOrEmpty(Model.Icon))
            {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    <i");
            BeginWriteAttribute("class", " class=\"", 1411, "\"", 1452, 2);
            WriteAttributeValue("", 1419, "nav-icon", 1419, 8, true);
#nullable restore
#line 43 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
WriteAttributeValue(" ", 1427, Url.Content(Model.Icon), 1428, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\n                ");
#nullable restore
#line 44 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
                       
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>");
#nullable restore
#line 46 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
          Write(Model.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </a>\n    </li>\n");
#nullable restore
#line 49 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
}
else
{
    var navitemClasses = $"nav-item {(hasSubMenus ? "has-treeview" : "")} {(isActive ? "menu-open" : "")}";
    navitemClasses = !string.IsNullOrEmpty(navitemClasses?.Trim()) ? navitemClasses : null;
    var linkClasses = $"nav-link {(isActive ? "active" : null)}";


#line default
#line hidden
#nullable disable
            WriteLiteral("    <li");
            BeginWriteAttribute("class", " class=\"", 1841, "\"", 1864, 1);
#nullable restore
#line 56 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
WriteAttributeValue("", 1849, navitemClasses, 1849, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        <a href=\"javascript:;\"");
            BeginWriteAttribute("class", " class=\"", 1897, "\"", 1917, 1);
#nullable restore
#line 57 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
WriteAttributeValue("", 1905, linkClasses, 1905, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 58 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
             if (!string.IsNullOrEmpty(Model.Icon))
            {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    <i");
            BeginWriteAttribute("class", " class=\"", 2031, "\"", 2072, 2);
            WriteAttributeValue("", 2039, "nav-icon", 2039, 8, true);
#nullable restore
#line 61 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
WriteAttributeValue(" ", 2047, Url.Content(Model.Icon), 2048, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\n                ");
#nullable restore
#line 62 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
                       
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>\n                ");
#nullable restore
#line 65 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
           Write(Model.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 66 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
                 if (LanguageManager.CurrentLanguage.IsRightToLeft)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <i class=\"fas fa-angle-right right\"></i>\n");
#nullable restore
#line 69 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <i class=\"fas fa-angle-left right\"></i>\n");
#nullable restore
#line 73 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </p>\n        </a>\n");
#nullable restore
#line 76 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
         if (hasSubMenus)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <ul class=\"nav nav-treeview\">\n");
#nullable restore
#line 79 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
                 foreach (var subMenu in subMenus)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
               Write(await Html.PartialAsync("Components/SideBarMenu/_MenuItem", subMenu));

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
                                                                                         
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\n");
#nullable restore
#line 84 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </li>\n");
#nullable restore
#line 86 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "/Users/mac/Desktop/XpremaERPX/src/Xprema.ERP.Web.Mvc/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml"
            
    static bool IsActiveMenuItem(UserMenuItem menuItem, string pageName)
    {
        if (string.IsNullOrWhiteSpace(pageName))
            return false;

        return pageName.Equals(menuItem.Name, StringComparison.InvariantCultureIgnoreCase)
            || menuItem.Items.Any(cn => IsActiveMenuItem(cn, pageName));
    }

    string CalculateMenuUrl(string url)
    {
        if (string.IsNullOrEmpty(url))
            return ApplicationPath;

        if (UrlChecker.IsRooted(url))
            return url;

        return ApplicationPath + url;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ILanguageManager LanguageManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Abp.Application.Navigation.UserMenuItem> Html { get; private set; }
    }
}
#pragma warning restore 1591
