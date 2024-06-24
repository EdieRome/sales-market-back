using Microsoft.AspNetCore.Mvc;
using SalesMarket.Common.Contracts.Factories;
using SalesMarket.Common.Dto.Request;
using SalesMarket.Common.Dto.Response;

namespace SalesMarket.Api.Controllers
{
    /// <summary>
    /// Stores controller
    /// </summary>
    [Route("api/stores")]
    [ApiController]
    public class StoresController : BaseController
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="services"></param>
        public StoresController(IServicesCore services) : base(services) { }

        /// <summary>
        /// Get all
        /// </summary>
        /// <returns></returns>
        [HttpGet("get-all")]
        public async Task<ActionResult<IEnumerable<StoreResponse>>> GetAll()
        {
            try
            {
                var response = await _services.StoreService.GetAllAsync();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Get by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}/get")]
        public async Task<ActionResult<StoreResponse>> GetById(int id)
        {
            try
            {
                var response = await _services.StoreService.GetByIdAsync(id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Creare
        /// </summary>
        /// <param name="store"></param>
        /// <returns></returns>
        [HttpPost("create")]
        public async Task<ActionResult> Create(StoreRequest store)
        {
            try
            {
                await _services.StoreService.AddAsync(store);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="id"></param>
        /// <param name="store"></param>
        /// <returns></returns>
        [HttpPut("{id}/update")]
        public async Task<IActionResult> Update(int id, StoreRequest store)
        {
            try
            {
                await _services.StoreService.UpdateAsync(store);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}/delete")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _services.StoreService.DeleteAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
