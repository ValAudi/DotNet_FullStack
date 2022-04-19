using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contracts.Services;
using MovieStoreApp.Core.Models;

namespace MovieStoreApp.API.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController: ControllerBase {

        private readonly IRoleService roleService;
        public RoleController(IRoleService _roleService)
        {
            roleService = _roleService;
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