using Microsoft.AspNetCore.Mvc;
using SalesMarket.Common.Contracts.Factories;
using SalesMarket.Common.Dto.Response;

namespace SalesMarket.Api.Controllers
{
    /// <summary>
    /// Auth controller
    /// </summary>
    [Route("api/auth")]
    [ApiController]
    public class AuthController : BaseController
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="services"></param>
        public AuthController(IServicesCore services) : base(services) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        [HttpGet("login")]
        public async Task<IActionResult> Login([FromQuery] string user, [FromQuery] string pass)
        {
            var response = new LoginResponse(false);

            if (user.Equals("admin") && pass.Equals("1234"))
            {
                response.Success = true;
            }

            return await Task.FromResult(Ok(response));
        }
    }
}
