
using Microsoft.AspNetCore.Mvc;
using MovieStoreWebApp.MVC.Models;

namespace MovieStoreWebApp.MVC.Controllers;

public class LoginController : Controller {
    public IActionResult Index() {
        return View();
    }
}