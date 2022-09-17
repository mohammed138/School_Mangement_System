using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using School.Data.Entities;
using School.Data.ViewModels;
using School.DataAccess;

namespace School.WebApp.Areas.Manger.Controllers
{
    [Area("Manger")]
    [Authorize(Roles = "MangerRole")]
     public class MarksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MarksController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Mark.Include(m => m.Class).Include(m => m.Student).Include(m => m.Subject).Include(m => m.Teacher);
            return View(await applicationDbContext.ToListAsync());
        }
         
        public IActionResult Find(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MarkViewModel model = new MarkViewModel()
            {
                   MarkList = _context.Mark.Include(d => d.Class).Include(d => d.FinalSkillsType)
                   .Include(d => d.Student).Include(d => d.Teacher)
                       .Include(d => d.MSkillsType).Include(d => d.FSkillsType).Include(d => d.Subject)
                   .Where(d => d.StudentId == id).ToList(),
                   Student = _context.Student.Where(d => d.Id == id).FirstOrDefault()                   

            };


          

            //if (model.MarkList.Count()>0)
            //{ 
            //    model.TeacherName = _context.Mark.Where(d => d.Id == MarkIDs[0]).Select(d => d.Teacher.FullName).FirstOrDefault();
            //    model.StudentName = _context.Mark.Where(d => d.Id == MarkIDs[0]).Select(d => d.Student.FullName).FirstOrDefault();
            //    model.SubjectName = _context.Mark.Where(d => d.Id == MarkIDs[0]).Select(d => d.Subject.Name).FirstOrDefault();
            //}
            //else
            //{
            //    model.TeacherName = "";
            //    model.StudentName = "";
            //    model.SubjectName = "";
            //} 

            return View(model);
        }

 
    }
}
