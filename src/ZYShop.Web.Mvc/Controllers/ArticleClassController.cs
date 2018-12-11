using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ZYShop.Controllers;
using ZYShop.Web.Models.ArticleClasses;
using ZYShop.ZYShop.Articles;
using ZYShop.ZYShop.Articles.Dtos;

namespace ZYShop.Web.Mvc.Controllers
{
    public class ArticleClassController : ZYShopControllerBase
    {
        private readonly IArticleClassAppService _articleClassAppService;

        /// <summary>
        /// 构造注入
        /// </summary>
        /// <param name="articleClassAppService"></param>
        public ArticleClassController(IArticleClassAppService articleClassAppService)
        {
            _articleClassAppService = articleClassAppService;
        }

        public async Task<ActionResult> Index()
        {
            var articleClassList = (await _articleClassAppService.GetPaged(new GetArticleClasssInput())).Items;
            var model = new ArticleClassListViewModel
            {
                ArticleClasses = articleClassList
            };
            return View(model);
        }
    }
}