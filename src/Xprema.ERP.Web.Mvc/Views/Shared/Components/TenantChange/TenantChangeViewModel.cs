using Abp.AutoMapper;
using Xprema.ERP.Sessions.Dto;

namespace Xprema.ERP.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
