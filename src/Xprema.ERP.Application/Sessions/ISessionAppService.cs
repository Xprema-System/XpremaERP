using System.Threading.Tasks;
using Abp.Application.Services;
using Xprema.ERP.Sessions.Dto;

namespace Xprema.ERP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
