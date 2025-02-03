using Library_Management_System.Models.Books;

namespace Library_Management_System.Models.BookImages
{
    public class BookImage
    {
        public int Id { get; set; }
        public string? Path { get; set; }
        public int BookId {  get; set; }
        public virtual Book? Book { get; set; }
    }
}
