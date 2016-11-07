using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace demo.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Bookname { get; set; }
        public string Location { get; set; }
        public int deleted { get; set; }
        public int Categories { get; set; }
    }
}