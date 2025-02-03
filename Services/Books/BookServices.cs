
using Library_Management_System.GenericReposatory;
using Library_Management_System.GenericReposatory.Books;

namespace Library_Management_System.Services.Books
{
    public class BookServices : IBookService
    { 
        private readonly IBookReposatory _reposatory;
        public BookServices(IBookReposatory reposatory)
        {
            _reposatory = reposatory;
        }

        public Task Create(Book b)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public Book GetBook(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetBooks()
        {
            return _reposatory.GetAll();

        }

        public Task Update(Book b)
        {
            throw new NotImplementedException();
        }
    }
}
