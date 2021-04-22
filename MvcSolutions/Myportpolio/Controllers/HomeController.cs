using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Myportpolio.Data;
using Myportpolio.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Myportpolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Profile()
        {
            var profile = _context.Manages.FirstOrDefault(p => p.Cate.Equals("Profile"));

            return View(profile);
        }

        public IActionResult Portfolio()
        {
            return View();
        }

        public IActionResult Board()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
