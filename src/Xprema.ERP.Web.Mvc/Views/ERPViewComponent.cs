using Abp.AspNetCore.Mvc.ViewComponents;

namespace Xprema.ERP.Web.Views
{
    public abstract class ERPViewComponent : AbpViewComponent
    {
        protected ERPViewComponent()
        {
            LocalizationSourceName = ERPConsts.LocalizationSourceName;
        }
    }
}
