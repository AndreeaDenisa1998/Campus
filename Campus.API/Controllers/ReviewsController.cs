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
    [Route("api/[ReviewsController]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private CampusContext context;
        public ReviewsController()
        {
            context = new CampusContext();
        }
        // GET: api/<StudentsController>
        [HttpGet]
        public IEnumerable<Review> Get()
        {
            return context.Review.ToList();
        }

        // GET api/<ReviewsController>/5
        [HttpGet("{id}")]
        public Review Get(Guid id)
        {
            return context.Review.FirstOrDefault(s => s.Id.Equals(id));

        }


        // POST api/<ReviewsController>
        [HttpPost]
        public void Review([FromBody] Review review)
        {
            context.Review.Add(review);

            context.SaveChanges();
        }

        // PUT api/<ReviewsController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Review review)
        {
            if (!review.Id.HasValue)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return;
            }
            context.Review.Update(review);

            context.SaveChanges();
        }

        // DELETE api/<ReviewsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var reviewToDelete = context.Review.First(s => s.Id.Equals(id));
            context.Review.Remove(reviewToDelete);

            context.SaveChanges();
        }
    }
}
