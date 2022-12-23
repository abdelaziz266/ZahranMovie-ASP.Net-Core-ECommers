using System.ComponentModel.DataAnnotations;

namespace ZahranMovie.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string? Image { get; set; }
        public string? Name { get; set; }
        public string? Bio { get; set; }
    }
}
