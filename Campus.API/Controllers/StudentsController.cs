using Campus.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Net;
using Campus.Persistence;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Campus.api.Controllers
{
    [Route("api/[StudentsController]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private CampusContext context;
        public StudentsController()
        {
            context = new CampusContext();
        }
        // GET: api/<StudentsController>
        [HttpGet]
        public IEnumerable<Students> Get()
        {
            return context.Students.ToList();
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public Students Get(Guid id)
        {
            return context.Students.FirstOrDefault(s => s.Id.Equals(id));

        }

        // POST api/<StudentsController>
        [HttpPost]
        public void Post([FromBody] Students student)
        {
            context.Students.Add(student);

            context.SaveChanges();
        }

        // PUT api/<StudentsController>/5
        [HttpPut]
       public void Put([FromBody] Students student)
        {
            if (!student.Id.HasValue)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return;
            }
            context.Students.Update(student);

            context.SaveChanges();
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var studentToDelete = context.Students.First(s => s.Id.Equals(id));
            context.Students.Remove(studentToDelete);

            context.SaveChanges();
        }
    }
    
}
