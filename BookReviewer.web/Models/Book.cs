using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReviewer.web.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public List<Review> Reviews { get; set; }
    }
    public enum Genre
    {
        Fiction,
        NonFiction,
        Memoir,
        YoungAdult,
        SciFi,
        Business,
        Technology
    }
}