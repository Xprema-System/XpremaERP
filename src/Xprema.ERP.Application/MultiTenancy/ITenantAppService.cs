using Abp.Application.Services;
using Xprema.ERP.MultiTenancy.Dto;

namespace Xprema.ERP.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

