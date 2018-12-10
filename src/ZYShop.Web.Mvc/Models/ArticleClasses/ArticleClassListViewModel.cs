using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZYShop.ZYShop.Articles;

namespace ZYShop.Web.Models.ArticleClasses
{
    public class ArticleClassListViewModel
    {
        public IReadOnlyList<ArticleClass> ArticleClasses { get; set; }

    }
}
