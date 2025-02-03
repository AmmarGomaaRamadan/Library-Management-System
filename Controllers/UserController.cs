using Microsoft.AspNetCore.Mvc;

namespace Library_Management_System.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Login()
        {
            return View();
        }
        public async Task<IActionResult> SignUp()
        {
            return View();
        }
    }
}
