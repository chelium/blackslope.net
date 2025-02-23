﻿using AutoFixture;
using BlackSlope.Api.Operations.Movies.Validators;
using BlackSlope.Api.Operations.Movies.ViewModels;
using BlackSlope.Services.Movies;
using FluentValidation.TestHelper;
using Moq;
using Xunit;

namespace BlackSlope.Api.Tests.OperationsTests.MoviesTests.ValidatorsTests
{
    public class CreateMovieViewModelValidatorShould
    {
        private readonly Fixture _fixture = new Fixture();
        private readonly CreateMovieViewModel _modelViewModel;
        private readonly CreateMovieViewModelValidator _movieViewModelValidator;
        private readonly Mock<IMovieService> _movieService = new Mock<IMovieService>();

        public CreateMovieViewModelValidatorShould()
        {
            _modelViewModel = _fixture.Create<CreateMovieViewModel>();
            _movieViewModelValidator = new CreateMovieViewModelValidator(_movieService.Object);
        }

        [Fact]
        public void Fail_when_title_is_null()
        {
            _modelViewModel.Title = null;
            _movieViewModelValidator.ShouldHaveValidationErrorFor(x => x.Title, _modelViewModel);
        }

        [Fact]
        public void Fail_when_description_is_null()
        {
            _modelViewModel.Description = null;
            _movieViewModelValidator.ShouldHaveValidationErrorFor(x => x.Description, _modelViewModel);
        }

        [Fact]
        public void Fail_when_title_is_not_between_2_and_50_characters()
        {
            _modelViewModel.Title = "2";
            _movieViewModelValidator.ShouldHaveValidationErrorFor(x => x.Title.Length, _modelViewModel);
        }

        [Fact]
        public void Fail_when_description_is_not_between_2_and_50_characters()
        {
            _modelViewModel.Description = "d";
            _movieViewModelValidator.ShouldHaveValidationErrorFor(x => x.Description.Length, _modelViewModel);
        }

        [Fact]
        public void Pass_when_title_is_between_2_and_50_characters()
        {
            _modelViewModel.Title = "the post";
            _movieViewModelValidator.ShouldNotHaveValidationErrorFor(x => x.Title, _modelViewModel);
        }

        [Fact]
        public void Pass_when_description_is_between_2_and_50_characters()
        {
            _modelViewModel.Description = "Great movie";
            _movieViewModelValidator.ShouldNotHaveValidationErrorFor(x => x.Description, _modelViewModel);
        }
    }
}
