﻿using System.Threading.Tasks;
using AutoFixture;
using BlackSlope.Repositories.Movies.DtoModels;
using BlackSlope.Services.Movies.DomainModels;
using Moq;
using Xunit;

namespace BlackSlope.Api.Tests.ServicesTests.MoviesTests
{
    public class MovieService_UpdateMovieShould : MovieServiceTestsBase
    {
        private readonly MovieDtoModel _newMovieDto;
        private readonly MovieDomainModel _newMovieDomainModel;

        public MovieService_UpdateMovieShould()
        {
            _newMovieDto = _fixture.Create<MovieDtoModel>();
            _newMovieDomainModel = _fixture.Create<MovieDomainModel>();

            _mapper.Setup(_ => _.Map<MovieDtoModel>(It.IsAny<MovieDomainModel>())).Returns(_newMovieDto);

            _mapper.Setup(_ => _.Map<MovieDomainModel>(_newMovieDto)).Returns(_newMovieDomainModel);
        }

        [Fact]
        public async Task CreateMovie_successfully()
        {
            var updateMovieDomainModelRequest = _fixture.Create<MovieDomainModel>();
            _movieRepository.Setup(x => x.UpdateAsync(It.IsAny<MovieDtoModel>()))
                .ReturnsAsync(_newMovieDto);

            var result = await _service.UpdateMovieAsync(updateMovieDomainModelRequest);

            Assert.NotNull(result);
            Assert.IsType<MovieDomainModel>(result);
            Assert.Equal(_newMovieDomainModel, result);
        }
    }
}
