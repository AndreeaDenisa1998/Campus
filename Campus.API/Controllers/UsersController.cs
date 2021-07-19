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
    [Route("api/[UsersController]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private CampusContext context;
        public UsersController()
        {
            context = new CampusContext();
        }
        // GET: api/<AdminsController>
        [HttpGet]
        public IEnumerable<Users> Get()
        {
            return context.Users.ToList();
        }


        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public Users Get(Guid id)
        {
            return context.Users.FirstOrDefault(s => s.Id.Equals(id));
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] Users admins)
        {
            context.Users.Add(admins);

            context.SaveChanges();
        }

        // PUT api/<UsersController>/5
        [HttpPut]
        public void Put([FromBody] Users admins)
        {
            if (!admins.Id.HasValue)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return;
            }
            context.Users.Update(admins);

            context.SaveChanges();
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var adminsToDelete = context.Users.First(s => s.Id.Equals(id));
            context.Users.Remove(adminsToDelete);

            context.SaveChanges();
        }
    }
}
