using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult Index()
        {
            return View(context.Information.AsNoTracking());
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
        public async Task<IActionResult> Update(int id)
        {
            Information info = await context.Information.Where(x => x.Id == id).FirstOrDefaultAsync();
            return View(info);
        }
        [HttpPost]
        public async Task<IActionResult> Update(Information info)
        {
            context.Update(info);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var info = new Information() { Id = id };
            context.Remove(info);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
