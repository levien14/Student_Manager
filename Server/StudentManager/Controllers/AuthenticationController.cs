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
    public class AuthenticationController : Controller
    {
        private readonly StudentManagerContext _context;

        public AuthenticationController(StudentManagerContext context)
        {
            _context = context;
        }



        // GET: Authentication/Create
        public IActionResult login()
        {
            return View();
        }

        // POST: Authentication/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> login2([Bind("Email,Password")] loginInfor loginInfor)
        {
            var existlogin = _context.Account.SingleOrDefault(ac => ac.Email == loginInfor.Email);
            if (existlogin == null)
            {
                return new JsonResult("Khong co Email");
            }
            if (existlogin.Password == loginInfor.Password)
            {
                var checkroll = _context.AccountRole.SingleOrDefault(ar => ar.AccountId == existlogin.Id);
                if (checkroll == null)
                {
                    return new JsonResult("Ban Khong co quyen");
                }
                return Json("Ok");
            }
            else
            {
                return new JsonResult("dung pass roi");
            }
            return new JsonResult("aa");

        }

    }
}
