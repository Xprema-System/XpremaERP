using System.Collections.Generic;
using Xprema.ERP.Roles.Dto;

namespace Xprema.ERP.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}