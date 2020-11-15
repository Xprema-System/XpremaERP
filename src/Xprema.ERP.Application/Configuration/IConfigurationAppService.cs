using System.Threading.Tasks;
using Xprema.ERP.Configuration.Dto;

namespace Xprema.ERP.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
