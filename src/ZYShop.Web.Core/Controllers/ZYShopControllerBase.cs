using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ZYShop.Controllers
{
    public abstract class ZYShopControllerBase: AbpController
    {
        protected ZYShopControllerBase()
        {
            LocalizationSourceName = ZYShopConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
