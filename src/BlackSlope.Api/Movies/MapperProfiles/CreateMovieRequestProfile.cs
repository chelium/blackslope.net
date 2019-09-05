using AutoMapper;
using BlackSlope.Api.Movies.ViewModels;
using BlackSlope.Services.Movies.DomainModels;

namespace BlackSlope.Api.Movies.MapperProfiles
{
    public class CreateMovieRequestProfile : Profile
    {
        public CreateMovieRequestProfile()
        {
            CreateMap<CreateMovieViewModel, MovieDomainModel>().ForMember(x => x.Id, opt => opt.Ignore()).ReverseMap();
        }
    }
}
