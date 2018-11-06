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

        //Търси книги по зададени филтри за име и/или автор на книгата
        //Викаме горният метод и филтрираме по име
        //.....

        public List<Book> GetBookByID(int ID)
        {
            List<Book> result = new List<Book>();
            ctx.Books.Where(book => book.id == ID).ToList();

            return result;
        }

        List<Book> books = new List<Book>();
        public void AddBook(string Title, string Author, string Genre, string Description, int Quantity, DateTime CreatedDate) // adding book
        {
            books.Add(new Book(Title, Author, Genre, Description, Quantity, CreatedDate));
        }

        // Редактиране на информацията за книга Void EditBook(Book book)

        public void DeleteBook(string Title) // deleting book
        {
            books.RemoveAll(Book => Book.Title == Title);
        }

        // Списък с кои книги не са върнати в срок List<Book> GetNotReturnedBooks()

        // Списък с кои книги е взел даден читател - търсене по ID на читател List<Book> GetBorrowedBooksByReader(int readerID)


    }
}
