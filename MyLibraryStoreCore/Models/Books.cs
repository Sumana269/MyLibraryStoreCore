using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibraryStoreCore.Models
{
    public class Books
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter the Book Name")]
        [Display(Name ="Book Name")]
        public string BookName { get; set; }

        [Required(ErrorMessage ="Please enter the Author Name")]
        [Display(Name ="Author Name")]
        public string Author { get; set; }

        [Required(ErrorMessage ="Please Enter the ISBN Number" )]
        [Display(Name ="ISBN Number")]
        public string ISBN { get; set; }

        [Required(ErrorMessage ="Please enter the Date")]
        [Display(Name ="Published Date")]
        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; }
        public string Gener { get; set; }
    }
}
