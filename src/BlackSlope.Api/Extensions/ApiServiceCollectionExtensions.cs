using AutoMapper;
using BlackSlope.Api.Extensions;
using BlackSlope.Api.Movies.Validators;
using BlackSlope.Api.Movies.Validators.Interfaces;
using BlackSlope.Infrastructure.Movies.Context;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ApiServiceCollectionExtensions
    {
        /// <summary>
        /// Adds health check service to the Service Collection 
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddHealthChecksService(this IServiceCollection services)
        {
            services.AddHealthChecks()
                .AddDbContextCheck<MovieContext>();

            services.TryAddTransient<IUpdateMovieRequestValidator, UpdateMovieRequestValidator>();
            services.TryAddTransient<ICreateMovieRequestValidator, CreateMovieRequestValidator>();
            return services;
        }

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
