using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class author
    {
        [ScaffoldColumn(false)]
        public int AuthorID { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        //a collection that stores all the books in the bookstore
        public virtual ICollection<Book> Books { get; set; }
    }
}