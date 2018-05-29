using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
	public class HomeController : Controller
	{
		private readonly IRestaurant _restaurantService;
		public HomeController(IRestaurant restaurantService)
		{
			_restaurantService = restaurantService;
		}
		public IActionResult Index()
		{
			var model = new HomeIndexViewModel { Restaurants = _restaurantService.GetAll().ToList() };

			return View(model);
		}
	}
}
