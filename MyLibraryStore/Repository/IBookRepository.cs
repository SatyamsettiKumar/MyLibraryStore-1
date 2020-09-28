using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyLibraryStore.Models;

namespace MyLibraryStore.Repository
{
    public interface IBookRepository
    {
        IEnumerable<BookDetail> GetBooks();
        BookDetail GetBookById(int id);
        void CreateBook(BookDetail book);
        void UpdateBook(int? id,BookDetail book);
        void DeleteBook(int? id);

    }
}
