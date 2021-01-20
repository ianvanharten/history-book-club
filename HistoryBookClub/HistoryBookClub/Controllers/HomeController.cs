using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HistoryBookClub.Models;
using Microsoft.AspNetCore.Mvc;

namespace HistoryBookClub.Controllers
{
    public class HomeController : Controller
    {
        private HistoryBookClubContext context { get; set; }

        public HomeController(HistoryBookClubContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var books = context.Books
                .OrderBy(b => b.Title).ToList();

            return View(books);
        }

        public IActionResult Book(int id)
        {
            var book = context.Books
                .Where(b => b.BookId == id).FirstOrDefault<Book>();

            var topics = context.Topics
                .Where(t => t.BookId == id).ToList();

            ViewBag.Book = book;

            return View(topics);
        }
    }
}
