using Library_Management_System.Models.Books;
namespace Library_Management_System.Models.Categories
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<Book>? Books { get; set; }
    }
}
