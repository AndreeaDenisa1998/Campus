using Campus.Entities;
using Campus.Persistence;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CampusPortal1.api.Controllers
{
    [Route("api/[CommentsController]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private CampusContext context;
        public CommentsController()
        {
            context = new CampusContext();
        }
        // GET: api/<StudentsController>
        [HttpGet]
        public IEnumerable<Comments> Get()
        {
            return context.Comments.ToList();
        }

        // GET api/<CommentsController>/5
        [HttpGet("{id}")]
        public Comments Get(Guid id)
        {
            return context.Comments.FirstOrDefault(s => s.Id.Equals(id));

        }

        // POST api/<CommentsController>
        [HttpPost]
        public void Comments([FromBody] Comments comments)
        {
            context.Comments.Add(comments);

            context.SaveChanges();
        }

        // PUT api/<CommentsController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Comments comments)
        {
            if (!comments.Id.HasValue)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return;
            }
            context.Comments.Update(comments);

            context.SaveChanges();
        }

        // DELETE api/<CommentsController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var commentToDelete = context.Comments.First(s => s.Id.Equals(id));
            context.Comments.Remove(commentToDelete);

            context.SaveChanges();
        }
    }
}
