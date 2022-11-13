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
    public class SkillsBehaviorsController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public string UserEmail;
        public int TeacherUserId;

        public SkillsBehaviorsController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _HttpContextAccessor = httpContextAccessor;
            UserEmail = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;
            TeacherUserId = _context.Teacher.Where(d => d.EmailAddress == UserEmail).Select(d => d.Id).FirstOrDefault();

        }



        public async Task<IActionResult> GetStudentSkillsBehaviors(int? id)
        {
            var model = new SkillsBehaviorViewModel();
            if (id == null)
            {
                return NotFound();
            }
            model.Decisions = _context.Decisions.FirstOrDefault();
            model.SkillsBehaviorList = _context.SkillsBehavior
            .Include(w => w.Class)
            .Include(w => w.Student)
            .Include(w => w.Subject)
            .Include(w => w.Teacher).Include(w => w.CompletionType)
            .Where(m => m.StudentId == id)
            .ToList();
            if (model.SkillsBehaviorList.Any() == true)
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
            var model = new SkillsBehaviorViewModel();
            model.DurationDrop = _context.Duration.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name });
            model.CompletionTypeDrop = _context.CompletionType.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name });
            model.SubjectsDrop = _context.Subject.Where(d => d.TeacherId == TeacherUserId).Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name });
            model.StudentDrop = _context.Student.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.FullName });

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SkillsBehaviorViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.SkillsBehavior.ClassId = _context.Student.Where(d => d.Id == model.SkillsBehavior.StudentId).Select(s => s.ClassId).FirstOrDefault();
                model.SkillsBehavior.TeacherId = TeacherUserId;
                model.CreatedAt = DateTime.Now;
                model.CreatedBy = UserEmail;
                _context.Add(model.SkillsBehavior);
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

            var model = new SkillsBehaviorViewModel();
            model.DurationDrop = _context.Duration.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name });
            model.CompletionTypeDrop = _context.CompletionType.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name });
            model.SubjectsDrop = _context.Subject.Where(d => d.TeacherId == TeacherUserId).Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name });
            model.StudentDrop = _context.Student.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.FullName });



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
                    if (!SkillsBehaviorExists(model.SkillsBehavior.Id))
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



        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mark = await _context.SkillsBehavior
                .Include(m => m.Class)
                .Include(m => m.Student)
                .Include(m => m.Subject)
                .Include(m => m.Teacher)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mark == null)
            {
                return NotFound();
            }

            return View(mark);
        }

        // POST: TeacherUser/Marks1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mark = await _context.SkillsBehavior.FindAsync(id);
            mark.IsDelete = true;
            _context.SkillsBehavior.Update(mark);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool SkillsBehaviorExists(int id)
        {
            return _context.SkillsBehavior.Any(e => e.Id == id);
        }
    }
}
