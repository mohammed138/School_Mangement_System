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

namespace School.WebApp.Areas.Manger.Controllers
{
    [Area("Manger")]
    [Authorize(Roles = "MangerRole")]
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public string UserEmail;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public StudentsController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            UserEmail = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;

        }

        public async Task<IActionResult> GetAll()
        {
            var model = new StudentViewModel();
            model.StudentList = _context.Student
                .Include(s => s.Class)
                .Include(s => s.Gender).Include(s => s.Semester).Where(d => d.IsDelete != true).ToList();
            return View(model);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .Include(s => s.Class)
                .Include(s => s.Gender)
                .Include(s => s.Semester)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        public IActionResult Create()
        {
            var model = new StudentViewModel()
            {
                ClassDrop = _context.Classes.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name } ),
                GenderDrop = _context.Gender.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name } ),
                SemesterDrop = _context.Semester.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name })

            };
            return View(model);
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StudentViewModel  model)
        {
            if (ModelState.IsValid)
            {
                model.Student.CreatedAt = DateTime.Now;
                model.Student.CreatedBy = UserEmail;
                model.Student.IsDelete = false;
                _context.Add(model.Student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(GetAll));
            } 
            return View(model);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var model = new StudentViewModel()
            {
                ClassDrop = _context.Classes.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name }),
                GenderDrop = _context.Gender.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name }),
                SemesterDrop = _context.Semester.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name }),
                Student = await _context.Student.FindAsync(id)
            };
            
            
            if (model.Student == null)
            {
                return NotFound();
            }
             return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, StudentViewModel model)
        {
            if (id !=  model.Student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    model.Student.UpdatedAt = DateTime.Now;
                    model.Student.UpdatedBy = UserEmail;


                    _context.Update(model.Student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(model.Student.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(GetAll));
            }
            return View(model);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .Include(s => s.Class)
                .Include(s => s.Gender)
                .Include(s => s.Semester)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Manger/Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.Student.FindAsync(id);
            student.IsDelete = true;
            _context.Student.Update(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
            return _context.Student.Any(e => e.Id == id);
        }
    }
}
