using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        public async Task<IActionResult> GetPerson(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var person = _context.Person.Include(ac => ac.Account)                
                .SingleOrDefault(p=>p.AccountId==id);

            if (person == null)
            {
                return NotFound();
            }

            return new JsonResult(person);
        }

        // PUT: api/Information/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPerson([FromRoute] int id, [FromBody] Person person)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != person.AccountId)
            {
                return BadRequest();
            }

            _context.Entry(person).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
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
        
        private bool PersonExists(int id)
        {
            return _context.Person.Any(e => e.AccountId == id);
        }
    }
}