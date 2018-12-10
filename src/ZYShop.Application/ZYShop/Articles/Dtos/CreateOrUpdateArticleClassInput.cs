

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ZYShop.ZYShop.Articles;

namespace ZYShop.ZYShop.Articles.Dtos
{
    public class CreateOrUpdateArticleClassInput
    {
        [Required]
        public ArticleClassEditDto ArticleClass { get; set; }

    }
}