using System.Threading.Tasks;
using ZYShop.Configuration.Dto;

namespace ZYShop.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
