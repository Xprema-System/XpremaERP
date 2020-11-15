using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Xprema.ERP.Controllers
{
    public abstract class ERPControllerBase: AbpController
    {
        protected ERPControllerBase()
        {
            LocalizationSourceName = ERPConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
