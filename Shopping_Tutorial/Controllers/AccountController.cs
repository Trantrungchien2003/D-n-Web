using Microsoft.AspNetCore.Mvc;

namespace Shopping_Tutorial.Controllers
{
	public class AccountController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
