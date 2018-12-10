

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZYShop.ZYShop.Articles;

namespace ZYShop.EntityMapper.ArticleClasss
{
    public class ArticleClassCfg : IEntityTypeConfiguration<ArticleClass>
    {
        public void Configure(EntityTypeBuilder<ArticleClass> builder)
        {

            builder.ToTable("ArticleClasss", YoYoAbpefCoreConsts.SchemaNames.ZY);

            
			builder.Property(a => a.FatherId).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
			builder.Property(a => a.OrderId);
			builder.Property(a => a.ClassName).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
			builder.Property(a => a.Description).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length256);
			builder.Property(a => a.IsSystem);


        }
    }
}


