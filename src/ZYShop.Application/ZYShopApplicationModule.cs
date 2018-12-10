using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ZYShop.Authorization;
using ZYShop.ZYShop.Articles.Authorization;
using ZYShop.ZYShop.Articles.Mapper;

namespace ZYShop
{
    [DependsOn(
        typeof(ZYShopCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ZYShopApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            // 配置权限功能
            Configuration.Authorization.Providers.Add<ZYShopAuthorizationProvider>();
            Configuration.Authorization.Providers.Add<ArticleAuthorizationProvider>();
            Configuration.Authorization.Providers.Add<ArticleClassAuthorizationProvider>();

            // 自定义类型映射
            Configuration.Modules.AbpAutoMapper().Configurators.Add(configuration =>
            {
                ArticleMapper.CreateMappings(configuration);
                ArticleClassMapper.CreateMappings(configuration);
            });

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
