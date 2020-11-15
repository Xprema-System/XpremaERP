using System.Collections.Generic;
using Xprema.ERP.Roles.Dto;

namespace Xprema.ERP.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
