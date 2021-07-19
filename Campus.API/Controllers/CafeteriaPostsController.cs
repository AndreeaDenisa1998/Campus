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
    [Route("api/[CafeteriaPostsController]")]
    [ApiController]
    public class CafeteriaPostsController : ControllerBase
    {
        private CampusContext context;
        public CafeteriaPostsController()
        {
            context = new CampusContext();
        }
        // GET: api/<StudentsController>
        [HttpGet]
        public IEnumerable<CafeteriaPost> Get()
        {
            return context.CafeteriaPost.ToList();
        }

        // GET api/<CafeteriaPostsController>/5
        [HttpGet("{id}")]
        public CafeteriaPost Get(Guid id)
        {
            return context.CafeteriaPost.FirstOrDefault(s => s.Id.Equals(id));

        }

        // POST api/<CafeteriaPostsController>
        [HttpPost]
        public void Post ([FromBody] CafeteriaPost cafeteriaPost)
        {
            context.CafeteriaPost.Add(cafeteriaPost);

            context.SaveChanges();
        }

        // PUT api/<CafeteriaPostsController>/5
        [HttpPut]
        public void put([FromBody] CafeteriaPost cafeteriaPost)
        {
            if (!cafeteriaPost.Id.HasValue)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return;
            }
            context.CafeteriaPost.Update(cafeteriaPost);

            context.SaveChanges();
        }

        // DELETE api/<CafeteriaPostsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var cafpostToDelete = context.CafeteriaPost.First(s => s.Id.Equals(id));
            context.CafeteriaPost.Remove(cafpostToDelete);

            context.SaveChanges();
        }
    }
}
