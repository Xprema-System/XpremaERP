using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Xprema.ERP.Configuration.Dto;

namespace Xprema.ERP.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ERPAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
