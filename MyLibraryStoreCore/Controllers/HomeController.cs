﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyLibraryStoreCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is my Mvc Project");
        }
    }
}
