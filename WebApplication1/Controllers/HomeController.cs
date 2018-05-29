using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

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
			List<Restaurant> model = _restaurantService.GetAll().ToList();

			return View(model);
		}
	}
}
