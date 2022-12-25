﻿using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Dtos
{
    public class UpdateMovieDto : BaseMovieDto
    {
        public IFormFile? Poster { get; set; }

    }
}
