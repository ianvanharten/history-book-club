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
            return View();
        }
    }
}
