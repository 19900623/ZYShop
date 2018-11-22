using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ZYShop.Authorization;

namespace ZYShop
{
    [DependsOn(
        typeof(ZYShopCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ZYShopApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ZYShopAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ZYShopApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
