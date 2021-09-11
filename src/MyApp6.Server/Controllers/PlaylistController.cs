using Microsoft.AspNetCore.Mvc;
using MyApp6.DAL;
using System.Threading.Tasks;
using MyApp6.Shared.Model;


namespace MyApp6.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaylistController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PlaylistController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Playlist playlist)
        {
            await _unitOfWork.Playlists.AddAsync(playlist);
            return Ok(playlist);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var album = await _unitOfWork.Playlists.GetById(id);
            return Ok(album);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var playlist = await _unitOfWork.Playlists.GetAll();
            return Ok(playlist);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var playlist = new Playlist { PlaylistId = id };
            await _unitOfWork.Playlists.DeleteAsync(playlist);
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Put(Playlist playlist)
        {
            await _unitOfWork.Playlists.UpdateAsync(playlist);
            return NoContent();
        }
    }
}

