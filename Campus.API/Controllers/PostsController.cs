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
    [Route("api/[PostsController]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private CampusContext context;
        public PostsController()
        {
            context = new CampusContext();
        }
        // GET: api/<StudentsController>
        [HttpGet]
        public IEnumerable<Posts> Get()
        {
            return context.Posts.ToList();
        }

        // GET api/<PostsController>/5
        [HttpGet("{id}")]
        public Posts Get(Guid id)
        {
            return context.Posts.FirstOrDefault(s => s.Id.Equals(id));

        }

        // POST api/<PostsController>
        [HttpPost]
        public void Post([FromBody] Posts posts)
        {
            context.Posts.Add(posts);

            context.SaveChanges();
        }

        // PUT api/<PostsController>/5
        [HttpPut]
        public void Put([FromBody] Posts posts)
        {
            if (!posts.Id.HasValue)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return;
            }
            context.Posts.Update(posts);

            context.SaveChanges();
        }

        // DELETE api/<PostsController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var postToDelete = context.Posts.First(s => s.Id.Equals(id));
            context.Posts.Remove(postToDelete);

            context.SaveChanges();
        }
    }
}
