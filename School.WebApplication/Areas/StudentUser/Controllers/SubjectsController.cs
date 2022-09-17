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

namespace School.WebApplication.Areas.StudentUser.Controllers
{
    [Area("StudentUser")]
    public class SubjectsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public string StudentEmail;
        public int StudentUserId;
        private readonly IHttpContextAccessor _HttpContextAccessor;
       



        public SubjectsController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _HttpContextAccessor = httpContextAccessor;
            StudentEmail = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;
            StudentUserId = _context.Teacher.Where(d => d.EmailAddress == StudentEmail).Select(d => d.Id).FirstOrDefault();

        }
 
        public async Task<IActionResult> GetSubjects()
        {
            SubjectViewModel model = new SubjectViewModel(); 
            int classId = _context.Student.Where(d => d.Id == StudentUserId).Select(d => d.ClassId).FirstOrDefault();
            model.SubjectList = _context.Subject.Include(d=>d.Class).Include(s=>s.Teacher).Where(s => s.ClassId == classId).ToList();
            return View(model);
        }


        

        private bool SubjectExists(int id)
        {
            return _context.Subject.Any(e => e.Id == id);
        }
    }
}
