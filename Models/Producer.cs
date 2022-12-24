using System.ComponentModel.DataAnnotations;

namespace ZahranMovie.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        public string? ProducerImage { get; set; }
        public string? ProducerName { get; set; }
        public string? ProducerBio { get; set; }
        public List<Movie>? Movie { get; set; }
    }
}
