using System.ComponentModel.DataAnnotations;

namespace ZahranMovie.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }
        public string? CinemaImage { get; set; }
        public string? CinemaName { get; set; }
        public string? CinemaDescription { get; set; }
        public List<Movie>? Movie { get; set; }
    }
}
