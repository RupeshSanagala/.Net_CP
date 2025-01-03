using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyDemoApplication.Models
{
    public class EmployeeController : Controller
    {
        private CompanyContext context;

        public EmployeeController(CompanyContext cc)
        {
            this.context = cc;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            List<SelectListItem> dept = new List<SelectListItem>();
            dept = context.Department.Select(x=>new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString()
            }).ToList();
            ViewBag.Department=dept;
            return View();
        }
    }
}
