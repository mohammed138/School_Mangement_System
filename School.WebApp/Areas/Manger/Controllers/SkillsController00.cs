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

namespace School.WebApp.Areas.Manger.Controllers
{
    [Area("MangerRole")]
    public class SkillsController00 : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public string UserEmail;
        public int TeacherUserId;

        public SkillsController00(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
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
            model.SkillsTypeDrop = _context.SkillsType.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name });
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
                return RedirectToAction(nameof(GetStudentSkills));
            }

            return View(model);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skills = await _context.Skills.FindAsync(id);
            if (skills == null)
            {
                return NotFound();
            }
            ViewData["ClassId"] = new SelectList(_context.Classes, "Id", "Name", skills.ClassId);
            ViewData["DurationId"] = new SelectList(_context.Duration, "Id", "Name", skills.DurationId);
            ViewData["SkillsTypeId"] = new SelectList(_context.SkillsType, "Id", "Id", skills.SkillsTypeId);
            ViewData["StudentId"] = new SelectList(_context.Student, "Id", "AddressName", skills.StudentId);
            ViewData["SubjectId"] = new SelectList(_context.Subject, "Id", "Name", skills.SubjectId);
            ViewData["TeacherId"] = new SelectList(_context.Teacher, "Id", "FirstName", skills.TeacherId);
            return View(skills);
        }

         [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,ClassId,SubjectId,StudentId,TeacherId,DurationId,SkillsTypeId,Notice,CreatedBy,UpdatedBy,CreatedAt,UpdatedAt,IsActive,IsDelete,IsArchive")] Skills skills)
        {
            if (id != skills.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(skills);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SkillsExists(skills.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClassId"] = new SelectList(_context.Classes, "Id", "Name", skills.ClassId);
            ViewData["DurationId"] = new SelectList(_context.Duration, "Id", "Name", skills.DurationId);
            ViewData["SkillsTypeId"] = new SelectList(_context.SkillsType, "Id", "Id", skills.SkillsTypeId);
            ViewData["StudentId"] = new SelectList(_context.Student, "Id", "AddressName", skills.StudentId);
            ViewData["SubjectId"] = new SelectList(_context.Subject, "Id", "Name", skills.SubjectId);
            ViewData["TeacherId"] = new SelectList(_context.Teacher, "Id", "FirstName", skills.TeacherId);
            return View(skills);
        }

       






        private bool SkillsExists(int id)
        {
            return _context.Skills.Any(e => e.Id == id);
        }
    }
}
