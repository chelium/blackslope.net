using AutoMapper;
using BlackSlope.Api.Operations.Movies.Extensions;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class MovieServiceCollectionExtensions
    {
        /// <summary>
        /// Add AutoMapper service to the Service Collection and configure it
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            services.TryAddSingleton(GenerateMapperConfiguration());
            return services;
        }

        private static IMapper GenerateMapperConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddOperationsProfiles();
                cfg.AddServicesProfiles();
            });
            return config.CreateMapper();
        }
    }
}
