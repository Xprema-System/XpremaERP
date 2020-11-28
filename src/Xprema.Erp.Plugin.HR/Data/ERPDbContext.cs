using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Xprema.ERP.Authorization.Roles;
using Xprema.ERP.Authorization.Users;
using Xprema.ERP.MultiTenancy;
using Xprema.Erp.Plugin.HR.Domains.Managments.Branchs;
using Xprema.Erp.Plugin.HR.Domains.Managments.Companies;
using Xprema.Erp.Plugin.HR.Domains.Managments.Profiles;
using Xprema.Erp.Plugin.HR.Managments.Branchs;

namespace Xprema.Erp.Plugin.HR.Data
{
    public   class ERPDbContext: AbpZeroDbContext<Tenant, Role, User, ERPDbContext>
    {

        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyAddress> CompanyAddresses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<BranchAddress> BranchAddresses { get; set; }

        public ERPDbContext(DbContextOptions<ERPDbContext> options)
            : base(options)
        {
        }
    }
}