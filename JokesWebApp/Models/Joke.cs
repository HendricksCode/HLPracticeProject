using System.ComponentModel.DataAnnotations;


namespace JokesWebApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        
        [Display(Name = "Joke Question")]
        public string JokeQuestion { get; set; }
        
        [Display(Name = "Joke Answer")]
        public string JokeAnswer { get; set; }

        //public List<Category> Categories { get; set; }
        [Display(Name = "Joke Category (Clean, NSFW, Music etc...)")]
        public Category JokeCategory { get; set; }
        //public int CategoryId { get; set; }
        //public Category Category { get; set; }

        public Joke()
            {

            }
    }
}
