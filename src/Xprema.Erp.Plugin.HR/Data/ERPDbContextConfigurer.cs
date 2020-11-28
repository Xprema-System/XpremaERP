using System;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace Xprema.Erp.Plugin.HR.Data
{
    public static class ERPDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ERPDbContext> builder, string connectionString)
        {
           // builder.UseSqlServer(connectionString);
           builder.UseMySql(connectionString,mySqlOptionsAction => mySqlOptionsAction.ServerVersion(new Version(8, 0, 22), ServerType.MySql));
        }

        public static void Configure(DbContextOptionsBuilder<ERPDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            builder.UseMySql(connection,mySqlOptionsAction => mySqlOptionsAction.ServerVersion(new Version(8, 0, 22), ServerType.MySql));
        }
    }
}
