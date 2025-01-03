using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyDemoApplication.Models;

namespace MyDemoApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private CompanyContext context;

        public HomeController(ILogger<HomeController> logger, CompanyContext cc)
        {
            _logger = logger;
            context = cc;
        }

        public string createInformation()
        {
            var info = new Information()
            {
                Name = "ChangePond",
                License = "234FGE234",
                Revenue = 100000000,
                Established = Convert.ToDateTime("01-01-2000")
            };
            context.Entry(info).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            context.SaveChanges();
            return "Record Created Successfully";
        }

        public IActionResult Index()
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
