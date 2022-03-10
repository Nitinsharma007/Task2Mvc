using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task2MVC.Models;

namespace Task2MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
           

            //ViewData

            ViewData["Name"] = "Fazal";
            ViewData["Age"] = 19;
            ViewData["Email"] = "Fazalmahfooz786@gmail.com";
            ViewData["University"] = "IFTM University";
            ViewData["Time"] = DateTime.Now;

            List<string> DataList = new List<string>()
            {
                "India",
                "USA",
                "Russia"
            };

            //TempData

            TempData["Name"] = "Askeen";
            TempData["Age"] = 20;
            TempData["Email"] = "Askeen786@gmail.com";
            TempData["University"] = "IFTM University";
            TempData["Time"] = DateTime.Now;

            //list<string> tlist = new list<string>()
            //{
            //    "india",
            //    "usa",
            //    "russia"
            //};



            //Session
            //Session["Name"] = "Tabrez";
            //Session["Age"] = 20;
            //Session["Email"] = "Askeen786@gmail.com";
            //Session["University"] = "IFTM University";
            //Session["Time"] = DateTime.Now;

            return View();
        }

        public IActionResult Privacy()
        {
            //ViewBag

            ViewBag.Name = "Nitin";
            ViewBag.Age = 20;
            ViewBag.Email = "Sharmanitin2246@gmail.com";
            ViewBag.University = "IFTM University";
            ViewBag.Time = DateTime.Now;

            ViewBag.list = new List<string>()
            {
                "India",
                "USA",
                "Russia"

            };

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}