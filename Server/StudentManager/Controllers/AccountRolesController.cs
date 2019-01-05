using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentManager.Models;

namespace StudentManager.Controllers
{
    public class AccountRolesController : Controller
    {
        private readonly StudentManagerContext _context;

        public AccountRolesController(StudentManagerContext context)
        {
            _context = context;
        }

        // GET: AccountRoles
        public async Task<IActionResult> Index()
        {
            var studentManagerContext = _context.AccountRole.Include(a => a.Account).Include(a => a.Role);
            return View(await studentManagerContext.ToListAsync());
        }

        // GET: AccountRoles/Details/5
        public async Task<IActionResult> Details(float? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountRole = await _context.AccountRole
                .Include(a => a.Account)
                .Include(a => a.Role)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (accountRole == null)
            {
                return NotFound();
            }

            return View(accountRole);
        }

        // GET: AccountRoles/Create
        public IActionResult Create()
        {
            ViewData["AccountId"] = new SelectList(_context.Account, "Id", "Email");
            ViewData["RoleId"] = new SelectList(_context.Role, "Id", "Id");
            return View();
        }

        // POST: AccountRoles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoleId,AccountId")] AccountRole accountRole)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accountRole);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountId"] = new SelectList(_context.Account, "Id", "Email", accountRole.AccountId);
            ViewData["RoleId"] = new SelectList(_context.Role, "Id", "Id", accountRole.RoleId);
            return View(accountRole);
        }

        // GET: AccountRoles/Edit/5
        public async Task<IActionResult> Edit(float? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountRole = await _context.AccountRole.FindAsync(id);
            if (accountRole == null)
            {
                return NotFound();
            }
            ViewData["AccountId"] = new SelectList(_context.Account, "Id", "Email", accountRole.AccountId);
            ViewData["RoleId"] = new SelectList(_context.Role, "Id", "Id", accountRole.RoleId);
            return View(accountRole);
        }

        // POST: AccountRoles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(float id, [Bind("Id,RoleId,AccountId")] AccountRole accountRole)
        {
            if (id != accountRole.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accountRole);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountRoleExists(accountRole.Id))
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
            ViewData["AccountId"] = new SelectList(_context.Account, "Id", "Email", accountRole.AccountId);
            ViewData["RoleId"] = new SelectList(_context.Role, "Id", "Id", accountRole.RoleId);
            return View(accountRole);
        }

        // GET: AccountRoles/Delete/5
        public async Task<IActionResult> Delete(float? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountRole = await _context.AccountRole
                .Include(a => a.Account)
                .Include(a => a.Role)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (accountRole == null)
            {
                return NotFound();
            }

            return View(accountRole);
        }

        // POST: AccountRoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(float id)
        {
            var accountRole = await _context.AccountRole.FindAsync(id);
            _context.AccountRole.Remove(accountRole);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountRoleExists(float id)
        {
            return _context.AccountRole.Any(e => e.Id == id);
        }
    }
}
