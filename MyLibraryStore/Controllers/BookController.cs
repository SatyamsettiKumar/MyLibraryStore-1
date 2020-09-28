using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyLibraryStore.Models;
using MyLibraryStore.Repository;

namespace MyLibraryStore.Controllers
{
    
    public class BookController : Controller
    {
        private IBookRepository _bookrepos = null;

        public BookController(IBookRepository bookRepository)
        {
            _bookrepos = bookRepository;
        }
        public IActionResult Index()
        {
            var books = _bookrepos.GetBooks();
            return View(books);
        }

        public IActionResult Details(int id)
        {
            var book = _bookrepos.GetBookById(id);
            return View(book);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookDetail book)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _bookrepos.CreateBook(book);

            return RedirectToAction("Index","Book");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var book = _bookrepos.GetBookById(id);
            return View(book);
        }


        [HttpPost]
        public IActionResult Update(int id,BookDetail book)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _bookrepos.UpdateBook(id,book);
            return RedirectToAction("Index", "Book");
        }

        [HttpPost]
        public IActionResult Delete(int? id)
        {
            //if (id != null)
            //{
            //    return View(id);
            //}
            _bookrepos.DeleteBook(id);
            return RedirectToAction("Index", "Book");
        }
    }
}
