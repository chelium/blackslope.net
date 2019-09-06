using BlackSlope.Api.Common.Validators;
using BlackSlope.Api.Movies.Enumerators;
using BlackSlope.Api.Movies.Requests;
using BlackSlope.Api.Movies.Validators.Interfaces;
using BlackSlope.Domain.Movies;
using FluentValidation;

namespace BlackSlope.Api.Movies.Validators
{
    public class CreateMovieRequestValidator : BlackslopeValidator<CreateMovieRequest>, ICreateMovieRequestValidator
    {

        public CreateMovieRequestValidator(IMovieService movieService)
        {
            RuleFor(x => x.Movie)
                .NotNull()
                .WithState(x => MovieErrorCode.NullRequestViewModel)
                .DependentRules(() => ValidateViewModel(movieService)); ;
        }

        private void ValidateViewModel(IMovieService movieService)
        {
            RuleFor(x => x.Movie).SetValidator(new CreateMovieViewModelValidator(movieService));
        }
    }
}
