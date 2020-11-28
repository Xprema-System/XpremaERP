 
using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Xprema.Erp.Plugin.HR.Domains.Managments.Companies;

namespace Xprema.ERP.TableMapping
{
    public class CompanyMap
    {
        public static void MapCompany(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .HasOne(p => p.Address);

            modelBuilder.Entity<Company>()
                .HasMany(p => p.Branches)
                .WithOne(p => p.Company)
                .HasForeignKey(p => p.CompanyId)
                .OnDelete(DeleteBehavior.SetNull);

        }
    }
}