using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Dtos
{
    public class BaseMovieDto
    {
        [MaxLength(250)]
        public string Title { get; set; }
        public int Year { get; set; }
        public double Rate { get; set; }

        [MaxLength(2500)]
        public string StoreLine { get; set; }
        public int GenreId { get; set; }
    }
}
