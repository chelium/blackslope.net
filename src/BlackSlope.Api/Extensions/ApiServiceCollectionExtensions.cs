using AutoMapper;
using BlackSlope.Repositories.Movies.Context;
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
            return services;
        }

        //public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        //{
        //    var config = new MapperConfiguration(cfg =>
        //    {
        //        cfg.AddMovieOperationProfiles();
        //        cfg.AddMovieServiceProfiles();
        //    });
        //    services.AddSingleton(x => config.CreateMapper());
        //    //services.TryAddSingleton(GenerateMapperConfiguration());
        //    return services;
        //}

        private static IMapper GenerateMapperConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddMovieOperationProfiles();
                cfg.AddMovieServiceProfiles();
            });
            return config.CreateMapper();
        }
    }
}
