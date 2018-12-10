

using System;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using ZYShop.ZYShop.Articles;

namespace ZYShop.ZYShop.Articles.Dtos
{
    public class ArticleListDto : FullAuditedEntityDto<int>
    {


        /// <summary>
        /// Title
        /// </summary>
        [MaxLength(ZYShopConsts.MaxLength256)]
        [Required(ErrorMessage = "Title不能为空")]
        public string Title { get; set; }



        /// <summary>
        /// ClassId
        /// </summary>
        [Required(ErrorMessage = "ClassId不能为空")]
        public string ClassId { get; set; }



        /// <summary>
        /// IsTop
        /// </summary>
        public int IsTop { get; set; }



        /// <summary>
        /// Author
        /// </summary>
        public string Author { get; set; }



        /// <summary>
        /// Resource
        /// </summary>
        public string Resource { get; set; }



        /// <summary>
        /// Keywords
        /// </summary>
        public string Keywords { get; set; }



        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; }



        /// <summary>
        /// Photo
        /// </summary>
        public string Photo { get; set; }



        /// <summary>
        /// Summary
        /// </summary>
        public string Summary { get; set; }



        /// <summary>
        /// Content
        /// </summary>
        public string Content { get; set; }



        /// <summary>
        /// PublishDate
        /// </summary>
        public DateTime PublishDate { get; set; }




    }
}