using Microsoft.AspNetCore.Mvc;
using Store_Manager.Models;
using Store_Manager.Repositories;



namespace Store_Manager.Controllers
{
    [Route("api/customers")]
    
    public class CustomersController : ControllerBase
    {
       private readonly CustomerRepository _customerRepository;

        public CustomersController(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            try
            {
                var customers = await _customerRepository.GetAllCustomersAsync();
                return Ok(customers);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            try
            {
                var customer = await _customerRepository.GetCustomerByIdAsync(id);
                if (customer == null)
                {
                    return NotFound(); 
                }
                return Ok(customer);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer([FromBody] Customer customer)
        {
            try
            {
                if (customer == null)
                {
                    return BadRequest(); 
                }

                await _customerRepository.CreateCustomerAsync(customer);
                return CreatedAtAction("GetCustomerById", new { id = customer.id}, customer);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer(int id, [FromBody] Customer customer)
        {
            try
            {
                if (customer == null || customer.id!= id)
                {
                    return BadRequest();
                }

                var existingCustomer = await _customerRepository.GetCustomerByIdAsync(id);
                if (existingCustomer == null)
                {
                    return NotFound();
                }

                await _customerRepository.UpdateCustomerAsync(customer);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            try
            {
                var existingCustomer = await _customerRepository.GetCustomerByIdAsync(id);
                if (existingCustomer == null)
                {
                    return NotFound();
                }

                await _customerRepository.DeleteCustomerAsync(id);
                return NoContent(); 
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
