using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
        public IActionResult login(string redirectUrl)
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
                return new JsonResult("Thông Tin Đăng Nhập Không Chính xác");
            }
            if (existlogin.Password == loginInfor.Password)
            {
                var checkroll = _context.AccountRole.SingleOrDefault(ar => ar.AccountId == existlogin.Id);
                if (checkroll == null)
                {
                    return new JsonResult("Thông Tin Đăng Nhập Không Chính xác");
                }
                HttpContext.Session.SetString("currentLogin", existlogin.Email);
                return Redirect("/Home");
            }
            else
            {
                return new JsonResult("Thông Tin Đăng Nhập Không Chính xác");
            }
            return new JsonResult("aa");

        }

    }
}
