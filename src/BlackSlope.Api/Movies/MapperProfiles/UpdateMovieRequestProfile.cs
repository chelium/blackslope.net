using AutoMapper;
using BlackSlope.Api.Movies.ViewModels;
using BlackSlope.Services.Movies.DomainModels;

namespace BlackSlope.Api.Movies.MapperProfiles
{
    public class UpdateMovieRequestProfile : Profile
    {
        public UpdateMovieRequestProfile()
        {
            CreateMap<UpdateMovieViewModel, MovieDomainModel>().ReverseMap();
        }
    }
}
