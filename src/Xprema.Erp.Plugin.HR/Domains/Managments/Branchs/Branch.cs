using Abp.Domain.Entities.Auditing;
using Xprema.ERP.Authorization.Users;
using Xprema.ERP.Common;
using Xprema.Erp.Plugin.HR.Domains.Managments.Companies;
using Xprema.Erp.Plugin.HR.Managments.Branchs;

namespace Xprema.Erp.Plugin.HR.Domains.Managments.Branchs
{
    public class Branch  :BaseEntity,IFullAudited<User>
    {
        public int? CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public string BranchName { get; set; }
        public string Description { get; set; }
        public bool IsInSameCompanyLocation { get; set; }
        public virtual BranchAddress BranchAddress { get; set; }

        public Branch()
        {
            
        }
    }
}