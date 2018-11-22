using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ZYShop.Configuration;

namespace ZYShop.Web.Host.Startup
{
    [DependsOn(
       typeof(ZYShopWebCoreModule))]
    public class ZYShopWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ZYShopWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ZYShopWebHostModule).GetAssembly());
        }
    }
}
