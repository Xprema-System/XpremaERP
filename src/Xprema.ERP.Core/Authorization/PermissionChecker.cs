using Abp.Authorization;
using Xprema.ERP.Authorization.Roles;
using Xprema.ERP.Authorization.Users;

namespace Xprema.ERP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
