using MoviesAPI.Models;

namespace MoviesAPI.Services
{
    public interface IGenresSercice
    {
        Task<IEnumerable<Genre>> GetAllAsync();
        Task<Genre> GetById(int id);
        Task<Genre> Add(Genre genre);
        Genre Update(Genre genre);
        Genre Delete(Genre genre);
        Task<bool> IsValidGenre(int id);

    }
}
