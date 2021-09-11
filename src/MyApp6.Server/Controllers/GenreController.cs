using Microsoft.AspNetCore.Mvc;
using MyApp6.DAL;
using System.Threading.Tasks;
using MyApp6.Shared.Model;


namespace MyApp6.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GenreController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Genre genre)
        {
            await _unitOfWork.Genres.AddAsync(genre);
            return Ok(genre);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var album = await _unitOfWork.Genres.GetById(id);
            return Ok(album);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var genre = await _unitOfWork.Genres.GetAll();
            return Ok(genre);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var genre = new Genre { GenreId = id };
            await _unitOfWork.Genres.DeleteAsync(genre);
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Put(Genre genre)
        {
            await _unitOfWork.Genres.UpdateAsync(genre);
            return NoContent();
        }
    }
}

