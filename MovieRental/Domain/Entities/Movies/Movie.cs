using System.ComponentModel.DataAnnotations;

namespace MovieRental.Domain.Entities.Movies
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }

    }
}
