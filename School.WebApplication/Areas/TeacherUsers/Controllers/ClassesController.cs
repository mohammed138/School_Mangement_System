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

namespace School.WebApplication.Areas.TeacherUser.Controllers
{
    //[Authorize(Roles= "Teacher")]
    [Area("TeacherUsers")]
    public class ClassesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public string UserEmail;
        public int TeacherUserId;

        public ClassesController(ApplicationDbContext context , IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _HttpContextAccessor = httpContextAccessor;
             UserEmail = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;
            TeacherUserId = _context.Teacher.Where(d => d.EmailAddress == UserEmail).Select(d => d.Id).FirstOrDefault(); 
       
        }


        public IActionResult specificClass(int? id) { 

            ClassViewModel model = new ClassViewModel()
            {
                Class = _context.Classes.Where(d=>d.Id == id).FirstOrDefault()
            }; 
               return View(model);
            }

        public IActionResult Index()
        {
            List<int> ClassesIDs = new List<int>();
            List<Class> ClassList = new List<Class>();
            ClassViewModel model = new ClassViewModel();
            ClassesIDs = _context.Subject.Where(d => d.TeacherId == TeacherUserId).Select(h => h.ClassId).ToList();
            foreach (var item in ClassesIDs)
            {
                ClassList.Add(_context.Classes.Where(d => d.Id == item).Where(d => d.IsDelete != true).Where(d => d.IsArchive != true).FirstOrDefault());
            }
            if (ClassesIDs.Count() > 0)
            {
                model.ClassList = ClassList;
                model.classCap = ClassList.Count();
                model.IsActive = true;
            }
            else
            {
                model.IsActive = false;
            }
            return View(model);
        }
        public IActionResult FindStudent(int? id)
        {
            List<int> StudentIDs = new List<int>();
            List<Student> StudentList = new List<Student>();


            if (id == null)
            {
                return NotFound();
            }

            ClassViewModel model = new ClassViewModel()
            {
                Class = _context.Classes.Where(d => d.Id == id).FirstOrDefault() 
            };
            StudentIDs = _context.Student.Where(d => d.ClassId == id).Select(h => h.Id).ToList();

            foreach (var item in StudentIDs)
            {
                StudentList.Add(_context.Student.Where(d => d.Id == item).FirstOrDefault());
            }
         

            if (StudentIDs.Count() > 0) 
            {  
               model.IsActive = true;
                model.StudentList = StudentList;
                model.Capacity = model.StudentList.Count();
            } 
            else
            {
                model.IsActive = false;
            }

             

            if (model.Class == null)
            {
                return NotFound();
            }

            return View(model);
        } 
        public IActionResult FindMark(int? id)
        { 
            List<int> MarkIDs = new List<int>();
            List<Mark> MarkList = new List<Mark>();

            if (id == null)
            {
                return NotFound();
            }

            MarkViewModel model = new MarkViewModel()
            { 
                SkillsTypeDrop = _context.SkillsType.Select(i => new SelectListItem { Text = i.Name, Value = i.Id.ToString() })   
            };
            MarkIDs = _context.Mark.Where(d => d.ClassId == id).Select(h => h.Id).ToList();

            foreach (var item in MarkIDs)
            {
                MarkList.Add(_context.Mark.Include(d => d.Student).Include(d => d.FSkillsType).Include(d => d.Subject).Include(d => d.Teacher).Where(d => d.Id == item).FirstOrDefault());

            }
            if (MarkIDs.Count() > 0)
            {
                model.MarkList = MarkList;
                model.IsActive = true;
                model.ClassID = (int)id;
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
        public IActionResult FindSkillsBehaviors(int? id)
        {
            List<int> SkillsBehaviorIDs = new List<int>();
            List<SkillsStudentBehavior> SkillsBehaviorList = new List<SkillsStudentBehavior>();
            if (id == null)
            {
                return NotFound();
            }

            SkillsBehaviorViewModel model = new SkillsBehaviorViewModel()
            {
                //SkillsTypeDrop = _context.SkillsType.Select(i => new SelectListItem { Text = i.Name, Value = i.Id.ToString() })
                ClassID = (int)id
            };
           
           
            SkillsBehaviorIDs = _context.SkillsStudentBehavior.Where(d => d.ClassId == id).Select(h => h.Id).ToList();// get student from class 10 

            foreach (var item in SkillsBehaviorIDs)
            {
                SkillsBehaviorList.Add(_context.SkillsStudentBehavior.Include(d => d.Student).Include(d => d.Subject).Include(d => d.Teacher).Where(d => d.Id == item).FirstOrDefault());
            }


            if (SkillsBehaviorIDs.Count() > 0)
            {
                model.SkillsBehaviorList = SkillsBehaviorList;
                model.IsActive = true;
                //model.SubjectName = _context.Teacher.Where(d => d.EmailAddress == UserEmail).Select(d => d.SubjectName).FirstOrDefault();
                model.TeacherName = _context.Teacher.Where(d => d.EmailAddress == UserEmail).Select(d => d.FullName).FirstOrDefault();
            }
            else
            {
                model.IsActive = false;
                model.ClassID = (int)id;
            }


            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        } 
        public IActionResult FindSkills(int? id)
        {
            List<int> SkillsIDs = new List<int>();
            List<Skills> SkillsList = new List<Skills>();
            if (id == null)
            {
                return NotFound();
            } 
            SkillsViewModel model = new SkillsViewModel()
            { 
                ClassID = (int)id
            };
           
            SkillsIDs = _context.Skills.Where(d => d.ClassId == id).Select(h => h.Id).ToList();// get student Ids from class   
            foreach (var item in SkillsIDs)
            {
                SkillsList.Add(_context.Skills.Include(d => d.Duration).Include(d => d.Student).Include(d => d.SkillsType).Include(d => d.Subject).Include(d => d.Teacher).Where(d => d.Id == item).FirstOrDefault());
            } 
            if (SkillsIDs.Count() > 0)
            {
                model.SkillsList = SkillsList;
                model.IsActive = true;
                //model.SubjectName = _context.Teacher.Where(d => d.EmailAddress == UserEmail).Select(d => d.SubjectName).FirstOrDefault();
                model.TeacherName = _context.Teacher.Where(d => d.EmailAddress == UserEmail).Select(d => d.FullName).FirstOrDefault();
            } 
            else
            {
                model.IsActive = false;
                //model.ClassID = (int)id;
            } 
            if (model == null)
            {
                return NotFound();
            } 
            return View(model);
        }

        public IActionResult FindSkillsSuggestionss(int? id)
        {
            List<int> SkillsSuggestionsIDs = new List<int>();
            List<SkillsSuggestions> SkillsSuggestionsList = new List<SkillsSuggestions>();
            if (id == null)
            {
                return NotFound();
            }
            SkillsSuggestionsViewModel model = new SkillsSuggestionsViewModel()
            {
                ClassID = (int)id
            };

            SkillsSuggestionsIDs = _context.SkillsSuggestions.Where(d => d.ClassId == id).Select(h => h.Id).ToList();// get student Ids from class   
            foreach (var item in SkillsSuggestionsIDs)
            {
                SkillsSuggestionsList.Add(_context.SkillsSuggestions.Include(d => d.Teacher).Include(d => d.Class).Include(d => d.Student).Include(d => d.Subject).Where(d => d.Id == item).FirstOrDefault());
            }
            if (SkillsSuggestionsIDs.Count() > 0)
            {
                model.SkillsSuggestionsList = SkillsSuggestionsList;
                model.IsActive = true;
                //model.SubjectName = _context.Teacher.Where(d => d.EmailAddress == UserEmail).Select(d => d.SubjectName).FirstOrDefault();
                model.TeacherName = _context.Teacher.Where(d => d.EmailAddress == UserEmail).Select(d => d.FullName).FirstOrDefault();
            }
            else
            {
                model.IsActive = false;
                //model.ClassID = (int)id;
            }
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }
        private bool ClassExists(int id)
        {
            return _context.Classes.Any(e => e.Id == id);
        }
    }
}
