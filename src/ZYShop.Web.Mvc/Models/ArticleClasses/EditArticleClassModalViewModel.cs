using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZYShop.ZYShop.Articles.Dtos;

namespace ZYShop.Web.Models.ArticleClasses
{
    [AutoMapFrom(typeof(GetArticleClassForEditOutput))]
    public class EditArticleClassModalViewModel:GetArticleClassForEditOutput
    {
        public EditArticleClassModalViewModel(GetArticleClassForEditOutput output)
        {
            output.MapTo(this);
        }
    }
}
