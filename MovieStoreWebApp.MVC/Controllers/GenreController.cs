using Microsoft.AspNetCore.Mvc;
using MovieStoreWebApp.MVC.Models;

namespace MovieStoreWebApp.MVC.Controllers 
{
    public class GenreController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}