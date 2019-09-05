using AutoMapper;
using BlackSlope.Services.Movies.MapperProfiles;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class MapperConfigurationExpressionExtensions
    {
        public static IMapperConfigurationExpression AddServicesProfiles(this IMapperConfigurationExpression expression)
        {
            expression.AddProfile<MovieProfile>();
            return expression;
        }
    }
}
