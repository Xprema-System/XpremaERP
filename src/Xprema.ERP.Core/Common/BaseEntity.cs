using System;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Xprema.ERP.Authorization.Users;

namespace Xprema.ERP.Common
{
    public class BaseEntity  :Entity<int> ,IFullAudited<User>
    {

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

    }
}