using Microsoft.AspNetCore.Mvc;
using SalesMarket.Common.Contracts.Factories;
using SalesMarket.Common.Dto.Request;
using SalesMarket.Common.Dto.Response;

namespace SalesMarket.Api.Controllers
{
    /// <summary>
    /// Users controller
    /// </summary>
    [Route("api/users")]
    [ApiController]
    public class UsersController : BaseController
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="services"></param>
        public UsersController(IServicesCore services) : base(services) { }

        /// <summary>
        /// Get all
        /// </summary>
        /// <returns></returns>
        [HttpGet("get-all")]
        public async Task<ActionResult<IEnumerable<UserResponse>>> GetAll()
        {
            try
            {
                var response = await _services.UserService.GetAllAsync();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost("create")]
        public async Task<ActionResult> Create(UserRequest user)
        {
            try
            {
                await _services.UserService.AddAsync(user);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
