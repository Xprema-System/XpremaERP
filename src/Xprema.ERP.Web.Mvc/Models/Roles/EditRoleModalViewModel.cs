using Abp.AutoMapper;
using Xprema.ERP.Roles.Dto;
using Xprema.ERP.Web.Models.Common;

namespace Xprema.ERP.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
