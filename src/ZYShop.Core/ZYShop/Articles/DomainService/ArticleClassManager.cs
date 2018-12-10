

using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Abp.Linq;
using Abp.Linq.Extensions;
using Abp.Extensions;
using Abp.UI;
using Abp.Domain.Repositories;
using Abp.Domain.Services;

using ZYShop;
using ZYShop.ZYShop.Articles;


namespace ZYShop.ZYShop.Articles.DomainService
{
    /// <summary>
    /// ArticleClass领域层的业务管理
    ///</summary>
    public class ArticleClassManager :ZYShopDomainServiceBase, IArticleClassManager
    {
		
		private readonly IRepository<ArticleClass,int> _repository;

		/// <summary>
		/// ArticleClass的构造方法
		///</summary>
		public ArticleClassManager(
			IRepository<ArticleClass, int> repository
		)
		{
			_repository =  repository;
		}


		/// <summary>
		/// 初始化
		///</summary>
		public void InitArticleClass()
		{
			throw new NotImplementedException();
		}

		// TODO:编写领域业务代码



		 
		  
		 

	}
}
