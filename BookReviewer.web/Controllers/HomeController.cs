using BookReviewer.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookReviewer.web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Book> Books = new List<Book>();
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                Books = db.Books.Include("Author").ToList();
            };
            return View(Books);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult AuthorDetails(int Id)
        {
            Author author = new Author();

            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                author = db.Authors.Include("Books").Include("Reviews").Where(x => x.Id == Id).FirstOrDefault();
            }

            return View(author);
        }
        public ActionResult BookDetails(int Id)
        {
            Book book = new Book();
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                book = db.Books.Include("Author").Include("Reviews").Where(p=>p.Id == Id).FirstOrDefault();
            }
            return View(book);

        }

        [HttpGet]
        public ActionResult CreateBook()
        {
            AddBookVM model = new AddBookVM();
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                model.Authors = db.Authors.ToList();             
            }
            model.Genres = new List<Genre>()
            {
                Genre.Fiction,
        Genre.NonFiction,
        Genre.Memoir,
        Genre.YoungAdult,
        Genre.SciFi,
        Genre.Business,
        Genre.Technology
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult CreateBook(Book book)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Books.Add(book);
                db.SaveChanges();
            }
            
            return RedirectToAction("Index");
        }


    }
}