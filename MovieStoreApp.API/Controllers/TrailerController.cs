using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contracts.Services;
using MovieStoreApp.Core.Models;

namespace MovieStoreApp.API.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrailerController: ControllerBase {

        private readonly ITrailerService trailerService;
        public TrailerController(ITrailerService _trailerService)
        {
            trailerService = _trailerService;
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