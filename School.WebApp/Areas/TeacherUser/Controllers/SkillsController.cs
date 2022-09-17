using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using School.Data.Entities;
using School.Data.ViewModels;
using School.DataAccess;

namespace School.WebApp.Areas.TeacherUser.Controllers
{
    [Area("TeacherUser")]
    public class SkillsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public string UserEmail;
        public int TeacherUserId;

        public SkillsController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _HttpContextAccessor = httpContextAccessor;
            UserEmail = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;
            TeacherUserId = _context.Teacher.Where(d => d.EmailAddress == UserEmail).Select(d => d.Id).FirstOrDefault();

        }


        public async Task<IActionResult> GetStudentSkills(int? id)
        {
            var model = new SkillsViewModel();
            if (id == null)
            {
                return NotFound();
            }
            model.Decisions = _context.Decisions.FirstOrDefault(); 
            model.SkillsList =  _context.Skills
            .Include(w => w.Class)
            .Include(w => w.Student)
            .Include(w => w.Subject)
            .Include(w => w.CompletionType)
            .Include(w => w.Teacher)
            .Where(m => m.StudentId == id)
            .ToList();
            if (model.SkillsList.Any() == true)
            {
                model.IsActive = true;
            }
            else
            {
                model.IsActive = false;
            }

            return View(model);
        }


        public IActionResult Create(int? ClassID)
        {
            var model = new SkillsViewModel(); 
            model.DurationDrop = _context.Duration.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name });
            model.CompletionTypeDrop = _context.CompletionType.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name });
            model.SubjectsDrop = _context.Subject.Where(d=>d.TeacherId == TeacherUserId).Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name });
            model.StudentDrop = _context.Student.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.FullName });
             
            return View(model);
        } 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SkillsViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.Skills.ClassId = _context.Student.Where(d => d.Id == model.Skills.StudentId).Select(s => s.ClassId).FirstOrDefault();
                model.Skills.TeacherId = TeacherUserId;
                model.CreatedAt = DateTime.Now;
                model.CreatedBy = UserEmail; 
                _context.Add(model.Skills);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Classes");
            }

            return View(model);
        } 
         
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = new SkillsViewModel();
            model.DurationDrop = _context.Duration.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name });
            model.CompletionTypeDrop = _context.CompletionType.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name });
            model.SubjectsDrop = _context.Subject.Where(d => d.TeacherId == TeacherUserId).Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name });
            model.StudentDrop = _context.Student.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.FullName });



            if (model.Skills == null)
            {
                return NotFound();
            }

            return View(model);
        }

         [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, SkillsViewModel model)
        {
            if (id != model.Skills.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    model.Skills.UpdatedAt = DateTime.Now;
                    model.Skills.UpdatedBy = UserEmail;

                    _context.Update(model.Skills);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SkillsExists(model.Skills.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", "Classes");
            }
            return View(model);
        }





 
        private bool SkillsExists(int id)
        {
            return _context.Skills.Any(e => e.Id == id);
        }
    }
}
