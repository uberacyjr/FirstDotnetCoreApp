using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
	[Route("[controller]/[action]")]
    public class AboutController
    {
		public string Address() => "USA";
		public string Phone()
	    {
		    return "335484";
	    }
	}
}
