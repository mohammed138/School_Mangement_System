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

namespace School.Web.Areas.StudentUser.Controllers
{
    [Authorize/*(Roles="Student")*/]
    [Area("StudentUser")]

    public class SkillsStudentBehaviorsController : Controller
    {

        private readonly ApplicationDbContext _context;
        public string StudentEmail;
        public int StudentUserId;
        private readonly IHttpContextAccessor _HttpContextAccessor;


        public SkillsStudentBehaviorsController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _HttpContextAccessor = httpContextAccessor;
            StudentEmail = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;
            StudentUserId = _context.Student.Where(d => d.EmailAddress == StudentEmail).Select(d => d.Id).FirstOrDefault();
        }



        [HttpGet]
        public IActionResult Index()
        {
            List<int> SkillsBehaviorIDs = new List<int>();
            List<SkillsStudentBehavior> SkillsBehaviorList = new List<SkillsStudentBehavior>();
          


            SkillsBehaviorViewModel model = new SkillsBehaviorViewModel();
            
            SkillsBehaviorIDs = _context.SkillsStudentBehavior.Where(d => d.StudentId == StudentUserId).Select(h => h.Id).ToList();// get student from class 10 

            foreach (var item in SkillsBehaviorIDs)
            {
               SkillsBehaviorList.Add(_context.SkillsStudentBehavior.Include(d => d.Student).Include(f=>f.Duration).Include(g=>g.SkillsType).Include(d => d.Subject).Include(d => d.Teacher).Where(d => d.Id == item).FirstOrDefault());
            }


            if (SkillsBehaviorIDs.Count() > 0)
            {
                model.SkillsBehaviorList = SkillsBehaviorList;
                model.IsActive = true;
                //model.SubjectName = _context.Teacher.Where(d => d.EmailAddress == UserEmail).Select(d => d.SubjectName).FirstOrDefault();
                //model.TeacherName = _context.Teacher.Where(d => d.EmailAddress == UserEmail).Select(d => d.FullName).FirstOrDefault();
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









        // GET: TeacherUsers/SkillsStudentBehaviors/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: TeacherUsers/SkillsStudentBehaviors/Create
        public IActionResult Create()
        {
            ViewData["ClassId"] = new SelectList(_context.Classes, "Id", "Name");
            ViewData["DurationId"] = new SelectList(_context.Duration, "Id", "Name");
            ViewData["SkillsTypeId"] = new SelectList(_context.SkillsType, "Id", "Id");
            ViewData["StudentId"] = new SelectList(_context.Student, "Id", "AddressName");
            ViewData["SubjectId"] = new SelectList(_context.Subject, "Id", "Name");
            ViewData["TeacherId"] = new SelectList(_context.Teacher, "Id", "FirstName");
            return View();
        }

        // POST: TeacherUsers/SkillsStudentBehaviors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClassId,SubjectId,StudentId,TeacherId,DurationId,SkillsTypeId,Notice,CreatedBy,UpdatedBy,CreatedAt,UpdatedAt,IsActive,IsDelete,IsArchive")] SkillsStudentBehavior SkillsStudentBehavior)
        {
            if (ModelState.IsValid)
            {
                _context.Add(SkillsStudentBehavior);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClassId"] = new SelectList(_context.Classes, "Id", "Name", SkillsStudentBehavior.ClassId);
            ViewData["DurationId"] = new SelectList(_context.Duration, "Id", "Name", SkillsStudentBehavior.DurationId);
            ViewData["SkillsTypeId"] = new SelectList(_context.SkillsType, "Id", "Id", SkillsStudentBehavior.SkillsTypeId);
            ViewData["StudentId"] = new SelectList(_context.Student, "Id", "AddressName", SkillsStudentBehavior.StudentId);
            ViewData["SubjectId"] = new SelectList(_context.Subject, "Id", "Name", SkillsStudentBehavior.SubjectId);
            ViewData["TeacherId"] = new SelectList(_context.Teacher, "Id", "FirstName", SkillsStudentBehavior.TeacherId);
            return View(SkillsStudentBehavior);
        }

        // GET: TeacherUsers/SkillsStudentBehaviors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var SkillsStudentBehavior = await _context.SkillsStudentBehavior.FindAsync(id);
            if (SkillsStudentBehavior == null)
            {
                return NotFound();
            }
            ViewData["ClassId"] = new SelectList(_context.Classes, "Id", "Name", SkillsStudentBehavior.ClassId);
            ViewData["DurationId"] = new SelectList(_context.Duration, "Id", "Name", SkillsStudentBehavior.DurationId);
            ViewData["SkillsTypeId"] = new SelectList(_context.SkillsType, "Id", "Id", SkillsStudentBehavior.SkillsTypeId);
            ViewData["StudentId"] = new SelectList(_context.Student, "Id", "AddressName", SkillsStudentBehavior.StudentId);
            ViewData["SubjectId"] = new SelectList(_context.Subject, "Id", "Name", SkillsStudentBehavior.SubjectId);
            ViewData["TeacherId"] = new SelectList(_context.Teacher, "Id", "FirstName", SkillsStudentBehavior.TeacherId);
            return View(SkillsStudentBehavior);
        }

        // POST: TeacherUsers/SkillsStudentBehaviors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClassId,SubjectId,StudentId,TeacherId,DurationId,SkillsTypeId,Notice,CreatedBy,UpdatedBy,CreatedAt,UpdatedAt,IsActive,IsDelete,IsArchive")] SkillsStudentBehavior SkillsStudentBehavior)
        {
            if (id != SkillsStudentBehavior.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(SkillsStudentBehavior);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SkillsStudentBehaviorExists(SkillsStudentBehavior.Id))
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
            ViewData["ClassId"] = new SelectList(_context.Classes, "Id", "Name", SkillsStudentBehavior.ClassId);
            ViewData["DurationId"] = new SelectList(_context.Duration, "Id", "Name", SkillsStudentBehavior.DurationId);
            ViewData["SkillsTypeId"] = new SelectList(_context.SkillsType, "Id", "Id", SkillsStudentBehavior.SkillsTypeId);
            ViewData["StudentId"] = new SelectList(_context.Student, "Id", "AddressName", SkillsStudentBehavior.StudentId);
            ViewData["SubjectId"] = new SelectList(_context.Subject, "Id", "Name", SkillsStudentBehavior.SubjectId);
            ViewData["TeacherId"] = new SelectList(_context.Teacher, "Id", "FirstName", SkillsStudentBehavior.TeacherId);
            return View(SkillsStudentBehavior);
        }

        // GET: TeacherUsers/SkillsStudentBehaviors/Delete/5
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

        // POST: TeacherUsers/SkillsStudentBehaviors/Delete/5
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
