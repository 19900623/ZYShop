using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace ZYShop.Web.Views
{
    public abstract class ZYShopRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ZYShopRazorPage()
        {
            LocalizationSourceName = ZYShopConsts.LocalizationSourceName;
        }
    }
}
