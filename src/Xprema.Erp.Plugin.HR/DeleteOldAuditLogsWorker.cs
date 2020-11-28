using System;
using Abp.Auditing;
using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Threading.BackgroundWorkers;
using Abp.Threading.Timers;
using Abp.Timing;

namespace Xprema.Erp.Plugin.HR
{
    public class DeleteOldAuditLogsWorker: PeriodicBackgroundWorkerBase, ISingletonDependency
    {
        private readonly IRepository<AuditLog, long> _auditLogRepository;
        public DeleteOldAuditLogsWorker(AbpTimer timer,IRepository<AuditLog, long> auditLogRepository) : base(timer)
        {
            _auditLogRepository = auditLogRepository;
            Timer.Period = 5000;
        }

        [UnitOfWork]
        protected override void DoWork()
        {
            Logger.Info("---------------- DeleteOldAuditLogsWorker is working ----------------");

            using (CurrentUnitOfWork.DisableFilter(AbpDataFilters.MayHaveTenant))
            {
                var fiveMinutesAgo = Clock.Now.Subtract(TimeSpan.FromMinutes(5));

                _auditLogRepository.Delete(log => log.ExecutionTime > fiveMinutesAgo);

                CurrentUnitOfWork.SaveChanges();
            }
            
        }
    }
}