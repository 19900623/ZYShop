

using System.Linq;
using Abp.Authorization;
using Abp.Configuration.Startup;
using Abp.Localization;
using Abp.MultiTenancy;
using ZYShop.Authorization;

namespace ZYShop.ZYShop.Articles.Authorization
{
    /// <summary>
    /// 权限配置都在这里。
    /// 给权限默认设置服务
    /// See <see cref="ArticlePermissions" /> for all permission names. Article
    ///</summary>
    public class ArticleAuthorizationProvider : AuthorizationProvider
    {
        private readonly bool _isMultiTenancyEnabled;

		public ArticleAuthorizationProvider()
		{

		}

        public ArticleAuthorizationProvider(bool isMultiTenancyEnabled)
        {
            _isMultiTenancyEnabled = isMultiTenancyEnabled;
        }

        public ArticleAuthorizationProvider(IMultiTenancyConfig multiTenancyConfig)
        {
            _isMultiTenancyEnabled = multiTenancyConfig.IsEnabled;
        }

		public override void SetPermissions(IPermissionDefinitionContext context)
		{
			// 在这里配置了Article 的权限。
			var pages = context.GetPermissionOrNull(AppLtmPermissions.Pages) ?? context.CreatePermission(AppLtmPermissions.Pages, L("Pages"));

			var administration = pages.Children.FirstOrDefault(p => p.Name == AppLtmPermissions.Pages_Administration) ?? pages.CreateChildPermission(AppLtmPermissions.Pages_Administration, L("Administration"));

			var entityPermission = administration.CreateChildPermission(ArticlePermissions.Node , L("Article"));
			entityPermission.CreateChildPermission(ArticlePermissions.Query, L("QueryArticle"));
			entityPermission.CreateChildPermission(ArticlePermissions.Create, L("CreateArticle"));
			entityPermission.CreateChildPermission(ArticlePermissions.Edit, L("EditArticle"));
			entityPermission.CreateChildPermission(ArticlePermissions.Delete, L("DeleteArticle"));
			entityPermission.CreateChildPermission(ArticlePermissions.BatchDelete, L("BatchDeleteArticle"));
			entityPermission.CreateChildPermission(ArticlePermissions.ExportExcel, L("ExportExcelArticle"));


		}

		private static ILocalizableString L(string name)
		{
			return new LocalizableString(name, ZYShopConsts.LocalizationSourceName);
		}
    }
}