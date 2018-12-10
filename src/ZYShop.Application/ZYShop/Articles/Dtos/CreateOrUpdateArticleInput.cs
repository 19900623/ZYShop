

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ZYShop.ZYShop.Articles;

namespace ZYShop.ZYShop.Articles.Dtos
{
    public class CreateOrUpdateArticleInput
    {
        [Required]
        public ArticleEditDto Article { get; set; }

    }
}