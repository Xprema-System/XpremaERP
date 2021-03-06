using Abp.Domain.Entities.Auditing;
using Xprema.ERP.Authorization.Users;
using Xprema.ERP.Common;

namespace Xprema.Erp.Plugin.HR.Domains.Managments.Companies
{
    public class CompanyAddress:BaseEntity,IFullAudited<User>
    {
        public int AddressId { get; set; }
        public int CompanyId { get; set; }
        public virtual Address Address { get; set; }
        public virtual Company Company { get; set; }
    }
}