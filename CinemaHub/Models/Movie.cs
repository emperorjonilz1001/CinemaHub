
using System.ComponentModel.DataAnnotations;

namespace CinemaHub.Models
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }

        public string Title { get; set; }

        public 
        public string? Description { get; set; }
        public string? Director { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
