using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Xprema.ERP.Authorization.Roles;
using Xprema.ERP.Authorization.Users;
using Xprema.ERP.Customers;
using Xprema.ERP.Managments;
using Xprema.ERP.MultiTenancy;
using Address = Xprema.ERP.Common.Address;
using Country = Xprema.ERP.Common.Country;
using County = Xprema.ERP.Common.County;

namespace Xprema.ERP.EntityFrameworkCore
{
    public class ERPDbContext : AbpZeroDbContext<Tenant, Role, User, ERPDbContext>
    {
        /* Define a DbSet for each entity of the application */

       // public DbSet<Person> Persons { get; set; }

        #region Commons
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<County> Counties { get; set; }
        

        #endregion

        #region Managment

        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyAddress> CompanyAddresses { get; set; }


        #endregion
       
        public ERPDbContext(DbContextOptions<ERPDbContext> options)
            : base(options)
        {
        }
    }
}
