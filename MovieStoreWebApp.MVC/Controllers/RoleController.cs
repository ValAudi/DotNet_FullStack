using Microsoft.AspNetCore.Mvc;
using MovieStoreWebApp.MVC.Models;

namespace MovieStoreWebApp.MVC.Controllers 
{
    public class RoleController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}

