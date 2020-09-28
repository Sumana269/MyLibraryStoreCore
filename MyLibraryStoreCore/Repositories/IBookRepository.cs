using MyLibraryStoreCore.Models;
using System.Collections.Generic;

namespace MyLibraryStoreCore.Repositories
{
    public interface IBookRepository
    {
        IEnumerable<Books> GetBooks();
        Books GetBookById(int id);
        void CreateBook(Books books);
        void UpdateBook(int? id,Books books);
        void DeleteBook(int? id);
    }
}
