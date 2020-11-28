using Abp.Domain.Entities.Auditing;
using Xprema.ERP.Authorization.Users;
using Xprema.ERP.Common;

namespace Xprema.Erp.Plugin.HR.Domains.Managments.Profiles
{
    public class Department :BaseEntity,IFullAudited<User>
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
}