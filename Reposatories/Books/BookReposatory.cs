

using Library_Management_System.Reposatories.GenericReposatory;

namespace Library_Management_System.GenericReposatory.Books
{
    public class BookReposatory : Reposatory<Book>, IBookReposatory
    {
        public BookReposatory(ApplicationDbContext context) : base(context)
        {
        }
    }
} 
