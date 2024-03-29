﻿using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace BookReviewer.web.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Book> Books
        {
            set;
            get;
        }
        public DbSet<Author> Authors
        {
            get;
            set;

        }
        public DbSet<Review> Reviews
        {
            get;
            set;
        }
    }
}