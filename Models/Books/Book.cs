using Library_Management_System.Models.Authors;
using Library_Management_System.Models.Categories;
using Library_Management_System.Models.BookImages;
using Library_Management_System.Models.UserBooks;
using Library_Management_System.Models.UserPreferedBooks;
namespace Library_Management_System.Models.Books
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public byte Edition { get; set; }
        public int PublishYear {  get; set; }
        public int CategoryId {  get; set; }
        public virtual Category? Category { get; set; }
        public  int AuthorId {  get; set; }
        public virtual Author? Author { get; set; }
        public virtual ICollection<BookImage>? BookImages { get; set; }
        public virtual ICollection<UserBook>? UserBooks { get; set; }
        public virtual ICollection<UserPreferedBook>? UserPreferedBooks { get; set; }

        //public virtual ICollection<>
    }
}
