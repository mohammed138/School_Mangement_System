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

namespace School.Web.Areas.TeacherUsers.Controllers
{
    //[Authorize(Roles="Teacher")]
    [Area("TeacherUsers")]
    public class SkillsSuggestionssController : Controller
    { 
        private readonly ApplicationDbContext _context;
        public string UserEmail;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public int TeacherUserId;
        public SkillsSuggestionssController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            UserEmail = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;
            TeacherUserId = _context.Teacher.Where(d => d.EmailAddress == UserEmail).Select(d => d.Id).FirstOrDefault();

        }


        // GET: TeacherUsers/SkillsSuggestionss
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SkillsSuggestions.Include(w => w.Class).Include(w => w.Student).Include(w => w.Subject).Include(w => w.Teacher);
            return View(await applicationDbContext.ToListAsync());
        }



        public async Task<IActionResult> GetStudentWS(int? id)
        {
            SkillsSuggestionsViewModel model = new SkillsSuggestionsViewModel();
            if (id == null)
            {
                return NotFound();
            }

                model.SkillsSuggestions =  _context.SkillsSuggestions
                .Include(w => w.Class)
                .Include(w => w.Student)
                .Include(w => w.Subject)
                .Include(w => w.Teacher)
                .Where(m => m.Id == id).FirstOrDefault();
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }



        public IActionResult Create(int? Id)
        {
            SkillsSuggestionsViewModel model = new SkillsSuggestionsViewModel()
            {
                SubjectDrop = _context.Subject.Where(d => d.TeacherId == TeacherUserId).Where(d => d.ClassId == Id).Select(i => new SelectListItem { Text = i.Name, Value = i.Id.ToString() }),
                StudentDrop = _context.Student.Where(d => d.ClassId == Id).Select(i => new SelectListItem { Text = i.FullName, Value = i.Id.ToString() }),

            }; 
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SkillsSuggestionsViewModel SkillsSuggestionsViewModel)
        {
            if (ModelState.IsValid)
            {
                SkillsSuggestionsViewModel.SkillsSuggestions.CreatedAt = DateTime.Now;
                SkillsSuggestionsViewModel.SkillsSuggestions.CreatedBy = UserEmail;
                SkillsSuggestionsViewModel.SkillsSuggestions.TeacherId = TeacherUserId;
                SkillsSuggestionsViewModel.SkillsSuggestions.ClassId = _context.Student.Where(d => d.Id == SkillsSuggestionsViewModel.SkillsSuggestions.StudentId).Select(d => d.ClassId).FirstOrDefault();

                _context.Add(SkillsSuggestionsViewModel.SkillsSuggestions);
                await _context.SaveChangesAsync();
                return Redirect(nameof(Index));
            }
            return View(SkillsSuggestionsViewModel);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SkillsSuggestionsViewModel model = new SkillsSuggestionsViewModel()
            {
                SubjectDrop = _context.Subject.Where(d => d.TeacherId == TeacherUserId).Select(i => new SelectListItem { Text = i.Name, Value = i.Id.ToString() }),
                StudentDrop = _context.Student.Select(i => new SelectListItem { Text = i.FullName, Value = i.Id.ToString() }),
                SkillsSuggestions = _context.SkillsSuggestions.Find(id),
             };

            if (model.SkillsSuggestions == null)
            {
                return NotFound();
            }

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, SkillsSuggestionsViewModel model)
        {
            if (id != model.SkillsSuggestions.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    model.SkillsSuggestions.UpdatedAt = DateTime.Now;
                    model.SkillsSuggestions.UpdatedBy = UserEmail;

                    _context.Update(model.SkillsSuggestions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SkillsSuggestionsExists(model.SkillsSuggestions.Id))
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





        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var SkillsSuggestions = await _context.SkillsSuggestions
                .Include(w => w.Class)
                .Include(w => w.Student)
                .Include(w => w.Subject)
                .Include(w => w.Teacher)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (SkillsSuggestions == null)
            {
                return NotFound();
            }

            return View(SkillsSuggestions);
        }

        // POST: TeacherUsers/SkillsSuggestionss/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var SkillsSuggestions = await _context.SkillsSuggestions.FindAsync(id);
            _context.SkillsSuggestions.Remove(SkillsSuggestions);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SkillsSuggestionsExists(int id)
        {
            return _context.SkillsSuggestions.Any(e => e.Id == id);
        }
    }
}
