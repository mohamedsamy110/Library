using System.ComponentModel.DataAnnotations;

namespace day16.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name Is Required")]
        [MinLength(3, ErrorMessage = "name must be 3 char min")]
        public string Name { get; set; }
        public string Price { get; set; }
        public string Category { get; set; }
        public int AuthorId { get; set; }

        public Author? Author { get; set; }





    }
}
