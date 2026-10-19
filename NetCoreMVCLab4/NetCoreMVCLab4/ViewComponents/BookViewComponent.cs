using Microsoft.AspNetCore.Mvc;
using NetCoreMVCLab4.Models;

namespace NetCoreMVCLab4.ViewComponents
{
    public class BookViewComponent : ViewComponent
    {
        protected Book book = new Book();

        public IViewComponentResult Invoke()
        {
            var books = book.GetBookList();

            return View(books);
        }
    }
}