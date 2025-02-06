using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Library_Management_System.ViewModels.UserViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string userName { get; set; }
        [Required,PasswordPropertyText]
        public string password { get; set; }

    }
}
