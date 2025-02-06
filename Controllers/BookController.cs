using Library_Management_System.GenericReposatory;
using Library_Management_System.Services.Books;
using Microsoft.AspNetCore.Mvc;

namespace Library_Management_System.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        public IActionResult Index()
        {
            var data=_bookService.GetBooks();
            return View(data);
        }
        public IActionResult Details(int id)
        {
            var data = _bookService.GetBook(id);
            return View(data);
        }
    }
}
