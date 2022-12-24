using System.ComponentModel.DataAnnotations;

namespace ZahranMovie.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        public string? ActorImage { get; set; }
        public string? ActorName { get; set; }
        public string? ActorBio { get; set; }
        public List<Actor_Movie>? Actor_Movie { get; set; }
    }
}
