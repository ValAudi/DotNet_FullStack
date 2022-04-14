using Microsoft.AspNetCore.Mvc;
using MovieStoreWebApp.MVC.Models;

namespace MovieStoreWebApp.MVC.Controllers;

public class AdminController : Controller {
    public IActionResult Index() {
        return View();
    }
}