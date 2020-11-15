using Abp.AutoMapper;
using Xprema.ERP.Authentication.External;

namespace Xprema.ERP.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
