using System;
using System.Diagnostics;
using System.Reflection;
using Abp.AspNetCore;
using Abp.AspNetCore.SignalR;
using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Threading.BackgroundWorkers;
using Abp.Zero.EntityFrameworkCore;
using Xprema.ERP;
using Xprema.ERP.EntityFrameworkCore;
using ERPDbContext = Xprema.Erp.Plugin.HR.Data.ERPDbContext;
using ERPDbContextConfigurer = Xprema.Erp.Plugin.HR.Data.ERPDbContextConfigurer;


namespace Xprema.Erp.Plugin.HR
{
    [DependsOn(
        typeof(ERPApplicationModule),
        typeof(ERPEntityFrameworkModule),
        typeof(AbpAspNetCoreModule)   ,
        typeof(ERPCoreModule),
        typeof(AbpZeroCoreEntityFrameworkCoreModule)
        ,typeof(AbpAspNetCoreSignalRModule)
    )]

    public class HrModule: AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void Initialize()
        {

            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            IocManager.RegisterAssemblyByConvention(typeof(ERPEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            var workManager = IocManager.Resolve<IBackgroundWorkerManager>();
            workManager.Add(IocManager.Resolve<DeleteOldAuditLogsWorker>());
            Console.WriteLine("Module is Loaded ........");
            Debug.Flush();
            Debug.WriteLine("Plugin is Loaded .........");

            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<ERPDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        ERPDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        ERPDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }
    }
}