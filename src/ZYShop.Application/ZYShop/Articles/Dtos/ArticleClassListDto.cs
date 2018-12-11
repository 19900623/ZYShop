using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace ZYShop.ZYShop.Articles.Dtos
{
    public class ArticleClassListDto : FullAuditedEntityDto<int>
    {


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
        [Required(ErrorMessage = "ClassName不能为空")]
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