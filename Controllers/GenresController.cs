using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Models;
using MoviesAPI.Services;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenresSercice _genrsSercice;

        public GenresController(IGenresSercice genresSercice)
        {
            _genrsSercice = genresSercice;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var genres = await _genrsSercice.GetAllAsync();
            return Ok(genres);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(GenreDto dto)
        {
            var genre = new Genre { Name = dto.Name };

            await _genrsSercice.Add(genre);

            return Ok(genre);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] GenreDto dto)
        {
            var genre = await _genrsSercice.GetById(id);

            if (genre is null)
                return NotFound($"No genres Found with ID {id}");

            genre.Name = dto.Name;
            _genrsSercice.Update(genre);

            return Ok(genre);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var genre = await _genrsSercice.GetById(id);

            if (genre is null)
                return NotFound($"No genres Found with ID {id}");

            _genrsSercice.Delete(genre);

            return Ok(genre);
        }
    }
}
