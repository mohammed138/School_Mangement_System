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
            StudentUserId = _context.Student.Where(d => d.EmailAddress == StudentEmail).Select(d => d.Id).FirstOrDefault();

        }
         

         
        public IActionResult GetStudentInformation()
        {


            // 1- بدنا نعرض بيانات الطالب من جدول الطلاب 
            // 2- بدنا نعرض اسم الصف الخاص بالطالب من جدول الصفوف 
            //3- بدنا نعرض المواد الخاصة بالطالب من جدول المواد

            var model = new StudentViewModel();
           
            //1 Done
            model.Student = _context.Student.Include(d => d.Class).Include(d => d.Semester).Where(d => d.Id == StudentUserId).FirstOrDefault();
 
                
                
            if (model.Student != null)
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
