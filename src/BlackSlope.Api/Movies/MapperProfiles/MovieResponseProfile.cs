﻿using AutoMapper;
using BlackSlope.Api.Movies.ViewModels;
using BlackSlope.Domain.Movies.DomainModels;

namespace BlackSlope.Api.Movies.MapperProfiles
{
    public class MovieResponseProfile : Profile
    {
        public MovieResponseProfile()
        {
            CreateMap<MovieDomainModel, MovieViewModel>().ReverseMap();
        }
    }
}
