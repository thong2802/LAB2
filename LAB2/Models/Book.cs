using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LAB2.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public int PublicYear { get; set; }

        public double price
        {
            get;
            set;
        }

        public string Cover { get; set; }

    }
}