﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;
using StudentManager.Models;

namespace StudentManager.Controllers
{
    public class AccountsController : Controller
    {
        private readonly StudentManagerContext _context;

        public AccountsController(StudentManagerContext context)
        {
            _context = context;
        }
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
        // GET: Accounts
        public async Task<IActionResult> Index(string filter, int page = 1, string sortExpression = "Email")
        {
            if (checkSession() == false)
            {
               return Redirect("/Authentication/login?redirectUrl=" + WebUtility.UrlEncode(Request.GetDisplayUrl()));
            }
            var query = _context.Account.AsNoTracking().AsQueryable();
            if (!string.IsNullOrWhiteSpace(filter))
            {
                query = query.Where(p => p.Email.Contains(filter)
                || p.UserName.Contains(filter));

            }
            var model = await PagingList.CreateAsync(query, 3, page, sortExpression, "Email");
            model.RouteValue = new RouteValueDictionary {
        { "filter", filter}
    };
            return View(model);

        }

        // GET: Accounts/Details/5
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

            var account = await _context.Account
                .Include(p => p.Person)
                .Include(gs => gs.GradeStudents)
                .ThenInclude(ga => ga.Grade)

                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // GET: Accounts/Create
        public IActionResult Create()
        {
            if (checkSession() == false)
            {
                return Redirect("/Authentication/login?redirectUrl=" + WebUtility.UrlEncode(Request.GetDisplayUrl()));
            }
            return View();
        }

        // POST: Accounts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserName,Email,Password,Person")] Account account)
        {
            if (ModelState.IsValid)
            {
                account.GenerateSalt();
                account.EncrytPassword();
                _context.Person.Add(account.Person);
                _context.Add(account);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(account);
        }

        // GET: Accounts/Edit/5
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

            var account = await _context.Account
                .Include(p => p.Person)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }
            return View(account);
        }

        // POST: Accounts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserName,Email,Password,Person")] Account account)
        {
            if (id != account.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    _context.Person.Update(account.Person);
                    _context.Update(account);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.Id))
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
            return View(account);
        }

        // GET: Accounts/Delete/5
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

            var account = await _context.Account
                 .Include(p => p.Person)
                .Include(gs => gs.GradeStudents)
                .ThenInclude(ga => ga.Grade)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // POST: Accounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var account = await _context.Account.FindAsync(id);
            _context.Account.Remove(account);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> AddGrade(int? id, string url)
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
            ViewData["GradeId"] = new SelectList(_context.Grade, "Id", "GradeName");
            ViewData["AccountId"] = id;
            ViewData["url"] = url;
            if (grade == null)
            {
                return NotFound();
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddGrade([Bind("GradeId,AccountId,JoinAt")] GradeStudent gradeStudent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gradeStudent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountId"] = new SelectList(_context.Account, "Id", "Email", gradeStudent.AccountId);
            ViewData["GradeId"] = new SelectList(_context.Grade, "Id", "Id", gradeStudent.GradeId);
            return View(gradeStudent);
        }
        private bool AccountExists(int id)
        {
            return _context.Account.Any(e => e.Id == id);
        }
    }
}
