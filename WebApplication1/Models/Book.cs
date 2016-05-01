using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Book
    {
        [ScaffoldColumn(false)]
        public int bookID { get; set; }
        [Required]
        public string title { get; set; }

        public int year { get; set; }
        [Range(1, 500)]
        public decimal price { get; set; }

        public string genre { get; set; }
        [ScaffoldColumn(false)]
        public int authorID { get; set; }

        public virtual Author author { get; set; }
    }
}