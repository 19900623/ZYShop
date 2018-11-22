using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ZYShop.Controllers;

namespace ZYShop.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : ZYShopControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
