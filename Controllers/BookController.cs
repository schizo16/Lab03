using Lab03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab03.Controllers
{
    public class BookController : Controller
    {
        protected Book book = new Book();
        public IActionResult Index()
        {

            //selectListItem để hiển thị trên combobox
            
            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;
            var books = book.GetBookList();
            
            return View();
        }
    }
}
