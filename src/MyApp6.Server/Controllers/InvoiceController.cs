using Microsoft.AspNetCore.Mvc;
using MyApp6.DAL;
using System.Threading.Tasks;
using MyApp6.Shared.Model;


namespace MyApp6.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvoiceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Invoice invoice)
        {
            await _unitOfWork.Invoices.AddAsync(invoice);
            return Ok(invoice);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var album = await _unitOfWork.Invoices.GetById(id);
            return Ok(album);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var invoice = await _unitOfWork.Invoices.GetAll();
            return Ok(invoice);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var invoice = new Invoice { InvoiceId = id };
            await _unitOfWork.Invoices.DeleteAsync(invoice);
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Put(Invoice invoice)
        {
            await _unitOfWork.Invoices.UpdateAsync(invoice);
            return NoContent();
        }
    }
}

