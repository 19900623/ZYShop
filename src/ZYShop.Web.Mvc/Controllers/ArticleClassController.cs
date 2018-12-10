using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZYShop.Controllers;

namespace ZYShop.Web.Mvc.Controllers
{
    public class ArticleClassController : ZYShopControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}