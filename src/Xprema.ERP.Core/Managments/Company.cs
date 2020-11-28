using Abp.Domain.Entities.Auditing;
using Xprema.ERP.Authorization.Users;
using Xprema.ERP.Common;

namespace Xprema.ERP.Managments
{
    public class Company  :BaseEntity,IFullAudited<User>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual CompanyAddress Address { get; set; }
        public string Logo { get; set; }

    }
}