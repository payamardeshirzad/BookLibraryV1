using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SPA_Example.Models;

namespace SPA_Example.Controllers
{
    public class BooksController : ApiController
    {
        SPA_ExampleContext db=new SPA_ExampleContext();
        public IEnumerable<Book> GetBooks()
        {
            return db.Books;
        }

        public Book GetById(int id)
        {
            return db.Books.Find(id);
        }

        public void PostBook(Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();
        }

        public void PutBook(int id, Book book)
        {
            if (id == book.ID)
            {
                db.Entry(book).State=EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteBook(int id)
        {
            var book = GetById(id);
            db.Entry(book).State = EntityState.Deleted;
            db.SaveChanges();
        }
    }
}
