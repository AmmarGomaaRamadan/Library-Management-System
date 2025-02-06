using Library_Management_System.ViewModels.UserViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Library_Management_System.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public UserController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Login() 
        {
           // var model =new LoginViewModel() {Email=string.Empty,password=string.Empty};
            return View();
        } 
        [HttpPost] 
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.userName, model.password, false, false);
                if (result.Succeeded)
                    return RedirectToAction("Index", "Home");
                return View();
            }
            return View();
        }
        public IActionResult SignUp() 
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(SingnUpVuewModel model)
        {
            if (!ModelState.IsValid) 
            {
                return View();

            }
            AppUser user = new AppUser
            {
                UserName=model.userName,
                Email = model.Email,
                personalImagePath=model.personalImagePath,
                qualifaction = model.qualifaction,
            };
            var result = await _userManager.CreateAsync(user, model.password);
            if (result.Succeeded)
                return RedirectToAction("Login");
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();

            }

        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }

    }
}
