using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ZYShop.Authorization.Roles;
using ZYShop.Authorization.Users;
using ZYShop.MultiTenancy;
using ZYShop.ZYShop.Articles;
using ZYShop.EntityMapper.Articles;
using ZYShop.EntityMapper.ArticleClasss;

namespace ZYShop.EntityFrameworkCore
{
    public class ZYShopDbContext : AbpZeroDbContext<Tenant, Role, User, ZYShopDbContext>
    {
        /* Define a DbSet for each entity of the application */

        
        public ZYShopDbContext(DbContextOptions<ZYShopDbContext> options)
            : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }

        public DbSet<ArticleClass> ArticleClasses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleCfg());
            modelBuilder.ApplyConfiguration(new ArticleClassCfg());
            base.OnModelCreating(modelBuilder);
        }
    }
}
