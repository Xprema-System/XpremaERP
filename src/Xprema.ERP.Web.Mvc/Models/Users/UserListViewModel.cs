using System.Collections.Generic;
using Xprema.ERP.Roles.Dto;

namespace Xprema.ERP.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
