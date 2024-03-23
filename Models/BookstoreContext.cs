using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Mission11.Models;

namespace Mission11;

public class BookstoreContext : DbContext
{
    public BookstoreContext(DbContextOptions<BookstoreContext> options)
        : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }

}
