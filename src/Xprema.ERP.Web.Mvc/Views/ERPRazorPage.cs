using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Xprema.ERP.Web.Views
{
    public abstract class ERPRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ERPRazorPage()
        {
            LocalizationSourceName = ERPConsts.LocalizationSourceName;
        }
    }
}
