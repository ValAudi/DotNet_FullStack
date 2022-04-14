using Microsoft.AspNetCore.Mvc;
using MovieStoreWebApp.MVC.Models;

namespace MovieStoreWebApp.MVC.Controllers;

public class AccountController : Controller {
    public IActionResult Index() {
        return View();
    }
}