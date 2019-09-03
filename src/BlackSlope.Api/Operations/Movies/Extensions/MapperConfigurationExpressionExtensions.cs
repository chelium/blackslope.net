using AutoMapper;
using BlackSlope.Api.Operations.Movies.MapperProfiles;

namespace BlackSlope.Api.Operations.Movies.Extensions
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
