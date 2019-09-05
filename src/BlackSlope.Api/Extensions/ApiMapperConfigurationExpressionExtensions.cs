using AutoMapper;
using BlackSlope.Api.Movies.MapperProfiles;

namespace BlackSlope.Api.Extensions
{
    public static class MapperConfigurationExpressionExtensions
    {
        public static IMapperConfigurationExpression AddOperationsProfiles(this IMapperConfigurationExpression expression)
        {
            expression.AddProfile<CreateMovieRequestProfile>();
            expression.AddProfile<MovieResponseProfile>();
            expression.AddProfile<UpdateMovieRequestProfile>();
            return expression;
        }
    }
}
