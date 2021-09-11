using Microsoft.AspNetCore.Mvc;
using MyApp6.DAL;
using System.Threading.Tasks;
using MyApp6.Shared.Model;


namespace MyApp6.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AlbumController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Album album)
        {
            await _unitOfWork.Albums.AddAsync(album);
            return Ok(album);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var album = await _unitOfWork.Albums.GetById(id);
            return Ok(album);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var album = await _unitOfWork.Albums.GetAll();
            return Ok(album);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var album = new Album { AlbumId = id };
            await _unitOfWork.Albums.DeleteAsync(album);
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Put(Album album)
        {
            await _unitOfWork.Albums.UpdateAsync(album);
            return NoContent();
        }
    }
}

