using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using School.Data.Entities;
using School.Data.ViewModels;
using School.DataAccess;

namespace School.WebApplication.Areas.TeacherUsers.Controllers
{
   // [Authorize(Roles="Teacher")]
    [Area("TeacherUsers")]
    public class SkillsStudentBehaviorsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public string UserEmail;
        public int TeacherUserId;
        public SkillsStudentBehaviorsController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _HttpContextAccessor = httpContextAccessor;
            UserEmail = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;
            TeacherUserId = _context.Teacher.Where(d => d.EmailAddress == UserEmail).Select(d => d.Id).FirstOrDefault();

        }


        public IActionResult Create(int? Id)
        {
            SkillsBehaviorViewModel model = new SkillsBehaviorViewModel()
            {
                SubjectsDrop = _context.Subject.Where(d => d.TeacherId == TeacherUserId).Where(d => d.ClassId == Id).Select(i => new SelectListItem { Text = i.Name, Value = i.Id.ToString() }),
                SkillsTypeDrop = _context.SkillsType.Select(i => new SelectListItem { Text = i.Name, Value = i.Id.ToString() }),
                StudentDrop = _context.Student.Where(d => d.ClassId == Id).Select(i => new SelectListItem { Text = i.FullName, Value = i.Id.ToString() }),
                DurationDrop = _context.Duration.Where(d => d.IsDelete != true).Select(i => new SelectListItem { Text = i.Name, Value = i.Id.ToString() })

            };

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SkillsBehaviorViewModel SkillsBehaviorViewModel)
        {
            if (ModelState.IsValid)
            {
                SkillsBehaviorViewModel.SkillsBehavior.CreatedAt = DateTime.Now;
                SkillsBehaviorViewModel.SkillsBehavior.CreatedBy = UserEmail;
                SkillsBehaviorViewModel.SkillsBehavior.TeacherId = TeacherUserId;
                SkillsBehaviorViewModel.SkillsBehavior.ClassId = _context.Student.Where(d => d.Id == SkillsBehaviorViewModel.SkillsBehavior.StudentId).Select(d => d.ClassId).FirstOrDefault();

                _context.Add(SkillsBehaviorViewModel.SkillsBehavior);
                await _context.SaveChangesAsync();
                return Redirect("https://localhost:44384/Skillss/Marks/Index");
            }
            return View(SkillsBehaviorViewModel);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SkillsBehaviorViewModel model = new SkillsBehaviorViewModel()
            {
                SubjectsDrop = _context.Subject.Where(d => d.TeacherId == TeacherUserId).Select(i => new SelectListItem { Text = i.Name, Value = i.Id.ToString() }),
                SkillsTypeDrop = _context.SkillsType.Select(i => new SelectListItem { Text = i.Name, Value = i.Id.ToString() }),
                StudentDrop = _context.Student.Select(i => new SelectListItem { Text = i.FullName, Value = i.Id.ToString() }),
                SkillsBehavior = _context.SkillsStudentBehavior.Find(id),
                DurationDrop = _context.Duration.Select(i => new SelectListItem { Text = i.Name, Value = i.Id.ToString() })
            };

            if (model.SkillsBehavior == null)
            {
                return NotFound();
            }

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, SkillsBehaviorViewModel model)
        {
            if (id != model.SkillsBehavior.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    model.SkillsBehavior.UpdatedAt = DateTime.Now;
                    model.SkillsBehavior.UpdatedBy = UserEmail;

                    _context.Update(model.SkillsBehavior);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SkillsStudentBehaviorExists(model.SkillsBehavior.Id))
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
            return View(model);
        }




        public async Task<IActionResult> GetStudentBE(int? id)
        {
            SkillsBehaviorViewModel model = new SkillsBehaviorViewModel();
            if (id == null)
            {
                return NotFound();
            }

            model.SkillsBehavior = await _context.SkillsStudentBehavior
            .Include(w => w.Class)
            .Include(w => w.Student)
            .Include(w => w.Subject)
            .Include(w => w.Teacher)
            .FirstOrDefaultAsync(m => m.StudentId == id);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }
         
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var SkillsStudentBehavior = await _context.SkillsStudentBehavior
                .Include(e => e.Class)
                .Include(e => e.Duration)
                .Include(e => e.SkillsType)
                .Include(e => e.Student)
                .Include(e => e.Subject)
                .Include(e => e.Teacher)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (SkillsStudentBehavior == null)
            {
                return NotFound();
            }

            return View(SkillsStudentBehavior);
        }

         [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var SkillsStudentBehavior = await _context.SkillsStudentBehavior.FindAsync(id);
            _context.SkillsStudentBehavior.Remove(SkillsStudentBehavior);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SkillsStudentBehaviorExists(int id)
        {
            return _context.SkillsStudentBehavior.Any(e => e.Id == id);
        }
    }
}
