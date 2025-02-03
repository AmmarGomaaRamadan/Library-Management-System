using Library_Management_System.Models.Books;
namespace Library_Management_System.Models.Authors
{
    public class Author
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? personalImage {  get; set; }
        public string? Nationality { get; set; } 
       public virtual ICollection<Book>? Books { get; set; }
    }
}
