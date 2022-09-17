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
using School.DataAccess;
using Microsoft.AspNetCore.Authorization;

namespace School.WebApp.Areas.Manger.Controllers
{
    [Area("Manger")]
    [Authorize(Roles = "MangerRole")]
    public class DecisionsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public string UserEmail;

        public DecisionsController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _HttpContextAccessor = httpContextAccessor;
            UserEmail = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;

        }

        public async Task<IActionResult> Details()
        { 
            var decisions = await _context.Decisions
                .FirstOrDefaultAsync(m => m.Id == 3);
            if (decisions == null)
            {
                return NotFound();
            }

            return View(decisions);
        }
         



        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var decisions = await _context.Decisions.FindAsync(id);
            if (decisions == null)
            {
                return NotFound();
            }
            return View(decisions);
        } 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Decisions decisions)
        {
            if (id != decisions.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    decisions.UpdatedAt = DateTime.Now;
                    decisions.UpdatedBy = UserEmail ;



                    _context.Update(decisions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DecisionsExists(decisions.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(decisions);
        }

    
 

        private bool DecisionsExists(int id)
        {
            return _context.Decisions.Any(e => e.Id == id);
        }
    }
}
