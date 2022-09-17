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

namespace School.Web.Areas.Manger.Controllers
{
    [Area("Manger")]
    public class SubjectsController : Controller
    {
         
        private readonly ApplicationDbContext _context;
        public string UserEmail;
        private readonly IHttpContextAccessor _HttpContextAccessor;
         public SubjectsController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            UserEmail = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;
 
        }

        // GET: Manger/Subjects
        public async Task<IActionResult> GetAll()
        {
            var model = new SubjectViewModel();
            model.SubjectList = _context.Subject.Include(s => s.Class).Include(s => s.Teacher).ToList();
            return View(model);
        }

         public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subject = await _context.Subject
                .Include(s => s.Class)
                .Include(s => s.Teacher)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subject == null)
            {
                return NotFound();
            }

            return View(subject);
        }

         public IActionResult Create()
         {
            SubjectViewModel model = new SubjectViewModel()
            {
                ClassDrop = _context.Classes.Select(x => new SelectListItem
                {
                    Value = x.Id.ToString(),
                    Text = x.Name
                }),
                TeacherDrop = _context.Teacher.Select(x => new SelectListItem
                {
                    Value = x.Id.ToString(),
                    Text = x.FullName
                }),

            };
  
            return View(model);
        }
 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SubjectViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.Subject.CreatedAt = DateTime.Now;
                model.Subject.CreatedBy = UserEmail;
                model.Subject.IsDelete = false;


                _context.Add(model.Subject);
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
            var model = new SubjectViewModel();
            model.Subject = await _context.Subject.FindAsync(id);

            model.ClassDrop = _context.Classes.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            });
            model.TeacherDrop = _context.Teacher.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.FullName
            });

            if (model.Subject == null)
            {
                return NotFound();
            }
            return View(model);
 
        }

           [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, SubjectViewModel model)
        {
            if (id != model.Subject.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    model.Subject.UpdatedAt = DateTime.Now;
                    model.Subject.UpdatedBy = UserEmail; 

                    _context.Update(model.Subject);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubjectExists(model.Subject.Id))
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

            var subject = await _context.Subject
                .Include(s => s.Class)
                .Include(s => s.Teacher)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subject == null)
            {
                return NotFound();
            }

            return View(subject);
        }

         [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subject = await _context.Subject.FindAsync(id);
            subject.IsDelete = true;
            _context.Subject.Update(subject);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubjectExists(int id)
        {
            return _context.Subject.Any(e => e.Id == id);
        }
    }
}
