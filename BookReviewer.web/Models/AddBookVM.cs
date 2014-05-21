using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReviewer.web.Models
{
    public class AddBookVM
    {
        public List<Genre> Genres { get; set; }
        public List<Author> Authors { get; set; }
        public Book Book { get; set; }
    }
}