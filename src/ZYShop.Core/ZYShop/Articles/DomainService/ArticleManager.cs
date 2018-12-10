

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
    /// Article领域层的业务管理
    ///</summary>
    public class ArticleManager :ZYShopDomainServiceBase, IArticleManager
    {
		
		private readonly IRepository<Article,int> _repository;

		/// <summary>
		/// Article的构造方法
		///</summary>
		public ArticleManager(
			IRepository<Article, int> repository
		)
		{
			_repository =  repository;
		}


		/// <summary>
		/// 初始化
		///</summary>
		public void InitArticle()
		{
			throw new NotImplementedException();
		}

		// TODO:编写领域业务代码



		 
		  
		 

	}
}
