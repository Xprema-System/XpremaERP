using Abp.MultiTenancy;
using Xprema.ERP.Authorization.Users;

namespace Xprema.ERP.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
