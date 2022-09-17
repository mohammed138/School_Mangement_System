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
    public class SkillsSuggestionssController : Controller
    {
       
        private readonly ApplicationDbContext _context;
        public string StudentEmail;
        public int StudentUserId;
        private readonly IHttpContextAccessor _HttpContextAccessor;


        public SkillsSuggestionssController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _HttpContextAccessor = httpContextAccessor;
            StudentEmail = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;
            StudentUserId = _context.Student.Where(d => d.EmailAddress == StudentEmail).Select(d => d.Id).FirstOrDefault();

        }


        public IActionResult Index()
        {
            List<int> WSIDs = new List<int>();
            List<SkillsSuggestions> SkillsSuggestionsList = new List<SkillsSuggestions>();
            SkillsSuggestionsViewModel model = new SkillsSuggestionsViewModel();
            if (StudentUserId == null)
            {
                return NotFound();
            }
            WSIDs = _context.Student.Where(d => d.Id == StudentUserId).Select(h => h.Id).ToList();// get student Ids from class   
            foreach (var item in WSIDs)
            {
                SkillsSuggestionsList.Add(_context.SkillsSuggestions.Include(d => d.Student).Include(d => d.Subject).Include(d => d.Teacher).Where(d => d.StudentId == item).FirstOrDefault());
            }
            if (WSIDs.Count() > 0)
            {
                model.SkillsSuggestionsList = SkillsSuggestionsList;
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





        private bool SkillsSuggestionsExists(int id)
        {
            return _context.SkillsSuggestions.Any(e => e.Id == id);
        }
    }
}
