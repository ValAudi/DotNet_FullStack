using Microsoft.AspNetCore.Mvc;
using MovieStoreWebApp.MVC.Models;

namespace MovieStoreWebApp.MVC.Controllers 
{
    public class CastController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}

