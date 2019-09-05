using BlackSlope.Api.Movies.ViewModels;

namespace BlackSlope.Api.Movies.Requests
{
    public class UpdateMovieRequest
    {
        public int? Id { get; set; }
        public MovieViewModel Movie { get; set; }
    }
}
