using Abp.Domain.Entities.Auditing;
using Xprema.ERP.Authorization.Users;

namespace Xprema.ERP.Common
{
    public class Address  :BaseEntity,IFullAudited<User>
    {
        public int CountryId { get; set; }
        public int CountyId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }


    }
}