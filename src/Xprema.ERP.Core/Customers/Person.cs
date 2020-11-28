using System;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Xprema.ERP.Authorization.Users;
using Xprema.ERP.Common;

namespace Xprema.ERP.Customers
{
    public class Person :Entity<int>,IFullAudited<User>
    {
        public Name Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }



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