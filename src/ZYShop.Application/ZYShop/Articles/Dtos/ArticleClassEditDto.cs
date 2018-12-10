
using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using ZYShop.ZYShop.Articles;

namespace  ZYShop.ZYShop.Articles.Dtos
{
    public class ArticleClassEditDto
    {

        /// <summary>
        /// Id
        /// </summary>
        public int? Id { get; set; }         


        
		/// <summary>
		/// FatherId
		/// </summary>
		public int FatherId { get; set; }



		/// <summary>
		/// OrderId
		/// </summary>
		public int OrderId { get; set; }



		/// <summary>
		/// ClassName
		/// </summary>
[MaxLength(ZYShopConsts.MaxLength64)]
		[Required(ErrorMessage="ClassName不能为空")]
		public string ClassName { get; set; }



		/// <summary>
		/// Description
		/// </summary>
		public string Description { get; set; }



		/// <summary>
		/// IsSystem
		/// </summary>
		public int IsSystem { get; set; }




    }
}