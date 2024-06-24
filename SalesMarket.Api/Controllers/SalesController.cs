using Microsoft.AspNetCore.Mvc;
using SalesMarket.Common.Contracts.Factories;
using SalesMarket.Common.Dto.Request;
using SalesMarket.Common.Dto.Response;

namespace SalesMarket.Api.Controllers
{
    /// <summary>
    /// Sales controller
    /// </summary>
    [Route("api/sales")]
    [ApiController]
    public class SalesController : BaseController
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="services"></param>
        public SalesController(IServicesCore services) : base(services) { }

        /// <summary>
        /// Get all
        /// </summary>
        /// <returns></returns>
        [HttpGet("get-all")]
        public async Task<ActionResult<IEnumerable<CustomerItemResponse>>> GetAll()
        {
            try
            {
                var response = await _services.SalesService.GetAllAsync();
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
        public async Task<ActionResult<CustomerItemResponse>> GetById(int id)
        {
            try
            {
                var response = await _services.SalesService.GetByIdAsync(id);
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
        /// <param name="customerItem"></param>
        /// <returns></returns>
        [HttpPost("create")]
        public async Task<ActionResult<CustomerItemResponse>> Create(CustomerItemRequest customerItem)
        {
            try
            {
                await _services.SalesService.UpdateAsync(customerItem);
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
        /// <param name="customerItem"></param>
        /// <returns></returns>
        [HttpPut("{id}/update")]
        public async Task<IActionResult> Update(int id, CustomerItemRequest customerItem)
        {
            try
            {
                await _services.SalesService.UpdateAsync(customerItem);
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
                await _services.SalesService.DeleteAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
