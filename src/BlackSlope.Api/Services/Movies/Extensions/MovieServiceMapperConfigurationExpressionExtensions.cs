using AutoMapper;
using BlackSlope.Services.Movies.MapperProfiles;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class MovieServiceMapperConfigurationExpressionExtensions
    {
        public static IMapperConfigurationExpression AddMovieServiceProfiles(this IMapperConfigurationExpression expression)
        {
            expression.AddProfile<MovieProfile>();
            return expression;
        }
    }
}
