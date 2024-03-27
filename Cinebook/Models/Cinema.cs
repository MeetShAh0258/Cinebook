using System.ComponentModel.DataAnnotations;

namespace Cinebook.Models
{
    public class Cinema
    {
        [Key]
        public int cinemaId { get; set; }
		[Display(Name = "Cinema Logo")]
		public string cinemaPictureURL { get; set; }
		[Display(Name = "Name")]
		public string cinemaName { get; set; }
		[Display(Name = "Address")]
		public string cinemaAddress { get; set; }


		public List<Movie> Movies { get; set; } // Cinema - Movie
	}
}
