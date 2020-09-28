using MyLibraryStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibraryStore.Repository
{
    public class MockBookRepository : IBookRepository
    {
        public void CreateBook(BookDetail book)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(int? id)
        {
            throw new NotImplementedException();
        }

        public BookDetail GetBookById(int id)
        {
            var books = GetBooks();
            return books.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<BookDetail> GetBooks()
        {
            return new List<BookDetail>
            {
                new BookDetail{Id=1, BookName="Harry Potter",Author="JK Rowling", ISBN="I234566",PublishedDate=Convert.ToDateTime("10/12/1999") },
                new BookDetail{Id=1, BookName="Kengan Ashura",Author="Chineses Manga", ISBN="I908566",PublishedDate=Convert.ToDateTime("07/10/2014") },
                new BookDetail{Id=1, BookName="Omega",Author="Maangaa", ISBN="I234786",PublishedDate=Convert.ToDateTime("02/08/2016") },
            };
        }

        public void UpdateBook(int? id, BookDetail book)
        {
            throw new NotImplementedException();
        }
    }
}
