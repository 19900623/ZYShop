using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ZYShop.EntityFrameworkCore
{
    public static class ZYShopDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ZYShopDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ZYShopDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
