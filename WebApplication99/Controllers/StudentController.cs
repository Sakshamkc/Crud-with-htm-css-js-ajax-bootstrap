
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using WebApplication99.Models;
using static WebApplication99.Helper;

namespace WebApplication99.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentDbContext _context;

        public StudentController(StudentDbContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
          var query = from x in _context.Students select x;
          return View(query.ToList());
        }
        [HttpGet]
        public ActionResult AddorEdit(int id = 0)
        {
            if (id == 0)
            {
                return View(new Student());
            }
            else
            {
              return View(_context.Students.Where(x => x.StudentId == id).FirstOrDefault<Student>());
                
            }
        }

        [HttpPost]
        public ActionResult AddorEdit(Student std)
        {
              if (std.StudentId == 0)
                {
                    _context.Students.Add(std);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    _context.Students.Update(std);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
            }
            
        }


       
     
    }
}
