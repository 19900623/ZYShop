using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ZYShop.MultiTenancy.Dto;

namespace ZYShop.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
