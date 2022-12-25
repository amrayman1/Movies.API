using AutoMapper;
using MoviesAPI.Models;

namespace MoviesAPI.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Movie, MovieDetailsDto>();
            CreateMap<MovieDetailsDto, Movie>().ForMember(src => src.Poster, opt => opt.Ignore());
        }
    }
}
