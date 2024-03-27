using System.ComponentModel.DataAnnotations;

namespace Cinebook.Models
{
    public class Producer
    {
        [Key]
        public int producerId { get; set; }
		[Display(Name = "Profile Picture")]
		public string producerPictureURL { get; set; }
		[Display(Name = "Name")]
		public string producerName { get; set; }
		[Display(Name = "Description")]
		public string producerBio { get; set; }

        public List<Movie> Movies { get; set; }  // Producer - Movie
    }
}
