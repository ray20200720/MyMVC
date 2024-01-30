using System.ComponentModel.DataAnnotations;

namespace MyMvc.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public override string ToString()
        {
            return $"ID:{Id}, Title:{Title}";
        }
    }
}