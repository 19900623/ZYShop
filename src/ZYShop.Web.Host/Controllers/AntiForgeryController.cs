using Microsoft.AspNetCore.Antiforgery;
using ZYShop.Controllers;

namespace ZYShop.Web.Host.Controllers
{
    public class AntiForgeryController : ZYShopControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
