using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnlineShopAspNet.Models;

namespace OnlineShopAspNet.Controllers
{
    public class ProductController : Controller
    {
		Product cheburec = new Product("Чебурек", "С вишней", 80);
		Product pie = new Product("Пирожок", "с малинкой", 50);

		//public string Details()
		//{
		//    return cheburec.ToString();
		//}

		public IActionResult Details(int ind)
        {
			if(ind == 1)
				return View(pie);
			if(ind == 0)
				return View(cheburec);
			return View();
		}

        public IActionResult Catalog()
        {
            return View();
        }

    }
}
