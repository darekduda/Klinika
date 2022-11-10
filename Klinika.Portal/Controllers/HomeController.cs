using Klinika.Data.Data;
using Klinika.Portal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Klinika.Portal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly KlinikaContext _context;

        public HomeController(KlinikaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.ModelGodzinyOtwarcia =
                (
                from godzinyotwarcia in _context.GodzinyOtwarcia
                where godzinyotwarcia.CzyAktywny == true
                orderby godzinyotwarcia.PozycjaWyswietlania
                select godzinyotwarcia
                ).ToList();

            return View();
        }

        public IActionResult ONas()
        {
            return View();
        }

        public IActionResult Kontakt()
        {
            return View();
        }
        public IActionResult Lekarze()
        {
            return View();
        }
        public IActionResult Uslugi()
        {
            return View();
        }
        public IActionResult Specjalizacje()
        {
            return View();
        }

        public IActionResult Privacy()
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
