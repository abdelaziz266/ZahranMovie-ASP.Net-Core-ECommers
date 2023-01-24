using System.ComponentModel.DataAnnotations.Schema;
using ZahranMovie.Data.Enum;

namespace ZahranMovie.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string? MovieImage { get; set; }
        public string? MovieName { get; set; }
        public string? MovieDescription { get; set; }
        public double? MoviePrice { get; set; }
        public DateTime? MovieStartDate { get; set; }
        public DateTime? MovieEndDate { get; set; }
        public MovieCinema MovieCinema { get; set; }
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer? Producer { get; set; }
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema? Cinema { get; set; }
        public List<Actor_Movie>? Actor_Movie { get; set; }

    }
}
