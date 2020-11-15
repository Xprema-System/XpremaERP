using System.Threading.Tasks;
using Abp.Application.Services;
using Xprema.ERP.Authorization.Accounts.Dto;

namespace Xprema.ERP.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
