using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnlineShopAspNet.Models;

namespace OnlineShopAspNet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
			return View();
		}

        public IActionResult Privacy()
        {
            return View();
        }


    }
}
