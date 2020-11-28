using System.Collections.Generic;
using Abp.Domain.Entities.Auditing;
using Xprema.ERP.Authorization.Users;
using Xprema.ERP.Common;
using Xprema.Erp.Plugin.HR.Domains.Managments.Branchs;

namespace Xprema.Erp.Plugin.HR.Domains.Managments.Companies
{
    public class Company  :BaseEntity,IFullAudited<User>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual CompanyAddress Address { get; set; }
        public string Logo { get; set; }
        public virtual IList<Branch> Branches { get; set; }

        public Company()
        {
            Branches =new List<Branch>();
        }

    }
}