using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IRestaurant
    {
	    IEnumerable<Restaurant> GetAll();
    }
}
