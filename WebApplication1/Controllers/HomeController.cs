using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			var model = new Restaurant
			{
				Id = 1,
				Name = "Tottoli's Pizza"
			};

			return new ObjectResult(model);
		}
	}
}
