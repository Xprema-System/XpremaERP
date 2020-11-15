using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Xprema.ERP.Authorization.Roles;
using Xprema.ERP.Authorization.Users;
using Xprema.ERP.MultiTenancy;

namespace Xprema.ERP.EntityFrameworkCore
{
    public class ERPDbContext : AbpZeroDbContext<Tenant, Role, User, ERPDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ERPDbContext(DbContextOptions<ERPDbContext> options)
            : base(options)
        {
        }
    }
}
