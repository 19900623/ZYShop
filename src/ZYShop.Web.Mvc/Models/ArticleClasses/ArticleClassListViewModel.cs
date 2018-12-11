using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZYShop.ZYShop.Articles.Dtos;

namespace ZYShop.Web.Models.ArticleClasses
{
    public class ArticleClassListViewModel
    {
        public IReadOnlyList<ArticleClassListDto> ArticleClasses { get; set; }

    }
}
