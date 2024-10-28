using Microsoft.AspNetCore.Mvc;

namespace Shopping_Tutorial.Controllers
{
	public class CategoryController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
