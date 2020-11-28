using Abp.Domain.Entities.Auditing;
using Xprema.ERP.Authorization.Users;
using Xprema.ERP.Common;
using Xprema.Erp.Plugin.HR.Domains.Managments.Branchs;

namespace Xprema.Erp.Plugin.HR.Managments.Branchs
{
    public class BranchAddress:BaseEntity,IFullAudited<User>
    {
        public int AddressId { get; set; }
        public int BranchId { get; set; }
        public virtual Address Address { get; set; }
        public virtual Branch Branch { get; set; }

    }
}