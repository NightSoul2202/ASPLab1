using ASPLab1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPLab1.Controllers
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
            var companys = new List<CompanyModel>
            {
                new CompanyModel { Id = 1, Name = "First Company", Description = "Description of first company", Capitalization = 540.2 },
                new CompanyModel { Id = 2, Name = "Second Company", Description = "Description of second company", Capitalization = 650.0 },
                new CompanyModel { Id = 3, Name = "Third Company", Description = "Description of third company", Capitalization = 120.4 }
            };

            //return View(companys);

            Random random = new Random();
            return View(random.Next(100));
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
