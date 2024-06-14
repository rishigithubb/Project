using Microsoft.AspNetCore.Mvc;
using Project.Models;
using System.Diagnostics;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        private DatabaseContext _ctx;

        public HomeController(DatabaseContext ctx)
        {
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AddDetails() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDetails(Home home)
        {
            if(!ModelState.IsValid) 
            {
                return View();
            }
            try
            {
                _ctx.Add(home);
                _ctx.SaveChanges();
                TempData["msg"] = "Added Successfully";
                return RedirectToAction("AddDetails");
            }
            catch (Exception ex) 
            {
                TempData["msg"] = "Failed to Add";
                return View();
            }
        }
        public IActionResult Display(Home home) 
        {
            var persons=_ctx.home.ToList();
            return View(persons);   
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public JsonResult Countries()
        {
            var countries = _ctx.Countries.ToList();    
            return Json(countries);
        }
    }
}
