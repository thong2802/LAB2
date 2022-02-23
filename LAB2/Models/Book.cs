using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LAB2.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Please inout Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please inout Author")]
        [StringLength(50, ErrorMessage = "Author less than 50 characters")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Please inout PublicYear")]
        public int PublicYear { get; set; }


        public double price
        {
            get;
            set;
        }

        public string Cover { get; set; }

    }
}