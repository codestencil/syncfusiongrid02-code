using Microsoft.AspNetCore.Mvc;
using MyApp6.DAL;
using System.Threading.Tasks;
using MyApp6.Shared.Model;


namespace MyApp6.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CustomerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Customer customer)
        {
            await _unitOfWork.Customers.AddAsync(customer);
            return Ok(customer);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var album = await _unitOfWork.Customers.GetById(id);
            return Ok(album);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var customer = await _unitOfWork.Customers.GetAll();
            return Ok(customer);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var customer = new Customer { CustomerId = id };
            await _unitOfWork.Customers.DeleteAsync(customer);
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Put(Customer customer)
        {
            await _unitOfWork.Customers.UpdateAsync(customer);
            return NoContent();
        }
    }
}

