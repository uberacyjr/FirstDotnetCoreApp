﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class HomeIndexViewModel
    {
	    public IEnumerable<Restaurant> Restaurants { get; set; }
	    public string Message { get; set; }
    }
}
