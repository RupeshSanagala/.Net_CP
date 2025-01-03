using Microsoft.AspNetCore.Mvc;
using MyDemoApplication.Models;

namespace MyDemoApplication.Controllers
{
    public class InformationController : Controller
    {
        private CompanyContext context { get; set; }

        public InformationController(CompanyContext cc)
        {
            context = cc;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>Create(Information info)
        {
            context.Add(info);
            await context.SaveChangesAsync();
            return View();

        }
    }
}
