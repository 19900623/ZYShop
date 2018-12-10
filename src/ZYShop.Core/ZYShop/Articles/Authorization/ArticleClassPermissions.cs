

namespace ZYShop.ZYShop.Articles.Authorization
{
	/// <summary>
    /// 定义系统的权限名称的字符串常量。
    /// <see cref="ArticleClassAuthorizationProvider" />中对权限的定义.
    ///</summary>
	public static  class ArticleClassPermissions
	{
		/// <summary>
		/// ArticleClass权限节点
		///</summary>
		public const string Node = "Pages.ArticleClass";

		/// <summary>
		/// ArticleClass查询授权
		///</summary>
		public const string Query = "Pages.ArticleClass.Query";

		/// <summary>
		/// ArticleClass创建权限
		///</summary>
		public const string Create = "Pages.ArticleClass.Create";

		/// <summary>
		/// ArticleClass修改权限
		///</summary>
		public const string Edit = "Pages.ArticleClass.Edit";

		/// <summary>
		/// ArticleClass删除权限
		///</summary>
		public const string Delete = "Pages.ArticleClass.Delete";

        /// <summary>
		/// ArticleClass批量删除权限
		///</summary>
		public const string BatchDelete = "Pages.ArticleClass.BatchDelete";

		/// <summary>
		/// ArticleClass导出Excel
		///</summary>
		public const string ExportExcel="Pages.ArticleClass.ExportExcel";

		 
		 
         
    }

}

