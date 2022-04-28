using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contracts.Services;
using MovieStoreApp.Core.Models;

namespace MovieStoreApp.API.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController: ControllerBase {

        private readonly IPurchaseServiceAsync purchaseService;
        public PurchaseController(IPurchaseServiceAsync _purchaseService)
        {
            purchaseService = _purchaseService;
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