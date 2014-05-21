using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReviewer.web.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        public DateTime Date  { get; set; }
    }
}