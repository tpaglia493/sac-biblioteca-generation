using BibliotecaDipendentiSAC.Database;
using BibliotecaDipendentiSAC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaDipendentiSAC.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            using (LibraryContext db = new())
            {
                List<Book> books = db.Books.ToList();
                return View(books);
            }
        }
        public IActionResult Order(int id)
        {

            using (LibraryContext db = new())
            {
                Book? bookToOrder = db.Books.Where(book => book.Id == id).FirstOrDefault();
                if (bookToOrder != null)
                {
                    bookToOrder.AvailableCopies = bookToOrder.AvailableCopies - 1;
                    db.SaveChanges();
                    if (bookToOrder.AvailableCopies == 0) { bookToOrder.Bookable = false; db.SaveChanges(); }
                }
                else
                {
                    return NotFound("ciao ciao");
                }
                return RedirectToAction("Index");
            }
        }

    }
}
