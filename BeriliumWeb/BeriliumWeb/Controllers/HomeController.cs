
using BeriliumWeb.DAL;
using BeriliumWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BeriliumWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly BeriliumWebDbContext db;

        public HomeController(BeriliumWebDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            HomeViewModel hvm = new HomeViewModel
            {
                Banners = db.Banners.ToList(),
                Works = db.Works.ToList(),
                News = db.News.ToList(),
                Testimonials = db.Testimonials.FirstOrDefault(),
                Features = db.Features.ToList()
            };

            return View(hvm);
        }




    }
}
