using Store_Manager.Models;
using Microsoft.AspNetCore.Mvc;
using Store_Manager.Repositories;

namespace Store_Manager.Controllers
{
    [Route("api/order-items")]
    public class OrderItemsController : ControllerBase
    {
        private readonly OrderItemRepository _orderItemRepository;

        public OrderItemsController(OrderItemRepository orderItemRepository)
        {
            _orderItemRepository = orderItemRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllOrderItems()
        {
            try
            {
                var orderItems = await _orderItemRepository.GetAllOrderItemsAsync();
                return Ok(orderItems);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{orderItemId}")]
        public async Task<IActionResult> GetOrderItemById(int orderItemId)
        {
            try
            {
                var orderItem = await _orderItemRepository.GetOrderItemByIdAsync(orderItemId);
                if (orderItem == null)
                {
                    return NotFound();
                }
                return Ok(orderItem);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost]
        
        public async Task<IActionResult> AddOrderItem([FromBody]OrderItem orderItem)
        {
            try
            {

                await _orderItemRepository.AddOrderItemAsync(orderItem);
                return CreatedAtAction(nameof(GetOrderItemById), new { orderItemId = orderItem.id }, orderItem);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPut("{orderItemId}")]
        public async Task<IActionResult> UpdateOrderItem(int orderItemId, OrderItem orderItem)
        {
            try
            {
                if (orderItemId != orderItem.id)
                {
                    return BadRequest();
                }

                await _orderItemRepository.UpdateOrderItemAsync(orderItem);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete("{orderItemId}")]
        public async Task<IActionResult> DeleteOrderItem(int orderItemId)
        {
            try
            {
                var existingOrderItem = await _orderItemRepository.GetOrderItemByIdAsync(orderItemId);
                if (existingOrderItem == null)
                {
                    return NotFound();
                }

                await _orderItemRepository.DeleteOrderItemAsync(orderItemId);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

    }
}
