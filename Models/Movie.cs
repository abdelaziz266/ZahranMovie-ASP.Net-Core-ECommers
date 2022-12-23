using ZahranMovie.Data;

namespace ZahranMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Image { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCinema MovieCinema { get; set; }
    }
}
