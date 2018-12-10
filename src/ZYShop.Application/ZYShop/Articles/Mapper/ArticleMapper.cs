
using AutoMapper;
using ZYShop.ZYShop.Articles;
using ZYShop.ZYShop.Articles.Dtos;

namespace ZYShop.ZYShop.Articles.Mapper
{

	/// <summary>
    /// 配置Article的AutoMapper
    /// </summary>
	internal static class ArticleMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <Article,ArticleListDto>();
            configuration.CreateMap <ArticleListDto,Article>();

            configuration.CreateMap <ArticleEditDto,Article>();
            configuration.CreateMap <Article,ArticleEditDto>();

        }
	}
}
