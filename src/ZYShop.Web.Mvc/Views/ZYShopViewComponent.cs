using Abp.AspNetCore.Mvc.ViewComponents;

namespace ZYShop.Web.Views
{
    public abstract class ZYShopViewComponent : AbpViewComponent
    {
        protected ZYShopViewComponent()
        {
            LocalizationSourceName = ZYShopConsts.LocalizationSourceName;
        }
    }
}
