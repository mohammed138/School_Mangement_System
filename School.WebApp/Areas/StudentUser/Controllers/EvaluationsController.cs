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

    public class SkillssController : Controller
    {
        private readonly ApplicationDbContext _context;
        public string StudentEmail;
        public int StudentUserId;
        private readonly IHttpContextAccessor _HttpContextAccessor;

         
        public SkillssController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _HttpContextAccessor = httpContextAccessor;
            StudentEmail = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;
            StudentUserId = _context.Student.Where(d => d.EmailAddress == StudentEmail).Select(d => d.Id).FirstOrDefault();

        }

        

        public IActionResult Index()
        {
            List<int> SkillsIDs = new List<int>();
            List<Skills> SkillsList = new List<Skills>();
            SkillsViewModel model = new SkillsViewModel();
            if (StudentUserId == null)
            {
                return NotFound();
            }
            SkillsIDs = _context.Skills.Where(d => d.StudentId == StudentUserId).Select(h => h.Id).ToList();// get student Ids from class   
            foreach (var item in SkillsIDs)
            {
                SkillsList.Add(_context.Skills.Include(d => d.Student).Include(d => d.Duration).Include(d => d.SkillsType).Include(d => d.Subject).Include(d => d.Teacher).Where(d => d.Id == item).FirstOrDefault());
            }
            if (SkillsIDs.Count() > 0)
            {
                model.SkillsList = SkillsList;
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








        private bool SkillsExists(int id)
        {
            return _context.Skills.Any(e => e.Id == id);
        }
    }
}
