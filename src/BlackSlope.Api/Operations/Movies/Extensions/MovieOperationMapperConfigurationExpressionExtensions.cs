using AutoMapper;
using BlackSlope.Api.Operations.Movies.MapperProfiles;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class MovieOperationMapperConfigurationExpressionExtensions
    {
        public static IMapperConfigurationExpression AddMovieOperationProfiles(this IMapperConfigurationExpression expression)
        {
            expression.AddProfile<CreateMovieRequestProfile>();
            expression.AddProfile<MovieResponseProfile>();
            expression.AddProfile<UpdateMovieRequestProfile>();
            return expression;
        }
    }
}
