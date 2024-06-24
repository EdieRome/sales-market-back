using Microsoft.AspNetCore.Mvc;
using SalesMarket.Common.Contracts.Factories;

namespace SalesMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        public readonly IServicesCore _services;

        public BaseController(IServicesCore services)
        {
            this._services = services;
        }

        [HttpGet("test")]
        public IActionResult Test()
        {
            var response = new { date = DateTime.Now, version = "1.0" };
            return Ok(response);
        }
    }
}
