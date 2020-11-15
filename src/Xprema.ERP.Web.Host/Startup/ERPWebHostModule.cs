using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Xprema.ERP.Configuration;

namespace Xprema.ERP.Web.Host.Startup
{
    [DependsOn(
       typeof(ERPWebCoreModule))]
    public class ERPWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ERPWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ERPWebHostModule).GetAssembly());
        }
    }
}
