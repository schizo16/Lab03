using Microsoft.AspNetCore.Mvc;
using Lab03.Models;
namespace Lab03.ViewComponents
{
    public class BookViewComponents : ViewComponent
    {
        protected Book book = new Book();
        public IViewComponentResult Invoke()
        {
            var books = book.GetBookList();

            return View(books);
        }
    }
}
