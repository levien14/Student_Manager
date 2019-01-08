using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManager.Models;

namespace StudentManager.Controllers
{
    [Route("api/student/")]
    [ApiController]
    public class InformationController : ControllerBase
    {
        private MD5 _algorithm = MD5.Create();
        private readonly StudentManagerContext _context;

        public InformationController(StudentManagerContext context)
        {
            _context = context;
        }

        // GET: api/Information
        [HttpGet]
        public IEnumerable<Person> GetPerson()
        {
            return _context.Person;
        }
        // POST: api/Information
        [HttpPost("login")]
        public async Task<IActionResult> login(loginInfor login)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var existLogin = _context.Account.SingleOrDefault(ac => ac.Email == login.Email);
            
            if (existLogin != null)
            {
                var salt = existLogin.Salt;
                login.Password += salt;
                var hash = _algorithm.ComputeHash(Encoding.UTF8.GetBytes(login.Password));
                login.Password = Convert.ToBase64String(hash);
                if (login.Password == existLogin.Password)
                {

                    MyCredential credential = new MyCredential(existLogin.Id);
                    credential.Status = MyCredentialStatus.Actived;
                    _context.Add(credential);
                    _context.SaveChanges();
                    Response.StatusCode = (int)HttpStatusCode.OK;
                    return new JsonResult(credential);
                }
                else
                {
                    Response.StatusCode = (int)HttpStatusCode.BadRequest;
                }
            }
            else
            {
                Response.StatusCode = (int)HttpStatusCode.Forbidden;
                return Forbid();
            }
            return Forbid();
            //return Forbid();

        }

        // GET: api/Information/5
        [HttpGet("infor")]
        public async Task<IActionResult> Information()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var basicToken = Request.Headers["Authorization"].ToString();
            var token = basicToken.Replace("Basic ", "");
            var existToken = _context.MyCredentials.SingleOrDefault(a => a.AccessToken == token);
            if (existToken != null)
            {
                var existInfor = _context.Person
                    .Include(ac => ac.Account)
                 .ThenInclude(g => g.GradeStudents)
                  .ThenInclude(ag => ag.Grade)
                    .SingleOrDefault(i => i.AccountId == existToken.OwnId);
                if (existInfor != null)
                {
                    return new JsonResult(existInfor);
                }
                else
                {
                    return Forbid();
                }
            }
            return Forbid();
        }
        [HttpPost("change-information")]
        public async Task<IActionResult> ChangeInformation(Person person)
        {
            if (!ModelState.IsValid)
            {
                return new JsonResult("BadRequest");
            }
            var basicToken = Request.Headers["Authorization"].ToString();
            var token = basicToken.Replace("Basic ", "");
            var existToken = _context.MyCredentials.SingleOrDefault(a => a.AccessToken == token);
            if (existToken != null)
            {
                var existAccount = _context.Person.SingleOrDefault(i => i.AccountId == existToken.OwnId);

                if (existAccount != null)
                {
                    existAccount.AccountId = existToken.OwnId;
                    existAccount.Address = person.Address;
                    existAccount.FirstName = person.FirstName;
                    existAccount.LastName = person.LastName;
                    existAccount.Avatar = person.Avatar;
                    existAccount.Phone = person.Phone;
                    existAccount.BOD = person.BOD;
                    existAccount.Gender = person.Gender;
                    existAccount.Description = person.Description;
                    _context.Person.Update(existAccount);
                    _context.SaveChanges();
                    Response.StatusCode = (int)HttpStatusCode.OK;
                    return new JsonResult(existAccount);
                }
                return new JsonResult(existAccount);
            }
            Response.StatusCode = (int)HttpStatusCode.Forbidden;
            return new JsonResult("Forbidden");
        }

        // POST: api/Information
        [HttpGet("checkToken")]
        public async Task<IActionResult> checkToken(string tokenKey)
        {
            var token = _context.MyCredentials.SingleOrDefault(t => t.AccessToken == tokenKey);
            if (token != null && token.checkToken())
            {
                token.Status = MyCredentialStatus.Actived;
                return Ok(token);
            }
            return StatusCode(403);
        }
        //[HttpGet("Grade")]
        //public async Task<IActionResult> Grade()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    var basicToken = Request.Headers["Authorization"].ToString();
        //    var token = basicToken.Replace("Basic ", "");
        //    var existToken = _context.MyCredentials.SingleOrDefault(a => a.AccessToken == token);
        //    if (existToken != null)
        //    {
        //        var existInfor = _context.Account
        //            .SingleOrDefault(i => i.Id == existToken.OwnId);
        //        if (existInfor != null)
        //        {
        //            var grade = _context.Grade
        //            return new JsonResult(existInfor);
        //        }
        //        else
        //        {
        //            return Forbid();
        //        }
        //    }
        //    return Forbid();
        //}
        private bool PersonExists(int id)
        {
            return _context.Person.Any(e => e.AccountId == id);
        }
    }
}