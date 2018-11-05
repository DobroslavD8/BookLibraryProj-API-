using BookLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Logic
{
    class BookService
    {
        LibraryContext ctx = new LibraryContext();

        public List<Book> GetAll()
        {
            List<Book> result = new List<Book>();
            //LibraryContext ctx = new LibraryContext();
            result = ctx.Books.ToList();

            return result;
        }

        public List<Book> GetByAuthor(string name)
        {
            List<Book> result = new List<Book>();
            ctx.Books.Where(book => book.Author == name).ToList();

            return result;
        }

        //Викаме горният метод и филтрираме по име
        //.....

        public List<Book> GetBookByID(int ID)
        {
            List<Book> result = new List<Book>();
            ctx.Books.Where(book => book.id == ID).ToList();

            return result;
        }

        public void List<Book> AddBook(Book book)
        {
            ctx.AddBook(Book);
            ctx.SaveChanges();
        }

    }
}
