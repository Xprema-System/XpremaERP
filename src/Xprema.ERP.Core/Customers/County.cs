using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Xprema.ERP.Authorization.Users;

namespace Xprema.ERP.Customers
{
    public class County :Entity<int>,IFullAudited<User> ,IEntityTranslation
    {
        public string Name { get; set; }
        public string Code { get; set; }

        #region relationShips

        public int  CountryId { get; set; }
        [ForeignKey(nameof(CountryId))]
        public virtual Country Country { get; set; }

        #endregion

        #region Audited

        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public User CreatorUser { get; set; }
        public User LastModifierUser { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletionTime { get; set; }
        public long? DeleterUserId { get; set; }
        public User DeleterUser { get; set; }
        public string Language { get; set; }

        #endregion
        
    }
}