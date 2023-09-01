using System.ComponentModel.DataAnnotations;

namespace day16.ViewModel
{
    public class Addbook
    {
        [Required(ErrorMessage ="Name Is Required")]
        [MinLength(3,ErrorMessage ="name must be 3 char min")]
        public string Name { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public int AuthorId { get; set; }



    }
}
