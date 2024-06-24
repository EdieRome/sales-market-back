using Microsoft.AspNetCore.Mvc;
using SalesMarket.Common.Contracts.Factories;
using SalesMarket.Common.Dto.Request;
using SalesMarket.Common.Dto.Response;

namespace SalesMarket.Api.Controllers
{
    /// <summary>
    /// Stock controller
    /// </summary>
    [Route("api/stocks")]
    [ApiController]
    public class StocksController : BaseController
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="services"></param>
        public StocksController(IServicesCore services) : base(services) { }

        /// <summary>
        /// Get all
        /// </summary>
        /// <returns></returns>
        [HttpGet("get-all")]
        public async Task<ActionResult<IEnumerable<ItemStoreResponse>>> GetAll()
        {
            try
            {
                var response = await _services.StockService.GetAllAsync();
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
        public async Task<ActionResult<ItemStoreResponse>> GetById(int id)
        {
            try
            {
                var response = await _services.StockService.GetByIdAsync(id);
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
        /// <param name="itemStore"></param>
        /// <returns></returns>
        [HttpPost("create")]
        public async Task<ActionResult> Create(ItemStoreRequest itemStore)
        {
            try
            {
                await _services.StockService.AddAsync(itemStore);
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
        /// <param name="itemStore"></param>
        /// <returns></returns>
        [HttpPut("{id}/update")]
        public async Task<IActionResult> Update(int id, ItemStoreRequest itemStore)
        {
            try
            {
                await _services.StockService.UpdateAsync(itemStore);
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
                await _services.StockService.DeleteAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
