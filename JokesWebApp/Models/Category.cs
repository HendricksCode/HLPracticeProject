using System.ComponentModel.DataAnnotations;

namespace JokesWebApp.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        
        [Display(Name = "Joke Category (Clean, NSFW, Music etc...)")]
        public string JokeCategory { get; set; }

        //public int JokeId { get; set; }
        //public Joke Joke { get; set; }
        //public List<Joke> jokes { get; set; }
    }
}
