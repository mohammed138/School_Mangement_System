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
    [Area("StudentUser")]
    [Authorize(Roles = "StudentRole")]
    public class ClassesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public string StudentEmail;
        public int StudentUserId;
        private readonly IHttpContextAccessor _HttpContextAccessor;



        public ClassesController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _HttpContextAccessor = httpContextAccessor;
            StudentEmail = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;
            StudentUserId = _context.Teacher.Where(d => d.EmailAddress == StudentEmail).Select(d => d.Id).FirstOrDefault();

        }




        public IActionResult CPanel()
        { 
            return View();
        }






        //public IActionResult GetStudentData()
        //{

        //    if (StudentUserId == null)
        //    {
        //        return NotFound();
        //    }

        //    StudentDataViewModel model = new StudentDataViewModel(); 
        //    List<int> SkillsIDs = new List<int>();
        //    List<int> SkillsBehaviorIDs = new List<int>();
        //    List<int> MarkIDs = new List<int>();
        //    List<int> WKIDs = new List<int>();




        //    List<Mark> MarkList = new List<Mark>(); 
        //    List<Skills> SkillsList = new List<Skills>();
        //    List<SkillsBehavior> SkillsBehaviorList = new List<SkillsBehavior>();
        //    List<SkillsSuggestions> SkillsSuggestionsList = new List<SkillsSuggestions>();



        //    SkillsIDs = _context.Student.Where(d => d.Id == StudentUserId).Select(h => h.Id).ToList();   
        //    SkillsBehaviorIDs = _context.SkillsBehavior.Where(d => d.StudentId == StudentUserId).Select(h => h.Id).ToList(); 
        //    MarkIDs = _context.Mark.Where(d => d.StudentId == StudentUserId).Select(h => h.Id).ToList();
        //    WKIDs = _context.SkillsSuggestions.Where(d => d.StudentId == StudentUserId).Select(h => h.Id).ToList();



        //    foreach (var item in SkillsIDs)
        //    {
        //       SkillsList.Add(_context.Skills.Include(d => d.Student).Include(d => d.Subject).Include(d => d.Teacher).Where(d => d.StudentId == item).FirstOrDefault());
        //    }
        //    foreach (var item in SkillsBehaviorIDs)
        //    {
        //        SkillsBehaviorList.Add(_context.SkillsBehavior.Include(d => d.Student).Include(f => f.Duration).Include(g => g.SkillsType).Include(d => d.Subject).Include(d => d.Teacher).Where(d => d.Id == item).FirstOrDefault());
        //    }
        //    foreach (var item in MarkIDs)
        //    {
        //        MarkList.Add(_context.Mark.Include(d => d.Student).Include(d => d.Subject).Include(d => d.Teacher).Where(d => d.Id == item).FirstOrDefault());
        //    }
        //    foreach (var item in WKIDs)
        //    {
        //        SkillsSuggestionsList.Add(_context.SkillsSuggestions.Include(d => d.Student).Include(d => d.Subject).Include(d => d.Teacher).Where(d => d.Id == item).FirstOrDefault());
        //    }


        //    model.SkillsViewModel.SkillsList = SkillsList;
        //    model.SkillsSuggestionsViewModel.SkillsSuggestionsList = SkillsSuggestionsList;
        //    model.SkillsBehaviorViewModel.SkillsBehaviorList = SkillsBehaviorList;
        //    model.MarkViewModel.MarkList = MarkList;



        //    if (SkillsIDs.Count() > 0 )
        //    {
        //        model.SkillsActive = true;
        //    }
        //    else
        //    {
        //        model.SkillsActive = true;
        //    }



        //    if (WKIDs.Count() > 0)
        //    {
        //        model.WKIsActive = true;
        //    }
        //    else
        //    {
        //        model.WKIsActive = false;
        //    }


        //    if (SkillsBehaviorIDs.Count() > 0)
        //    {
        //        model.EVABIsActive = true;
        //    }
        //    else
        //    {
        //        model.EVABIsActive = false;
        //    }



        //    if (MarkIDs.Count() > 0)
        //    {
        //        model.MArkIsActive = true;
        //    }
        //    else
        //    {
        //        model.MArkIsActive = false;
        //    }




        //    if (model == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(model);
        //}


        public IActionResult GetStudentInformation()
        {


            // 1- بدنا نعرض بيانات الطالب من جدول الطلاب 
            // 2- بدنا نعرض اسم الصف الخاص بالطالب من جدول الصفوف 
            //3- بدنا نعرض المواد الخاصة بالطالب من جدول المواد

            ClassViewModel model = new ClassViewModel();
            int ClassId;
            //1 Done
            model.Student = _context.Student.Where(d => d.Id == StudentUserId).FirstOrDefault();

            //2 Done
             ClassId = _context.Student.Where(d => d.Id == StudentUserId).Select(h => h.ClassId).FirstOrDefault();
            model.Class = _context.Classes.Where(d => d.Id == ClassId).Where(d => d.IsDelete != true).Where(d => d.IsArchive != true).FirstOrDefault();

            //3 done

            model.Subject = _context.Subject.Where(d => d.ClassId == ClassId).FirstOrDefault();
 
                
                
            if (ClassId > 0)
            {
                model.IsActive = true;
            }
            else
            {
                model.IsActive = false;
            }
            return View(model);
        }



        public IActionResult Index()
        {
            ClassViewModel model = new ClassViewModel();

            int ClassId = _context.Student.Where(d => d.Id == StudentUserId).Select(h => h.ClassId).FirstOrDefault();
            model.Class = _context.Classes.Where(d => d.Id == ClassId).Where(d => d.IsDelete != true).Where(d => d.IsArchive != true).FirstOrDefault();
            model.StudentId = _context.Student.Where(d => d.EmailAddress == StudentEmail).Select(d => d.Id).FirstOrDefault();

            if (ClassId > 0)
            {
                model.IsActive = true;
            }
            else
            {
                model.IsActive = false;
            }
            return View(model);
        }

 
        private bool ClassExists(int id)
        {
            return _context.Classes.Any(e => e.Id == id);
        }
    }
}
