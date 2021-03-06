﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentManager.Models;

namespace StudentManager.Controllers
{
    public class GradesController : Controller
    {
        private readonly StudentManagerContext _context;
        public bool checkSession()
        {
            var ck = false;
            string currentLogin = HttpContext.Session.GetString("currentLogin");

            if (currentLogin != null)
            {
                ck = true;
            }

            return (ck);
        }
        public GradesController(StudentManagerContext context)
        {
            _context = context;
        }

        // GET: Grades
        public async Task<IActionResult> Index()
        {
            if (checkSession() == false)
            {
                return Redirect("/Authentication/login?redirectUrl=" + WebUtility.UrlEncode(Request.GetDisplayUrl()));
            }
            return View(await _context.Grade
                .Include(sg => sg.SubjectGrades)
                .ThenInclude(sg => sg.Subject)

                .Include(gp => gp.GradeStudents)
                    .ThenInclude(gs => gs.Account)
                    .ThenInclude(ap => ap.Person)
                .ToListAsync());
        }

        // GET: Grades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (checkSession() == false)
            {
                return Redirect("/Authentication/login?redirectUrl=" + WebUtility.UrlEncode(Request.GetDisplayUrl()));
            }
            if (id == null)
            {
                return NotFound();
            }

            var grade = await _context.Grade
                .Include(sg=>sg.SubjectGrades)
                .ThenInclude(sg => sg.Subject)
                
                .Include(gp => gp.GradeStudents)
                    .ThenInclude(gs => gs.Account)
                    .ThenInclude(ap=>ap.Person)

                .FirstOrDefaultAsync(m => m.Id == id);
            if (grade == null)
            {
                return NotFound();
            }

            return View(grade);
        }

        // GET: Grades/Create
        public IActionResult Create()
        {
            if (checkSession() == false)
            {
                return Redirect("/Authentication/login?redirectUrl=" + WebUtility.UrlEncode(Request.GetDisplayUrl()));
            }
            return View();
        }

        // POST: Grades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,GradeName,StartDate,Status")] Grade grade)
        {
            if (ModelState.IsValid)
            {
                _context.Add(grade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(grade);
        }

        // GET: Grades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (checkSession() == false)
            {
                return Redirect("/Authentication/login?redirectUrl=" + WebUtility.UrlEncode(Request.GetDisplayUrl()));
            }
            if (id == null)
            {
                return NotFound();
            }

            var grade = await _context.Grade.FindAsync(id);
            if (grade == null)
            {
                return NotFound();
            }
            return View(grade);
        }

        // POST: Grades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,GradeName,StartDate,Status")] Grade grade)
        {
            if (id != grade.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(grade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GradeExists(grade.Id))
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
            return View(grade);
        }

        // GET: Grades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (checkSession() == false)
            {
                return Redirect("/Authentication/login?redirectUrl=" + WebUtility.UrlEncode(Request.GetDisplayUrl()));
            }
            if (id == null)
            {
                return NotFound();
            }

            var grade = await _context.Grade
                .FirstOrDefaultAsync(m => m.Id == id);
            if (grade == null)
            {
                return NotFound();
            }

            return View(grade);
        }

        // POST: Grades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var grade = await _context.Grade.FindAsync(id);
            _context.Grade.Remove(grade);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> AddSubject(int? id)
        {
            if (checkSession() == false)
            {
                return Redirect("/Authentication/login?redirectUrl=" + WebUtility.UrlEncode(Request.GetDisplayUrl()));
            }
            if (id == null)
            {
                return NotFound();
            }

            var grade = await _context.Grade.FindAsync(id);
            ViewData["SubjectId"] = new SelectList(_context.Subject, "Id", "Name");
            ViewData["GradeId"] = id;
            if (grade == null)
            {
                return NotFound();
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddSubject([Bind("SubjectId,GradeId")] SubjectGrade subjectGrade)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subjectGrade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GradeId"] = new SelectList(_context.Grade, "Id", "Id", subjectGrade.GradeId);
            ViewData["SubjectId"] = new SelectList(_context.Subject, "Id", "Name", subjectGrade.SubjectId);
            return View(subjectGrade);
        }

        private bool GradeExists(int id)
        {
            return _context.Grade.Any(e => e.Id == id);
        }
    }
}
