using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibraryStore.Models
{
    public class BookDetail
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Book Name cannot be Blank")]
        [Display(Name ="Book Name")]
        public string BookName { get; set; }

        [Required(ErrorMessage = "Author Name cannot be Blank")]
        [Display(Name = "Author Name")]
        public string Author { get; set; }
        public string ISBN { get; set; }

        [Required]
        [Display(Name ="Genre Name")]
        public string Genre { get; set; }

        [Display(Name = "Published Date")]
        [DataType(DataType.DateTime)]
        public DateTime PublishedDate { get; set; }
    }
}
