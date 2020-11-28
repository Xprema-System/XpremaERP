using System;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Xprema.ERP.Authorization.Users;
using Xprema.ERP.Common;

namespace Xprema.ERP.Customers
{
    public class Country :BaseEntity,IFullAudited<User> ,IEntityTranslation
    {

        public string Language { get; set; }
    }
}