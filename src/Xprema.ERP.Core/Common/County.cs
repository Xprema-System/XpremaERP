using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Xprema.ERP.Authorization.Users;

namespace Xprema.ERP.Common
{
    public class County :BaseEntity,IFullAudited<User> ,IEntityTranslation
    {
        public string CountyName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int CountryId   { get; set; }
        public Country Country { get; set; }
        public string Language { get; set; }
    }
}