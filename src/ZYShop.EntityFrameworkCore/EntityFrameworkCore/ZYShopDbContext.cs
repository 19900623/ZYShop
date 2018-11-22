using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ZYShop.Authorization.Roles;
using ZYShop.Authorization.Users;
using ZYShop.MultiTenancy;

namespace ZYShop.EntityFrameworkCore
{
    public class ZYShopDbContext : AbpZeroDbContext<Tenant, Role, User, ZYShopDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ZYShopDbContext(DbContextOptions<ZYShopDbContext> options)
            : base(options)
        {
        }
    }
}
