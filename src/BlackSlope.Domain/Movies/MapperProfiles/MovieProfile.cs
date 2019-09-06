using AutoMapper;
using BlackSlope.Infrastructure.Movies.DtoModels;
using BlackSlope.Domain.Movies.DomainModels;

namespace BlackSlope.Domain.Movies.MapperProfiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<MovieDomainModel, MovieDtoModel>().ReverseMap();
        }
    }
}
