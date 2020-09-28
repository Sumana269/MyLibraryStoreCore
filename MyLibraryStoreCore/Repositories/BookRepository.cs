using MyLibraryStoreCore.Data;
using MyLibraryStoreCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace MyLibraryStoreCore.Repositories
{
    public class BookRepository : IBookRepository
    {
        private ApplicationDbContext _dbContext = null;
        public BookRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

       

        public Books GetBookById(int id)
        {
            return _dbContext.Books.ToList().SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Books> GetBooks()
        {
            return _dbContext.Books.ToList();
        }
        public void CreateBook(Books books)
        {
            _dbContext.Add(books);
            _dbContext.SaveChanges();
        }
        public void UpdateBook(int? id,Books books)
        {
            if(id==null || books == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            var Ub = _dbContext.Books.SingleOrDefault(x => x.Id == id);
            if (Ub == null)
            {
                throw new ArgumentNullException();
            }
            Ub.BookName = books.BookName;
            Ub.Author = books.Author;
            Ub.ISBN = books.ISBN;
            Ub.PublishedDate = books.PublishedDate;
            _dbContext.SaveChanges();
        }
        public void DeleteBook(int? id)
        {
            var book = _dbContext.Books.SingleOrDefault(x => x.Id == id);
           _dbContext.Books.Remove(book);
           _dbContext.SaveChanges();
            
            
        }
    }
}
