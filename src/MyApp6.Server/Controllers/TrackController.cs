using Microsoft.AspNetCore.Mvc;
using MyApp6.DAL;
using System.Threading.Tasks;
using MyApp6.Shared.Model;


namespace MyApp6.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrackController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Track track)
        {
            await _unitOfWork.Tracks.AddAsync(track);
            return Ok(track);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var album = await _unitOfWork.Tracks.GetById(id);
            return Ok(album);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var track = await _unitOfWork.Tracks.GetAll();
            return Ok(track);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var track = new Track { TrackId = id };
            await _unitOfWork.Tracks.DeleteAsync(track);
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Put(Track track)
        {
            await _unitOfWork.Tracks.UpdateAsync(track);
            return NoContent();
        }
    }
}

