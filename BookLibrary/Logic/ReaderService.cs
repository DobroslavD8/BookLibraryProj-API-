using BookLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Logic
{
    class ReaderService
    {
        List<Reader> books = new List<Reader>();
        public void AddBook(string FirstName, string LastName, string PhoneNumber, DateTime CreatedDate, DateTime ReturnedDate) // adding reader
        {
            books.Add(new Reader(FirstName, LastName, PhoneNumber, CreatedDate, ReturnedDate));
        }

        // Редактиране информацията за читател на библиотеката Void EditReader(Reader reader)

        public void DeleteReader(int id) // deleting reader
        {
            books.RemoveAll(Reader => Reader.id == id);
        }

        // Заемане на книга от читател Void BorrowBook(int bookID, int readerID)

        // Връщане на книга от читател Int ReturnBook(int bookID, int readerID)
    }
}
