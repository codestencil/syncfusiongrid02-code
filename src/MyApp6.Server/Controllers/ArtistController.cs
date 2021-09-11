using Microsoft.AspNetCore.Mvc;
using MyApp6.DAL;
using System.Threading.Tasks;
using MyApp6.Shared.Model;


namespace MyApp6.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ArtistController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Artist artist)
        {
            await _unitOfWork.Artists.AddAsync(artist);
            return Ok(artist);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var album = await _unitOfWork.Artists.GetById(id);
            return Ok(album);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var artist = await _unitOfWork.Artists.GetAll();
            return Ok(artist);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var artist = new Artist { ArtistId = id };
            await _unitOfWork.Artists.DeleteAsync(artist);
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Put(Artist artist)
        {
            await _unitOfWork.Artists.UpdateAsync(artist);
            return NoContent();
        }
    }
}

