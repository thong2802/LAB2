using LAB2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LAB2.Controllers
{

    public class BooksController : Controller
    {
        private List<Book> listBooks;
        public BooksController()
        {
            listBooks = new List<Book>();
            listBooks.Add(new Book()
            {
                Id = 1,
                Title = "Book Python",
                Author = "1911065862 Nguyen Duc Thang",
                PublicYear = 2020,
                price = 1.3000,
                Cover = "Content/images/book1.jpg"
           
            });

            listBooks.Add(new Book()
            {
                Id = 2,
                Title = "Book Java",
                Author = "1911065862 Nguyen Duc Thang",
                PublicYear = 2022,
                price = 1.2000,
                Cover = "Content/images/book2.jpg"

            });

            listBooks.Add(new Book()
            {
                Id = 3,
                Title = "Book JS",
                Author = "1911065862 Nguyen Duc Thang",
                PublicYear = 2021,
                price = 1.8000,
                Cover = "Content/images/book3.jpg"

            });


        }



        // GET: Books
        public ActionResult ListBooks()
        {
            ViewBag.TitlePageName = "Book view page";
            return View(listBooks);
        }

        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();

            }
            Book book = listBooks.Find(x => x.Id == id);
            if(book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Book book = listBooks.Find(s => s.Id == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var editBook = listBooks.Find(b => b.Id == book.Id);
                    editBook.Title = book.Title;
                    editBook.Author = book.Author;
                    editBook.Title = book.Cover;
                    editBook.price = book.price;
                    editBook.PublicYear = book.PublicYear;
                    return View("ListBooks", listBooks);

                }catch (Exception ex)
                {
                    return HttpNotFound(ex.Message);
                }
            }else
            {
                ModelState.AddModelError("", "Input Model Not valide!");
                return View(book);
            }
        }
    }
}