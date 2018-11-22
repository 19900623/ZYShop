using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ZYShop.Controllers;

namespace ZYShop.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ZYShopControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
