

using System;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Services;
using ZYShop.ZYShop.Articles;


namespace ZYShop.ZYShop.Articles.DomainService
{
    public interface IArticleManager : IDomainService
    {

        /// <summary>
        /// 初始化方法
        ///</summary>
        void InitArticle();



		 
      
         

    }
}
