using System;

namespace BlackSlope.Api.Movies.ViewModels
{
    public class MovieViewModel
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? ReleaseDate { get; set; }
    }
}
