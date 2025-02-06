using Library_Management_System.Models.UserBooks;
using Library_Management_System.Models.UserPreferedBooks;
using Microsoft.AspNetCore.Identity;

namespace Library_Management_System.Models.Users
{
    public class AppUser: IdentityUser
    {
       
        public string qualifaction {  get; set; }

        public virtual ICollection<UserBook> UserBooks { get; set; }
        public virtual ICollection<UserPreferedBook> UserPreferedBooks { get; set; }


        public string personalImagePath {  get; set; }

    }
}
