using BlackSlope.Infrastructure.Movies;
using BlackSlope.Infrastructure.Movies.Configuration;
using BlackSlope.Infrastructure.Movies.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class InfrastructureServiceCollectionExtensions
    {
        public static IServiceCollection AddMovieRepository(this IServiceCollection services, IMovieRepositoryConfiguration config)
        {
            services.TryAddScoped<IMovieRepository, MovieRepository>();
            services.TryAddSingleton(config);

            var serviceProvider = services.BuildServiceProvider();
            var movieContext = serviceProvider.GetService<MovieContext>();
            if (movieContext == null)
            {
                services.AddDbContext<MovieContext>(options => options.UseSqlServer(config.MoviesConnectionString));
            }

            return services;
        }
    }
}
