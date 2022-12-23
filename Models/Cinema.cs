using System.ComponentModel.DataAnnotations;

namespace ZahranMovie.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string? Image { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
