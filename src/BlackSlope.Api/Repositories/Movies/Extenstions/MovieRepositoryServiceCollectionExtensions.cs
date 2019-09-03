using BlackSlope.Repositories.Movies;
using BlackSlope.Repositories.Movies.Configuration;
using BlackSlope.Repositories.Movies.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class MovieRepositoryServiceCollectionExtensions
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
