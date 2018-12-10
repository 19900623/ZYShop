
using AutoMapper;
using ZYShop.ZYShop.Articles;
using ZYShop.ZYShop.Articles.Dtos;

namespace ZYShop.ZYShop.Articles.Mapper
{

	/// <summary>
    /// 配置ArticleClass的AutoMapper
    /// </summary>
	internal static class ArticleClassMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <ArticleClass,ArticleClassListDto>();
            configuration.CreateMap <ArticleClassListDto,ArticleClass>();

            configuration.CreateMap <ArticleClassEditDto,ArticleClass>();
            configuration.CreateMap <ArticleClass,ArticleClassEditDto>();

        }
	}
}
