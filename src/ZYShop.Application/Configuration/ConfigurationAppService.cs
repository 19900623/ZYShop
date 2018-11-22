using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ZYShop.Configuration.Dto;

namespace ZYShop.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ZYShopAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
