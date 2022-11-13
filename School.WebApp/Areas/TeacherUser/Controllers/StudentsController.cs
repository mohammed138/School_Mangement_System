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
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public string UserEmail;
        public int TeacherUserId;

        public StudentsController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _HttpContextAccessor = httpContextAccessor;
            UserEmail = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;
            TeacherUserId = _context.Teacher.Where(d => d.EmailAddress == UserEmail).Select(d => d.Id).FirstOrDefault();

        }



        public IActionResult Create()
        {
            var model = new StudentViewModel()
            {
                ClassDrop = _context.Classes.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name }),
                GenderDrop = _context.Gender.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name }),
                SemesterDrop = _context.Semester.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name })

            };
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StudentViewModel model)
        {
            if (ModelState.IsValid)
            { 
                var MarksStudentList = new List<Mark>(); 
                List<int> SubjectsIDS = _context.Subject.Where(d => d.ClassId == model.Student.ClassId).Select(d => d.Id).ToList();
                
                 

                model.Student.CreatedAt = DateTime.Now;
                model.Student.CreatedBy = UserEmail;
                model.Student.IsDelete = false;

                _context.Student.Add(model.Student);
                  _context.SaveChanges();



                foreach (var item in SubjectsIDS)
                {
                    MarksStudentList.Add(new Mark
                    {
                        StudentId = model.Student.Id,
                        SubjectId = item,
                        TeacherId = _context.Subject.Where(d => d.Id == item).Select(d => d.TeacherId).FirstOrDefault(),
                        ClassId = model.Student.ClassId,
                        QualitativeAssessmentGrades = 0,
                        ShortQuizzes = 0,
                        FinalTermValue = 0,
                        CreatedAt = DateTime.Now,
                        CreatedBy = "NOBody",
                    });
                }


                foreach (var item in MarksStudentList)
                {
                    _context.Mark.Add(new Mark
                    {
                        ClassId =  item.ClassId,
                        StudentId = item.StudentId,
                        TeacherId = item.TeacherId,
                        QualitativeAssessmentGrades = item.QualitativeAssessmentGrades  ,
                        ShortQuizzes= item.ShortQuizzes,
                        FinalTermValue = item.FinalTermValue,
                        SubjectId = item.SubjectId,
                        CreatedAt = DateTime.Now,
                        CreatedBy = UserEmail
                    });
                        
                }

                  _context.SaveChanges();
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
            if (id != model.Student.Id)
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

            var mark = await _context.Student 
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
            var mark = await _context.Student.FindAsync(id);
            mark.IsDelete = true;
            _context.Student.Update(mark);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
            return _context.Student.Any(e => e.Id == id);
        }
    }
}
