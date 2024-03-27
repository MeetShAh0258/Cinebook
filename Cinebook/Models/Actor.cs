using System.ComponentModel.DataAnnotations;

namespace Cinebook.Models
{
    public class Actor
    {
        [Key]
        public int actorId { get; set; }
        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Please provide valid Profile Picture URL")]
        public string actorPictureURL { get; set; }
		[Display(Name = "Name")]
		[Required(ErrorMessage = "Please provide Name of the Actor")]
		public string actorName { get; set; }
		[Display(Name = "Description")]
		[Required(ErrorMessage = "Please provide valid Actor's Description")]
		public string actorBio { get; set; }

        public List<Actor_Movie> Actors_Movies { get; set; } // Actor - Actor_Movie
    }
}
