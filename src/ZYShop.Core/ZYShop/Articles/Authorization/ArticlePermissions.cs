

namespace ZYShop.ZYShop.Articles.Authorization
{
	/// <summary>
    /// 定义系统的权限名称的字符串常量。
    /// <see cref="ArticleAuthorizationProvider" />中对权限的定义.
    ///</summary>
	public static  class ArticlePermissions
	{
		/// <summary>
		/// Article权限节点
		///</summary>
		public const string Node = "Pages.Article";

		/// <summary>
		/// Article查询授权
		///</summary>
		public const string Query = "Pages.Article.Query";

		/// <summary>
		/// Article创建权限
		///</summary>
		public const string Create = "Pages.Article.Create";

		/// <summary>
		/// Article修改权限
		///</summary>
		public const string Edit = "Pages.Article.Edit";

		/// <summary>
		/// Article删除权限
		///</summary>
		public const string Delete = "Pages.Article.Delete";

        /// <summary>
		/// Article批量删除权限
		///</summary>
		public const string BatchDelete = "Pages.Article.BatchDelete";

		/// <summary>
		/// Article导出Excel
		///</summary>
		public const string ExportExcel="Pages.Article.ExportExcel";

		 
		 
         
    }

}

