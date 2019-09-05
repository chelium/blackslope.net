namespace BlackSlope.Infrastructure.Movies.Configuration
{
    public class MovieRepositoryConfiguration : IMovieRepositoryConfiguration
    {
        public string MoviesConnectionString { get; set; }
    }
}
