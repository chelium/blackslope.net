using BlackSlope.Services.Movies;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace BlackSlope.Domain.Extensions
{
    public static class DomainServiceCollectionExtensions
    {
        public static IServiceCollection AddMovieService(this IServiceCollection services)
        {
            services.TryAddTransient<IMovieService, MovieService>();
            return services;
        }
    }
}
