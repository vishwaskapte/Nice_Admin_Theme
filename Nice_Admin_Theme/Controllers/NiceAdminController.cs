using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Nice_Admin_Theme.Controllers
{
    public class NiceAdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}