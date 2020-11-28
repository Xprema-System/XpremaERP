using Abp.Domain.Entities.Auditing;
using Xprema.ERP.Authorization.Users;

namespace Xprema.ERP.Common
{
    public class Country :BaseEntity,IFullAudited<User>
    {
        public string CountryName { get; set; }
        public string Code { get; set; }
        public string Flag { get; set; }

    }
}