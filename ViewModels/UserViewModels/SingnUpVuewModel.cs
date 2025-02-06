using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Library_Management_System.Models.UserBooks;
using Library_Management_System.Models.UserPreferedBooks;
using System.Diagnostics.CodeAnalysis;

namespace Library_Management_System.ViewModels.UserViewModels
{
    public class SingnUpVuewModel
    {
        [Required]
        public string userName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, PasswordPropertyText]
        public string password { get; set; }
        [AllowNull,MaxLength(150)]
        public string qualifaction { get; set; }
        [AllowNull]
        public string personalImagePath { get; set; }
    }
}
