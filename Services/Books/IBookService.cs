namespace Library_Management_System.Services.Books
{
    public interface IBookService
    {
        IEnumerable<Book> GetBooks();
        Book GetBook(int id);
        Task Create(Book b);
        Task Update(Book b);
        void delete(int id);

    }
}
