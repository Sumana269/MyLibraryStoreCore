using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyLibraryStoreCore.Controllers
{
    public class CustomerController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
