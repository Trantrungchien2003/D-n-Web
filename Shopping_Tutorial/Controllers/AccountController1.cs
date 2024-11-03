using Microsoft.AspNetCore.Mvc;

namespace Shopping_Tutorial.Controllers
{
	public class AccountController1 : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
