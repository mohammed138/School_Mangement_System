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

namespace School.WebApp.Areas.TeacherUsers.Controllers
{
    //[Authorize(Roles="Teacher")]
    [Area("TeacherUser")]
    public class MarksController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public string UserEmail;
        public int TeacherUserId;
        public int StudId;

        public MarksController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _HttpContextAccessor = httpContextAccessor;
            UserEmail = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;
            TeacherUserId = _context.Teacher.Where(d => d.EmailAddress == UserEmail).Select(d => d.Id).FirstOrDefault(); 
        }



        public async Task<IActionResult> Index()
        {
            MarkViewModel model = new MarkViewModel();

            model.Decisions = _context.Decisions.FirstOrDefault();
            model.MarkList = _context.Mark.ToList();

            return View(model);

        }

        public async Task<IActionResult> GetStudentMarks(int? id)
        {
            MarkViewModel model = new MarkViewModel();
            if (id == null)
            {
                return NotFound();
            }
            model.Decisions = _context.Decisions.FirstOrDefault();
            model.Student = _context.Student.Find(id);
            model.MarkList = await _context.Mark
                .Include(m => m.Class)
                .Include(m => m.Student)
                .Include(m => m.Subject)
                .Include(m => m.Teacher)  
                .Where(d => d.StudentId == id).ToListAsync();

            model.ClassID = (int)id;


            if (model == null)
            {
                return NotFound();
            }
            //model.StudentId = (int)id;
            return View(model);
        }

 
        public IActionResult Create(int? Id)
        { MarkViewModel model = new MarkViewModel()
        {
            SubjectsDrop = _context.Subject.Where(d => d.TeacherId == TeacherUserId).Select(i => new SelectListItem { Text = i.Name, Value = i.Id.ToString() }),
            SkillsTypeDrop = _context.SkillsType.Select(i => new SelectListItem { Text = i.Name, Value = i.Id.ToString() }),
            StudentDrop = _context.Student.Where(d => d.ClassId == Id).Select(i => new SelectListItem { Text = i.FullName, Value = i.Id.ToString() }),
            
             ClassID = (int)Id
            };
             
            return View(model);
        } 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MarkViewModel MarkViewModel)
        {
            if (ModelState.IsValid)
            { 
                MarkViewModel.Mark.CreatedAt = DateTime.Now;
                MarkViewModel.Mark.CreatedBy = UserEmail;
                MarkViewModel.Mark.TeacherId = TeacherUserId;  
                MarkViewModel.Mark.ClassId   = _context.Student.Where(d => d.Id == MarkViewModel.Mark.StudentId).Select(d => d.ClassId).FirstOrDefault();
                 
                _context.Add(MarkViewModel.Mark);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index","Classes");
            } 
            return View(MarkViewModel);
        }

    
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MarkViewModel model = new MarkViewModel()
            {
                SubjectsDrop = _context.Subject.Where(d => d.TeacherId == TeacherUserId).Select(i => new SelectListItem { Text = i.Name, Value = i.Id.ToString() }),
                SkillsTypeDrop = _context.SkillsType.Select(i => new SelectListItem { Text = i.Name, Value = i.Id.ToString() }),
                StudentDrop = _context.Student.Select(i => new SelectListItem { Text = i.FullName, Value = i.Id.ToString() }),
                Mark = _context.Mark.Find(id)
            };
             
            if (model.Mark == null)
            {
                return NotFound();
            }

            return View(model);
        } 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, MarkViewModel model)
        {
            if (id != model.Mark.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    model.Mark.UpdatedAt = DateTime.Now;
                    model.Mark.UpdatedBy = UserEmail;

                    _context.Update(model.Mark);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MarkExists(model.Mark.Id))
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
            mark.IsDelete = true;
            _context.Mark.Update(mark);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MarkExists(int id)
        {
            return _context.Mark.Any(e => e.Id == id);
        }
    }
}

////GET - UPSERT
//public IActionResult Upsert(int? id)
//{

//    MarkViewModel MarkViewModel = new MarkViewModel();
//    //{
//    //    Product = new Product(),
//    //    CategorySelectList = _context.Category.Select(i => new SelectListItem
//    //    {
//    //        Text = i.Name,
//    //        Value = i.Id.ToString()
//    //    }),

//    //};

//    if (id == null)
//    {
//        //this is for create
//        return View(MarkViewModel);
//    }
//    else
//    {
//        MarkViewModel.Mark = _context.Mark.Find(id);
//        if (MarkViewModel.Mark == null)
//        {
//            return NotFound();
//        }
//        return View(MarkViewModel);
//    }
//}


////POST - UPSERT
//[HttpPost]
//[ValidateAntiForgeryToken]
//public IActionResult Upsert(MarkViewModel MarkViewModel)
//{
//    if (ModelState.IsValid)
//    { 
//        if (MarkViewModel.Mark.Id == 0)
//        {
//            //Creating 

//            _context.Mark.Add(MarkViewModel.Mark);
//        }
//        else
//        {
//            //updating

//            _context.Mark.Update(MarkViewModel.Mark);
//        }


//        _context.SaveChanges();
//        return RedirectToAction("Index");
//    }

//    return View(MarkViewModel);

//}