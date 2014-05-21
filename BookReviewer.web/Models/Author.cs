using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReviewer.web.Models
{
	public class Author
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Book> Books { get; set; }
	}
}