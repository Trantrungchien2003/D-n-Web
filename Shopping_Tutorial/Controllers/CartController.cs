using Microsoft.AspNetCore.Mvc;

namespace Shopping_Tutorial.Controllers
{
    public class CartController : Controller
    {
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Checkout()
		{
			return View("~/Views/checkout/Index.cshtml");
		}
	}
}
