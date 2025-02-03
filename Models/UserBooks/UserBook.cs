namespace Library_Management_System.Models.UserBooks
{
    public class UserBook
    {

        public string UserId { get; set; }
        public virtual AppUser user { get; set; }
        public int BookId { get; set; }
        public virtual Book book { get; set; } 
        public DateTime startRead { get; set; }
        public string status {  get; set; }
        public int pageNum { get; set; }

    }
}
