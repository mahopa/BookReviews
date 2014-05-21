namespace BookReviewer.web.Migrations
{
    using BookReviewer.web.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookReviewer.web.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookReviewer.web.Models.ApplicationDbContext context)
        {
            context.Authors.AddOrUpdate(a => a.Name, new Author() { 
                Name = "Steinbeck"
            },
            new Author()
            {
                Name = "Hemmingway"
            });
            context.SaveChanges();
            
            context.Books.AddOrUpdate(
                new Book() {
                    Title="Three Little Pigs",
                    Genre=Genre.NonFiction, 
                    AuthorId=1},
            new Book(){
                Title="C# For Dummies", 
                Genre=Genre.Technology, 
                AuthorId=2});
            context.Reviews.AddOrUpdate(x => x.Comment,
                new Review()
                {
                    Comment = "I loved this book",
                    AuthorId = 2,
                    BookId = 2,
                    Date = DateTime.Now.AddDays(-10)
                },
                new Review()
                {
                    Comment = "This book sucks and is too long",
                    AuthorId = 1,
                    BookId = 1,
                    Date = DateTime.Now
                });
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
