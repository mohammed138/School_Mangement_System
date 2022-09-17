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

namespace School.WebApp.Areas.StudentUser.Controllers
{
    [Authorize/*(Roles="Student")*/]
    [Area("StudentUser")]
    [Authorize(Roles = "StudentRole")]


    public class SkillsBehaviorsController : Controller
    {

        private readonly ApplicationDbContext _context;
        public string StudentEmail;
        public int StudentUserId;
        private readonly IHttpContextAccessor _HttpContextAccessor;


        public SkillsBehaviorsController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
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
            List<SkillsBehavior> SkillsBehaviorList = new List<SkillsBehavior>();
          


            SkillsBehaviorViewModel model = new SkillsBehaviorViewModel();
            
            SkillsBehaviorIDs = _context.SkillsBehavior.Where(d => d.StudentId == StudentUserId).Select(h => h.Id).ToList();// get student from class 10 

            foreach (var item in SkillsBehaviorIDs)
            {
               SkillsBehaviorList.Add(_context.SkillsBehavior.Include(d => d.Student).Include(f=>f.Duration).Include(g=>g.SkillsType).Include(d => d.Subject).Include(d => d.Teacher).Where(d => d.Id == item).FirstOrDefault());
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

            model.SkillsBehavior = await _context.SkillsBehavior
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









        // GET: TeacherUsers/SkillsBehaviors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            } 
            var SkillsBehavior = await _context.SkillsBehavior
                .Include(e => e.Class)
                .Include(e => e.Duration)
                .Include(e => e.SkillsType)
                .Include(e => e.Student)
                .Include(e => e.Subject)
                .Include(e => e.Teacher)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (SkillsBehavior == null)
            {
                return NotFound();
            }

            return View(SkillsBehavior);
        }

        // GET: TeacherUsers/SkillsBehaviors/Create
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

        // POST: TeacherUsers/SkillsBehaviors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClassId,SubjectId,StudentId,TeacherId,DurationId,SkillsTypeId,Notice,CreatedBy,UpdatedBy,CreatedAt,UpdatedAt,IsActive,IsDelete,IsArchive")] SkillsBehavior SkillsBehavior)
        {
            if (ModelState.IsValid)
            {
                _context.Add(SkillsBehavior);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClassId"] = new SelectList(_context.Classes, "Id", "Name", SkillsBehavior.ClassId);
            ViewData["DurationId"] = new SelectList(_context.Duration, "Id", "Name", SkillsBehavior.DurationId);
            ViewData["SkillsTypeId"] = new SelectList(_context.SkillsType, "Id", "Id", SkillsBehavior.SkillsTypeId);
            ViewData["StudentId"] = new SelectList(_context.Student, "Id", "AddressName", SkillsBehavior.StudentId);
            ViewData["SubjectId"] = new SelectList(_context.Subject, "Id", "Name", SkillsBehavior.SubjectId);
            ViewData["TeacherId"] = new SelectList(_context.Teacher, "Id", "FirstName", SkillsBehavior.TeacherId);
            return View(SkillsBehavior);
        }

        // GET: TeacherUsers/SkillsBehaviors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var SkillsBehavior = await _context.SkillsBehavior.FindAsync(id);
            if (SkillsBehavior == null)
            {
                return NotFound();
            }
            ViewData["ClassId"] = new SelectList(_context.Classes, "Id", "Name", SkillsBehavior.ClassId);
            ViewData["DurationId"] = new SelectList(_context.Duration, "Id", "Name", SkillsBehavior.DurationId);
            ViewData["SkillsTypeId"] = new SelectList(_context.SkillsType, "Id", "Id", SkillsBehavior.SkillsTypeId);
            ViewData["StudentId"] = new SelectList(_context.Student, "Id", "AddressName", SkillsBehavior.StudentId);
            ViewData["SubjectId"] = new SelectList(_context.Subject, "Id", "Name", SkillsBehavior.SubjectId);
            ViewData["TeacherId"] = new SelectList(_context.Teacher, "Id", "FirstName", SkillsBehavior.TeacherId);
            return View(SkillsBehavior);
        }

        // POST: TeacherUsers/SkillsBehaviors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClassId,SubjectId,StudentId,TeacherId,DurationId,SkillsTypeId,Notice,CreatedBy,UpdatedBy,CreatedAt,UpdatedAt,IsActive,IsDelete,IsArchive")] SkillsBehavior SkillsBehavior)
        {
            if (id != SkillsBehavior.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(SkillsBehavior);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SkillsBehaviorExists(SkillsBehavior.Id))
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
            ViewData["ClassId"] = new SelectList(_context.Classes, "Id", "Name", SkillsBehavior.ClassId);
            ViewData["DurationId"] = new SelectList(_context.Duration, "Id", "Name", SkillsBehavior.DurationId);
            ViewData["SkillsTypeId"] = new SelectList(_context.SkillsType, "Id", "Id", SkillsBehavior.SkillsTypeId);
            ViewData["StudentId"] = new SelectList(_context.Student, "Id", "AddressName", SkillsBehavior.StudentId);
            ViewData["SubjectId"] = new SelectList(_context.Subject, "Id", "Name", SkillsBehavior.SubjectId);
            ViewData["TeacherId"] = new SelectList(_context.Teacher, "Id", "FirstName", SkillsBehavior.TeacherId);
            return View(SkillsBehavior);
        }

        // GET: TeacherUsers/SkillsBehaviors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var SkillsBehavior = await _context.SkillsBehavior
                .Include(e => e.Class)
                .Include(e => e.Duration)
                .Include(e => e.SkillsType)
                .Include(e => e.Student)
                .Include(e => e.Subject)
                .Include(e => e.Teacher)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (SkillsBehavior == null)
            {
                return NotFound();
            }

            return View(SkillsBehavior);
        }

        // POST: TeacherUsers/SkillsBehaviors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var SkillsBehavior = await _context.SkillsBehavior.FindAsync(id);
            _context.SkillsBehavior.Remove(SkillsBehavior);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SkillsBehaviorExists(int id)
        {
            return _context.SkillsBehavior.Any(e => e.Id == id);
        }
    }
}
