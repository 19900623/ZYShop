using System.Threading.Tasks;
using Abp.Application.Services;
using ZYShop.Sessions.Dto;

namespace ZYShop.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
