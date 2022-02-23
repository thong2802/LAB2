﻿using LAB2.Models;
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
                Title = "Head First Desgin Pattern",
                PublicYear = 2020,
                price = 1.3000,
                Cover = "Content/images/book1.jpg"
           
            });

            listBooks.Add(new Book()
            {
                Id = 2,
                Title = "Head First Kotlin",
                PublicYear = 2022,
                price = 1.2000,
                Cover = "Content/images/book2.jpg"

            });

            listBooks.Add(new Book()
            {
                Id = 3,
                Title = "Head First Swift IOS",
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
    }
}