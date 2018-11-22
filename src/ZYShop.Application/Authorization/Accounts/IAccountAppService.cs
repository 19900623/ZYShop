using System.Threading.Tasks;
using Abp.Application.Services;
using ZYShop.Authorization.Accounts.Dto;

namespace ZYShop.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
