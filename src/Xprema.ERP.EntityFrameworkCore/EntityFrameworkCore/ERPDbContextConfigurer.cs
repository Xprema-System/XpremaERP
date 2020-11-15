using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Xprema.ERP.EntityFrameworkCore
{
    public static class ERPDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ERPDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ERPDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
