﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyDemoApplication.Models;

namespace MyDemoApplication.Controllers
{
    public class DepartmentController : Controller
    {
        private CompanyContext context {  get; set; }   
        public DepartmentController(CompanyContext cc) { 
            context = cc;
        }

        public IActionResult Index()
        {
            return View(context.Department.AsNoTracking());
        }
         public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
       public async Task<IActionResult> Create(Department dept)
        {
            context.Add(dept);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult>Update(int id)
        {
            Department dept = await context.Department.Where(x => x.Id == id).FirstOrDefaultAsync();    
            return View(dept);
        }
        [HttpPost]
        public async Task<IActionResult> Update(Department dept)
        {
            context.Update(dept);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult>Delete(int id)
        {
            var dept = new Department() { Id = id };
            context.Remove(dept); 
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        //public string create()
        //{
        //    var dept = new Department()
        //    {
        //        Name = "Designing"
        //    };
        //    context.Entry(dept).State = Microsoft.EntityFrameworkCore.EntityState.Added;
        //    context.SaveChanges();
        //    return "Department Added Successfully";
        //}
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
