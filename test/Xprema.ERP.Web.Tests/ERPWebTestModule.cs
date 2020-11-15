using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Xprema.ERP.EntityFrameworkCore;
using Xprema.ERP.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Xprema.ERP.Web.Tests
{
    [DependsOn(
        typeof(ERPWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ERPWebTestModule : AbpModule
    {
        public ERPWebTestModule(ERPEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ERPWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ERPWebMvcModule).Assembly);
        }
    }
}