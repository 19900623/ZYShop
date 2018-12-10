

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZYShop.ZYShop.Articles;

namespace ZYShop.EntityMapper.Articles
{
    public class ArticleCfg : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {

            builder.ToTable("Articles", YoYoAbpefCoreConsts.SchemaNames.ZY);

            
			builder.Property(a => a.Title).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
			builder.Property(a => a.ClassId).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
			builder.Property(a => a.IsTop).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
			builder.Property(a => a.Author).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length128);
			builder.Property(a => a.Resource).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length128);
			builder.Property(a => a.Keywords).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length128);
			builder.Property(a => a.Url).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length256);
			builder.Property(a => a.Photo).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length256);
			builder.Property(a => a.Summary);
			builder.Property(a => a.Content);
			builder.Property(a => a.PublishDate);


        }
    }
}


