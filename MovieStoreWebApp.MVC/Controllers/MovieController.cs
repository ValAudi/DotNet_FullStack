using Microsoft.AspNetCore.Mvc;

namespace MovieStoreWebApp.MVC.Controllers;

public class MovieController : Controller {
    public IActionResult Index() {
        ViewBag.Title = "All Movies";
        return View();
    }

    public IActionResult Detail(int Id){
        return View();
    }
}