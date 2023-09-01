using day16.Context;
using day16.Models;
using day16.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace day16.Controllers
{
    public class BookController : Controller
    {
        
        public IActionResult Index()
        {
            var context =new ApplicationContext();
            var books = context.Books.ToList();

            return View(books);
            
        }

        public IActionResult Details(int id) 
        {
            var context = new ApplicationContext();
            var books = context.Books.ToList();
            var book = books.FirstOrDefault(x => x.Id == id);

            return View(books);
        
        }



        public IActionResult Newbook() 
        {
            var context = new ApplicationContext();
            var author = context.Author.ToList();
            ViewData["Author"]= author;

            return View();
        
        }

        public IActionResult Savebook(Addbook newbok)
        {
            var context = new ApplicationContext();

            if (ModelState.IsValid) 
            {
                
                var newbook = new Book()
                {
                    Name = newbok.Name,
                    Price = newbok.Price,
                    Category = newbok.Category,
                    AuthorId = newbok.AuthorId,

                };

                context.Books.Add(newbook);
                context.SaveChanges();


                return RedirectToAction("Index");

            }
            else
            {
                ViewData["Author"]=context.Author.ToList();
                var bok = new Book()
                {
                    Name = newbok.Name,
                    Price = newbok.Price,
                    Category = newbok.Category,
                    AuthorId = newbok.AuthorId,
                };

                return View("Newbook",bok);
            }
            
        }


        public IActionResult Updatebook(int id)
        {
            var context = new ApplicationContext();
            var book = context.Books.FirstOrDefault(x => x.Id == id);

            ViewData["Author"] = context.Author.ToList();


            return View(book);

        }


        public IActionResult Saveupdatebook(int id , Addbook updatebook)
        {
            var context = new ApplicationContext();
            var book = context.Books.FirstOrDefault(x => x.Id == id);
            book.Name = updatebook.Name;
            book.Price = updatebook.Price;
            book.Category = updatebook.Category;
            book.AuthorId = updatebook.AuthorId;
            context.SaveChanges();

            return RedirectToAction("Index");
           
        }


        public IActionResult Delete( int id)
        {
            var context = new ApplicationContext();
            var book = context.Books.FirstOrDefault( x => x.Id == id);
            context.Books.Remove(book);
            context.SaveChanges();

            return RedirectToAction("Index");
        }




    }
}
