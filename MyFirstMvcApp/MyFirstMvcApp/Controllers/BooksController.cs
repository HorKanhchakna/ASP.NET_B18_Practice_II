using Microsoft.AspNetCore.Mvc;

namespace MyFirstMvcApp.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the book index page.");
        }

        public IActionResult All()
        {
            return Content("<h1>Here is a list of ALL books!</h1>", "text/html");
        }

        //public IActionResult Details()
        //{
        //    return Content("This will show details for one book.");
        //}

        public IActionResult OldCatalog()
        {
            return RedirectToAction("All", "Books");
        }

        public IActionResult Details(int id)
        {
            return Content($"Showing details for book with ID: {id}");
        }



    }
}
