using Microsoft.AspNetCore.Mvc;
using MyApp6.DAL;
using System.Threading.Tasks;
using MyApp6.Shared.Model;


namespace MyApp6.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaTypeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public MediaTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(MediaType mediatype)
        {
            await _unitOfWork.MediaTypes.AddAsync(mediatype);
            return Ok(mediatype);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var album = await _unitOfWork.MediaTypes.GetById(id);
            return Ok(album);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var mediatype = await _unitOfWork.MediaTypes.GetAll();
            return Ok(mediatype);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var mediatype = new MediaType { MediaTypeId = id };
            await _unitOfWork.MediaTypes.DeleteAsync(mediatype);
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Put(MediaType mediatype)
        {
            await _unitOfWork.MediaTypes.UpdateAsync(mediatype);
            return NoContent();
        }
    }
}

