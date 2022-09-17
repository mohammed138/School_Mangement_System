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

namespace School.WebApplication.Areas.StudentUser.Controllers
{
    [Authorize/*(Roles="Student")*/]
    [Area("StudentUser")]
    public class MarksController : Controller
    {
        private readonly ApplicationDbContext _context;
        public string StudentEmail;
        public int StudentUserId;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public MarksController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _HttpContextAccessor = httpContextAccessor;
            StudentEmail = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;
            StudentUserId = _context.Student.Where(d => d.EmailAddress == StudentEmail).Select(d => d.Id).FirstOrDefault();

        }



        public IActionResult Index()
        {
            List<int> MarkIDs = new List<int>();
            List<Mark> MarkList = new List<Mark>();

           

            MarkViewModel model = new MarkViewModel();
            MarkIDs = _context.Mark.Where(d => d.StudentId == StudentUserId).Select(h => h.Id).ToList();

            foreach (var item in MarkIDs)
            {
                MarkList.Add(_context.Mark.Include(d => d.Student).Include(d => d.FSkillsType).Include(d => d.Subject).Include(d => d.Teacher).Where(d => d.Id == item).FirstOrDefault());
            }
            if (MarkIDs.Count() > 0)
            {
                model.MarkList = MarkList;
                model.IsActive = true;
            }
            else
            {
                model.IsActive = false;
            }


            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }



        public async Task<IActionResult> GetStudentMarks(int? id)
        {
            MarkViewModel model = new MarkViewModel();
            if (id == null)
            {
                return NotFound();
            }

            model.Mark = _context.Mark
                .Include(m => m.Class)
                .Include(m => m.Student)
                .Include(m => m.Subject)
                .Include(m => m.Teacher)
                .FirstOrDefault(m => m.StudentId == id);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }




        public async Task<IActionResult> Details(int? id)
         {
            if (id == null)
            {
                return NotFound();
            }

            var mark = await _context.Mark
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


        public IActionResult Create()
        {
            ViewData["ClassId"] = new SelectList(_context.Classes, "Id", "Name");
            ViewData["SkillsTypeId"] = new SelectList(_context.SkillsType, "Id", "Id");
            ViewData["StudentId"] = new SelectList(_context.Student, "Id", "AddressName");
            ViewData["SubjectId"] = new SelectList(_context.Subject, "Id", "Name");
            ViewData["TeacherId"] = new SelectList(_context.Teacher, "Id", "FirstName");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MarkValue,Notice,SkillsTypeId,StudentId,SubjectId,ClassId,TeacherId,CreatedBy,UpdatedBy,CreatedAt,UpdatedAt,IsActive,IsDelete,IsArchive")] Mark mark)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mark);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClassId"] = new SelectList(_context.Classes, "Id", "Name", mark.ClassId);
            ViewData["StudentId"] = new SelectList(_context.Student, "Id", "AddressName", mark.StudentId);
            ViewData["SubjectId"] = new SelectList(_context.Subject, "Id", "Name", mark.SubjectId);
            ViewData["TeacherId"] = new SelectList(_context.Teacher, "Id", "FirstName", mark.TeacherId);
            return View(mark);
        }

        // GET: TeacherUsers/Marks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mark = await _context.Mark.FindAsync(id);
            if (mark == null)
            {
                return NotFound();
            }
            ViewData["ClassId"] = new SelectList(_context.Classes, "Id", "Name", mark.ClassId);
            ViewData["StudentId"] = new SelectList(_context.Student, "Id", "AddressName", mark.StudentId);
            ViewData["SubjectId"] = new SelectList(_context.Subject, "Id", "Name", mark.SubjectId);
            ViewData["TeacherId"] = new SelectList(_context.Teacher, "Id", "FirstName", mark.TeacherId);
            return View(mark);
        }

        // POST: TeacherUsers/Marks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MarkValue,Notice,SkillsTypeId,StudentId,SubjectId,ClassId,TeacherId,CreatedBy,UpdatedBy,CreatedAt,UpdatedAt,IsActive,IsDelete,IsArchive")] Mark mark)
        {
            if (id != mark.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mark);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MarkExists(mark.Id))
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
            ViewData["ClassId"] = new SelectList(_context.Classes, "Id", "Name", mark.ClassId);
            ViewData["StudentId"] = new SelectList(_context.Student, "Id", "AddressName", mark.StudentId);
            ViewData["SubjectId"] = new SelectList(_context.Subject, "Id", "Name", mark.SubjectId);
            ViewData["TeacherId"] = new SelectList(_context.Teacher, "Id", "FirstName", mark.TeacherId);
            return View(mark);
        }

        // GET: TeacherUsers/Marks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mark = await _context.Mark
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

        // POST: TeacherUsers/Marks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mark = await _context.Mark.FindAsync(id);
            _context.Mark.Remove(mark);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MarkExists(int id)
        {
            return _context.Mark.Any(e => e.Id == id);
        }
    }
}
