using Microsoft.AspNetCore.Mvc;
using MovieStoreWebApp.MVC.Models;
using MovieStoreApp.Infrastructure.Service;
using MovieStoreApp.Core.Contracts.Services;

namespace MovieStoreWebApp.MVC.Controllers 
{
    public class TrailerController : Controller {

        ITrailerServiceAsync trailerService;

        public TrailerController(ITrailerServiceAsync _t)
        {
            trailerService = _t;
        }
        public IActionResult Index() {
            var result = trailerService.ListOfTrailersReleasedByYear;
            return View(result);
        }
    }
}

