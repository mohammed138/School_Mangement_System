﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using School.Data.Entities;
using School.DataAccess;

namespace School.WebApplication.Areas.MangerUser.Controllers
{
    //[Area("Manger")]
    [Authorize/*(Roles = "Manger")*/]
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Manger/Students
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Student.Include(s => s.Class).Include(s => s.Gender).Include(s => s.Semester);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Manger/Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .Include(s => s.Class)
                .Include(s => s.Gender)
                .Include(s => s.Semester)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Manger/Students/Create
        public IActionResult Create()
        {
            ViewData["ClassId"] = new SelectList(_context.Classes, "Id", "Name");
            ViewData["GenderId"] = new SelectList(_context.Gender, "Id", "Name");
            ViewData["SemesterId"] = new SelectList(_context.Semester, "Id", "Name");
            return View();
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,PhoneNumber,EmailAddress,DOP,AddressName,SchoolYear,PlaceOBirth,GenderId,ClassId,SemesterId,CreatedBy,UpdatedBy,CreatedAt,UpdatedAt,IsActive,IsDelete,IsArchive")] Student student)
        {
            if (ModelState.IsValid)
            {
                student.CreatedAt = DateTime.Now;
                student.CreatedBy = "hjk";
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClassId"] = new SelectList(_context.Classes, "Id", "Name", student.Class.Name);
            ViewData["GenderId"] = new SelectList(_context.Gender, "Id", "Id", student.Gender.Name);
            ViewData["SemesterId"] = new SelectList(_context.Semester, "Id", "Name", student.Semester.Name);
            return View(student);
        }

        // GET: Manger/Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            ViewData["ClassId"] = new SelectList(_context.Classes, "Id", "Name", student.ClassId);
            ViewData["GenderId"] = new SelectList(_context.Gender, "Id", "Id", student.GenderId);
            ViewData["SemesterId"] = new SelectList(_context.Semester, "Id", "Name", student.SemesterId);
            return View(student);
        }

        // POST: Manger/Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,PhoneNumber,EmailAddress,DOP,AddressName,SchoolYear,PlaceOBirth,GenderId,ClassId,SemesterId,CreatedBy,UpdatedBy,CreatedAt,UpdatedAt,IsActive,IsDelete,IsArchive")] Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.Id))
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
            ViewData["ClassId"] = new SelectList(_context.Classes, "Id", "Name", student.ClassId);
            ViewData["GenderId"] = new SelectList(_context.Gender, "Id", "Id", student.GenderId);
            ViewData["SemesterId"] = new SelectList(_context.Semester, "Id", "Name", student.SemesterId);
            return View(student);
        }

        // GET: Manger/Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .Include(s => s.Class)
                .Include(s => s.Gender)
                .Include(s => s.Semester)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Manger/Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.Student.FindAsync(id);
            _context.Student.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
            return _context.Student.Any(e => e.Id == id);
        }
    }
}
