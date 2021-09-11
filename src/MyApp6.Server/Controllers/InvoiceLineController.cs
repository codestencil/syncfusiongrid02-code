using Microsoft.AspNetCore.Mvc;
using MyApp6.DAL;
using System.Threading.Tasks;
using MyApp6.Shared.Model;


namespace MyApp6.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceLineController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvoiceLineController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(InvoiceLine invoiceline)
        {
            await _unitOfWork.InvoiceLines.AddAsync(invoiceline);
            return Ok(invoiceline);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var album = await _unitOfWork.InvoiceLines.GetById(id);
            return Ok(album);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var invoiceline = await _unitOfWork.InvoiceLines.GetAll();
            return Ok(invoiceline);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var invoiceline = new InvoiceLine { InvoiceLineId = id };
            await _unitOfWork.InvoiceLines.DeleteAsync(invoiceline);
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Put(InvoiceLine invoiceline)
        {
            await _unitOfWork.InvoiceLines.UpdateAsync(invoiceline);
            return NoContent();
        }
    }
}

