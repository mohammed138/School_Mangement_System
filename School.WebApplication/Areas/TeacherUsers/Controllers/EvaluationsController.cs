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
    public class SkillssController : Controller
    {
        private readonly ApplicationDbContext _context;
        public string UserEmail;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public int TeacherUserId;
        public SkillssController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            UserEmail = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;
            TeacherUserId = _context.Teacher.Where(d => d.EmailAddress == UserEmail).Select(d => d.Id).FirstOrDefault();

        }

        // GET: Manger/Skillss
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Skills.Include(e => e.Class).Include(e => e.Duration).Include(e => e.SkillsType).Include(e => e.Student).Include(e => e.Subject).Include(e => e.Teacher);
            return View(await applicationDbContext.ToListAsync());
        }
         
        public async Task<IActionResult> GetStudentSkills(int? id)
        {
            SkillsViewModel model = new SkillsViewModel();
            if (id == null)
            {
                return NotFound();
            }

            model.Skills = await _context.Skills
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

        public IActionResult Create(int? Id)
        {
            SkillsViewModel model = new SkillsViewModel()
            {
                SubjectsDrop = _context.Subject.Where(d => d.TeacherId == TeacherUserId).Where(d=>d.ClassId == Id).Select(i => new SelectListItem { Text = i.Name, Value = i.Id.ToString() }),
                SkillsTypeDrop = _context.SkillsType.Select(i => new SelectListItem { Text = i.Name, Value = i.Id.ToString() }),
                StudentDrop = _context.Student.Where(d => d.ClassId == Id).Select(i => new SelectListItem { Text = i.FullName, Value = i.Id.ToString() }),
                DurationDrop = _context.Duration.Where(d=>d.IsDelete != true).Select(i=>new SelectListItem { Text=i.Name,Value =i.Id.ToString() }) 
                 
            };

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SkillsViewModel SkillsViewModel)
        {
            if (ModelState.IsValid)
            {
                SkillsViewModel.Skills.CreatedAt = DateTime.Now;
                SkillsViewModel.Skills.CreatedBy = UserEmail;
                SkillsViewModel.Skills.TeacherId = TeacherUserId;
                SkillsViewModel.Skills.ClassId = _context.Student.Where(d => d.Id == SkillsViewModel.Skills.StudentId).Select(d => d.ClassId).FirstOrDefault();

                _context.Add(SkillsViewModel.Skills);
                await _context.SaveChangesAsync();
                return Redirect("https://localhost:44384/Skillss/Marks/Index");
            }
            return View(SkillsViewModel);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SkillsViewModel model = new SkillsViewModel()
            {
                SubjectsDrop = _context.Subject.Where(d => d.TeacherId == TeacherUserId).Select(i => new SelectListItem { Text = i.Name, Value = i.Id.ToString() }),
                SkillsTypeDrop = _context.SkillsType.Select(i => new SelectListItem { Text = i.Name, Value = i.Id.ToString() }),
                StudentDrop = _context.Student.Select(i => new SelectListItem { Text = i.FullName, Value = i.Id.ToString() }),
                Skills = _context.Skills.Find(id),
                DurationDrop = _context.Duration.Select(i => new SelectListItem { Text = i.Name , Value = i.Id.ToString()})
            };

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
                return RedirectToAction(nameof(Index));
            } 
            return View(model);
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Skills = await _context.Skills
                .Include(e => e.Class)
                .Include(e => e.Duration)
                .Include(e => e.SkillsType)
                .Include(e => e.Student)
                .Include(e => e.Subject)
                .Include(e => e.Teacher)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Skills == null)
            {
                return NotFound();
            }

            return View(Skills);
        }
         
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Skills = await _context.Skills
                .Include(e => e.Class)
                .Include(e => e.Duration)
                .Include(e => e.SkillsType)
                .Include(e => e.Student)
                .Include(e => e.Subject)
                .Include(e => e.Teacher)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Skills == null)
            {
                return NotFound();
            }

            return View(Skills);
        }

        // POST: Manger/Skillss/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Skills = await _context.Skills.FindAsync(id);
            _context.Skills.Remove(Skills);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SkillsExists(int id)
        {
            return _context.Skills.Any(e => e.Id == id);
        }
    }
}
