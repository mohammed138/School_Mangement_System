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

namespace School.WebApp.Areas.Manger.Controllers
{
    [Area("MangerRole")]
    public class SkillsBehaviorsController00 : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public string UserEmail;
 
        public SkillsBehaviorsController00(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _HttpContextAccessor = httpContextAccessor;
            UserEmail = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;
 
        }



        public async Task<IActionResult> GetStudentSkillsBehaviors(int? id)
        {
            var model = new SkillsBehaviorViewModel();
            if (id == null)
            {
                return NotFound();
            }
            model.Decisions = _context.Decisions.FirstOrDefault();
            model.SkillsBehaviorList = _context.SkillsBehavior
            .Include(w => w.Class)
            .Include(w => w.Student)
            .Include(w => w.Subject)
            .Include(w => w.Teacher)
            .Where(m => m.StudentId == id)
            .ToList();
            if (model.SkillsBehaviorList.Any() == true)
            {
                model.IsActive = true;
            }
            else
            {
                model.IsActive = false;
            }

            return View(model);
        }


      





        private bool SkillsBehaviorExists(int id)
        {
            return _context.SkillsBehavior.Any(e => e.Id == id);
        }
    }
}
