using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Author
    {
        [ScaffoldColumn(false)]
        public int authorID { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public String lastName { get; set; }
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        //a collection that stores all the books in the bookstore
        public virtual ICollection<Book> books { get; set; }
    }
}