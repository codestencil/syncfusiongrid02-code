using Microsoft.AspNetCore.Mvc;
using MyApp6.DAL;
using System.Threading.Tasks;
using MyApp6.Shared.Model;


namespace MyApp6.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmployeeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Employee employee)
        {
            await _unitOfWork.Employees.AddAsync(employee);
            return Ok(employee);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var album = await _unitOfWork.Employees.GetById(id);
            return Ok(album);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var employee = await _unitOfWork.Employees.GetAll();
            return Ok(employee);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var employee = new Employee { EmployeeId = id };
            await _unitOfWork.Employees.DeleteAsync(employee);
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Put(Employee employee)
        {
            await _unitOfWork.Employees.UpdateAsync(employee);
            return NoContent();
        }
    }
}

