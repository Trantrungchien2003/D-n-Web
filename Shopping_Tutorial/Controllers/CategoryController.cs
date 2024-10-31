using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shopping_Tutorial.Models;
using Shopping_Tutorial.Repository;

namespace Shopping_Tutorial.Controllers
{
	public class CategoryController : Controller
	{
		private readonly DataContext _dataContext;
		public CategoryController(DataContext context)
		{
			_dataContext = context;
		}
		public async Task<IActionResult> Index(string slug="")
		{
			CategoryModel category = _dataContext.Categories.Where(c => c.slug == slug).FirstOrDefault();

			if (category == null) return RedirectToAction("Index");

			var productsByCategory = _dataContext.Products.Where(c => c.CategoryId == category.Id);

			return View(await productsByCategory.OrderByDescending(c => c.Id).ToListAsync());
		}
	}
}
