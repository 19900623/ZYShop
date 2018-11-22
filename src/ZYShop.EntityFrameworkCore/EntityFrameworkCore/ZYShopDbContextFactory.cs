using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ZYShop.Configuration;
using ZYShop.Web;

namespace ZYShop.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ZYShopDbContextFactory : IDesignTimeDbContextFactory<ZYShopDbContext>
    {
        public ZYShopDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ZYShopDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ZYShopDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ZYShopConsts.ConnectionStringName));

            return new ZYShopDbContext(builder.Options);
        }
    }
}
