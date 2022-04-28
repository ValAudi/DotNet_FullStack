using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contracts.Services;
using MovieStoreApp.Core.Models;

namespace MovieStoreApp.API.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController: ControllerBase {

        private readonly IReviewServiceAsync reviewService;
        public ReviewController(IReviewServiceAsync _reviewService)
        {
            reviewService = _reviewService;
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