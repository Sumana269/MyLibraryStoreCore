using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyLibraryStoreCore.Models;
using MyLibraryStoreCore.Repositories;

namespace MyLibraryStoreCore.Controllers
{
    public class BookController : Controller
    {
        private IBookRepository _bookRepos = null;
        public BookController(IBookRepository bookRepository)
        {
            _bookRepos = bookRepository;
        }
        public IActionResult Index()
        {
            var books = _bookRepos.GetBooks();
            return View(books);
        }
        public IActionResult Details(int id)
        {
            var book = _bookRepos.GetBookById(id);
            return View(book);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Books books)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _bookRepos.CreateBook(books);
            return RedirectToAction("Index", "Book");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var book = _bookRepos.GetBookById(id);
            return View(book);
        }
        [HttpPost]
        public IActionResult Edit(int? id,Books books)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _bookRepos.UpdateBook(id, books);
            return RedirectToAction("Index", "Book");
        }
        [HttpPost]
        public IActionResult DeleteBook(int id)
        {
            _bookRepos.DeleteBook(id);
            return RedirectToAction("Index", "Book");
        }
        public IActionResult NewAction()
        {
            return View();
        }
    }
}
