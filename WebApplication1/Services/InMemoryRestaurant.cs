using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
	public class InMemoryRestaurant : IRestaurant
	{
		readonly List<Restaurant> _restaurants;
		public InMemoryRestaurant()
		{
			_restaurants = new List<Restaurant>
			{
				new Restaurant{Id =1, Name="Pizza"},
				new Restaurant{Id =2, Name="Sushi"},
				new Restaurant{Id =3, Name="Italian"},
				new Restaurant{Id =4, Name="Spanic"},
			};
		}

		public IEnumerable<Restaurant> GetAll()
		{
			return _restaurants;
		}
	}
}
