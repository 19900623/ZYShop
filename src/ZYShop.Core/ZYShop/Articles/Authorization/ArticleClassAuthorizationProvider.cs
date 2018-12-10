

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
    /// See <see cref="ArticleClassPermissions" /> for all permission names. ArticleClass
    ///</summary>
    public class ArticleClassAuthorizationProvider : AuthorizationProvider
    {
        private readonly bool _isMultiTenancyEnabled;

		public ArticleClassAuthorizationProvider()
		{

		}

        public ArticleClassAuthorizationProvider(bool isMultiTenancyEnabled)
        {
            _isMultiTenancyEnabled = isMultiTenancyEnabled;
        }

        public ArticleClassAuthorizationProvider(IMultiTenancyConfig multiTenancyConfig)
        {
            _isMultiTenancyEnabled = multiTenancyConfig.IsEnabled;
        }

		public override void SetPermissions(IPermissionDefinitionContext context)
		{
			// 在这里配置了ArticleClass 的权限。
			var pages = context.GetPermissionOrNull(AppLtmPermissions.Pages) ?? context.CreatePermission(AppLtmPermissions.Pages, L("Pages"));

			var administration = pages.Children.FirstOrDefault(p => p.Name == AppLtmPermissions.Pages_Administration) ?? pages.CreateChildPermission(AppLtmPermissions.Pages_Administration, L("Administration"));

			var entityPermission = administration.CreateChildPermission(ArticleClassPermissions.Node , L("ArticleClass"));
			entityPermission.CreateChildPermission(ArticleClassPermissions.Query, L("QueryArticleClass"));
			entityPermission.CreateChildPermission(ArticleClassPermissions.Create, L("CreateArticleClass"));
			entityPermission.CreateChildPermission(ArticleClassPermissions.Edit, L("EditArticleClass"));
			entityPermission.CreateChildPermission(ArticleClassPermissions.Delete, L("DeleteArticleClass"));
			entityPermission.CreateChildPermission(ArticleClassPermissions.BatchDelete, L("BatchDeleteArticleClass"));
			entityPermission.CreateChildPermission(ArticleClassPermissions.ExportExcel, L("ExportExcelArticleClass"));


		}

		private static ILocalizableString L(string name)
		{
			return new LocalizableString(name, ZYShopConsts.LocalizationSourceName);
		}
    }
}