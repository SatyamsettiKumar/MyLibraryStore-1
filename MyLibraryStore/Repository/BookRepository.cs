using MyLibraryStore.Data;
using MyLibraryStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibraryStore.Repository
{
    public class BookRepository : IBookRepository
    {
        private ApplicationDbContext _dbContext = null;

        public BookRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateBook(BookDetail book)
        {
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
        }

        public void DeleteBook(int? id)
        {
            var bookInDb = _dbContext.Books.SingleOrDefault(m => m.Id == id.Value);
            _dbContext.Books.Remove(bookInDb);
            _dbContext.SaveChanges();
        }

        public BookDetail GetBookById(int id)
        {
            return _dbContext.Books.ToList().SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<BookDetail> GetBooks()
        {
            return _dbContext.Books.ToList();
        }

        public void UpdateBook(int? id, BookDetail book)
        {
            if (id == null || book == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var bookInDb = _dbContext.Books.SingleOrDefault(m => m.Id == id.Value);
            if (bookInDb == null)
            {
                throw new NullReferenceException();
            }
            bookInDb.BookName= book.BookName;
            bookInDb.Author = book.Author;
            bookInDb.ISBN= book.ISBN;
            bookInDb.PublishedDate = book.PublishedDate;
            bookInDb.Genre = book.Genre;
            _dbContext.SaveChanges();
        }
    }
}
