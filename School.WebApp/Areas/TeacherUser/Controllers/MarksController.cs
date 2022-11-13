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
        public List<Mark> MarksListTest { get; set; }

        public MarksController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _HttpContextAccessor = httpContextAccessor;
            UserEmail = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;
            TeacherUserId = _context.Teacher.Where(d => d.EmailAddress == UserEmail).Select(d => d.Id).FirstOrDefault(); 
        }



        
         
   



        public IActionResult EditTest()
        {
            ListOfStudentMarks model = new ListOfStudentMarks()
            {
                StudentMarks = _context.Mark.Include(d=>d.Class).Include(d => d.Teacher).Include(d => d.Subject).Include(d => d.Student)
                .Where(d => d.SubjectId == 811).Where(a => a.ClassId == 1010).ToList()
            };

            if (model.StudentMarks.Count < 0)
            {
                model.IsActive = false;
            }
            else
            {
                model.IsActive = true;
            }

            return View(model);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditTest(ListOfStudentMarks model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    foreach (var item in model.StudentMarks)
                    {

                        item.UpdatedAt = DateTime.Now;
                        item.UpdatedBy = UserEmail;
                    }

                    _context.UpdateRange(model.StudentMarks);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (model.StudentMarks.Count() < 0)
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










        

        public async Task<IActionResult> Search(MarkViewModel model)
        {

            if (model.Mark.ClassId != 0  && model.Mark.SubjectId != 0)
            {
                model.MarkList = _context.Mark.Where(s => s.ClassId== model.Mark.ClassId).Where(d=>d.SubjectId == model.Mark.SubjectId).Where(d=>d.TeacherId == TeacherUserId)
                   .Include(d=>d.Class).Include(d => d.Subject).Include(d => d.Teacher).Include(d => d.Student).ToList();
            }

            return View(model);
        }








        public async Task<IActionResult> Details(int? id)
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
        {
            MarkViewModel model = new MarkViewModel()
           {
               StudentList = _context.Student.Where(d => d.ClassId == Id).ToList(),
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




        public IActionResult CreateList() 
        {
            CRUDMarksViewModel model = new CRUDMarksViewModel();
            List<Student> StudentList = _context.Student.Where(d => d.ClassId == 1010).ToList();

      
            foreach (var item in StudentList)
            {
                MarksListTest.Add(new Mark { StudentId = item.Id, ClassId = 1010, TeacherId = TeacherUserId, SubjectId = 811 });
             }
            model.MarkList = MarksListTest;
           

 
             return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateList(CRUDMarksViewModel model  )
        {
            
            if (ModelState.IsValid)
            {

 

                    foreach (var i in model.MarkList)
                    {
                        if (i.StudentId != null && i.ShortQuizzes != null || i.QualitativeAssessmentGrades != null)
                        {
                            _context.Mark.Add(new Mark
                            {
                                StudentId = i.StudentId,
                                ClassId = i.ClassId,
                                SubjectId = i.SubjectId,
                                TeacherId = i.TeacherId,
                                CreatedAt = DateTime.Now,
                                CreatedBy = UserEmail,
                                ShortQuizzes = i.ShortQuizzes,
                                QualitativeAssessmentGrades = i.QualitativeAssessmentGrades,
                                FinalTermValue = i.FinalTermValue
                            });
                        }
                    }
               

                //foreach (var item in model.MarkValuesList)
                //{ 
                //        _context.Mark.Add(new Mark
                //        {
                //            StudentId = item.StudentId,
                //            ClassId = item.ClassId,
                //            SubjectId = item.SubjectId,
                //            TeacherId = item.TeacherId,
                //            CreatedAt = DateTime.Now,
                //            CreatedBy = UserEmail,
                //            ShortQuizzes = item.ShortQuizzes,
                //            QualitativeAssessmentGrades = item.QualitativeAssessmentGrades,
                //            FinalTermValue = item.FinalTermValue
                //        });

                //}


                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Classes");
            }
            return View();
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

        // POST: TeacherUser/Marks1/Delete/5
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

 