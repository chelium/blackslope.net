using AutoMapper;
using BlackSlope.Services.Movies.MapperProfiles;

namespace BlackSlope.Domain.Extensions
{
    public static class DomainMapperConfigurationExpressionExtensions
    {
        public static IMapperConfigurationExpression AddServicesProfiles(this IMapperConfigurationExpression expression)
        {
            expression.AddProfile<MovieProfile>();
            return expression;
        }
    }
}
