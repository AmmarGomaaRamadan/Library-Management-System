namespace Library_Management_System.Models.UserPreferedBooks
{
    public class UserPreferedBook
    {

        public string userId { get; set; }
        public virtual AppUser user { get; set; }
        public int BookId { get; set; }
        public virtual Book book { get; set; } 
        public DateTime PreferDate { get; set; }
      
    }
}
