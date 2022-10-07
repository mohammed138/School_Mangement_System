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
    public class SkillsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public string StudentEmail;
        public int StudentUserId;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public SkillsController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _HttpContextAccessor = httpContextAccessor;
            StudentEmail = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;
            StudentUserId = _context.Student.Where(d => d.EmailAddress == StudentEmail).Select(d => d.Id).FirstOrDefault();

        }



        public async Task<IActionResult> Index()
        {
            var model = new SkillsViewModel();
             
            model.Decisions = _context.Decisions.FirstOrDefault();
            model.SkillsList = _context.Skills
            .Include(w => w.Class)
            .Include(w => w.Student)
            .Include(w => w.Subject)
            .Include(w => w.Teacher)
            .Include(d => d.CompletionType)
            .Where(m => m.StudentId == StudentUserId)
            .ToList();
            if (model.SkillsList.Any() == true)
            {
                model.IsActive = true;
            }
            else
            {
                model.IsActive = false;
            }

            return View(model);
        }



        private bool SkillsExists(int id)
        {
            return _context.Skills.Any(e => e.Id == id);
        }
    }
}
