using Microsoft.AspNetCore.Mvc;
using Store_Manager.Repositories;

namespace Store_Manager.Controllers
{
    [Route("api/orders")]
    public class OrderTablesController : ControllerBase
    {
        private readonly OrderTableRepository _orderTableRepository;

        public OrderTablesController(OrderTableRepository orderTableRepository)
        {
            _orderTableRepository = orderTableRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            try 
            {
                var orders = await _orderTableRepository.GetOrderTablesAsync(); 
            return Ok(orders);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
