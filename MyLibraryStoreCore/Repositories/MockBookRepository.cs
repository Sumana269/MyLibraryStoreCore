using MyLibraryStoreCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace MyLibraryStoreCore.Repositories
{
    public class MockBookRepository : IBookRepository
    {
        public void CreateBook(Books books)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(int? id)
        {
            throw new NotImplementedException();
        }

        public Books GetBookById(int id)
        {
            var books = GetBooks();
            return books.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Books> GetBooks()
        {
            return new List<Books>
            {
                new Books{Id=1,BookName="Wings of Fire",Author="Apj kalam",ISBN="IS123",PublishedDate=Convert.ToDateTime("10/12/2015"),Gener="LoveStory"},
                new Books{Id=2,BookName="3friends",Author="john",ISBN="IS124",PublishedDate=Convert.ToDateTime("02/10/2009"),Gener="RealStory"},
                new Books{Id=3,BookName="Hello",Author="Rocky",ISBN="IS125",PublishedDate=Convert.ToDateTime("09/10/2005"),Gener="Thriller"}
            };
        }

        public void UpdateBook(int? id,Books books)
        {
            throw new NotImplementedException();
        }
    }
}
