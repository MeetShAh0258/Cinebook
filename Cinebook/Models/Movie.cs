using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Cinebook.Data.Enums;

namespace Cinebook.Models
{
    public class Movie
    {
        [Key]
        public int movieId { get; set; }
		[Display(Name = "Poster Picture")]
		public string moviePictureURL { get; set; }
		[Display(Name = "Name")]
		public string movieName { get; set; }
		[Display(Name = "Description")]
		public string movieDescription { get; set; }
        public double price { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public MovieCategory movieCategory { get; set; }

        public List<Actor_Movie> Actors_Movies { get; set; } // Movie - Actor_Movie

        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; } // Movie - Producer
		public int CinemaId { get; set; }
		[ForeignKey("CinemaId")]
		public Cinema Cinema { get; set; } // Movie - Producer
	}
}
