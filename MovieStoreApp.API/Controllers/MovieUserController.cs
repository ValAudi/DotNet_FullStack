using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contracts.Services;
using MovieStoreApp.Core.Models;

namespace MovieStoreApp.API.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieUserController: ControllerBase {

        private readonly IMovieUserServiceAsync movieUserService;
        public MovieUserController(IMovieUserServiceAsync _movieUserService)
        {
            movieUserService = _movieUserService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();

        }

        [HttpPost]
        public IActionResult Create()
        {
            return Ok();
        }

    }
}