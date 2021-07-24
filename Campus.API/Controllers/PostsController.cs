using Campus.Entities;
using Campus.Persistence;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Campus.Business.Campus.Models;
using Campus.Business.Campus.Models.Post;
using Microsoft.IdentityModel.Tokens;
using Campus.Business.Campus.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CampusPortal1.api.Controllers
{
    [Route("api/[PostsController]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly ICampusService campusService;
        public PostsController(ICampusService campusService)
        {
            this.campusService = campusService;
        }
        // GET: api/<StudentsController>
        [HttpGet]
       /* public IEnumerable<Posts> Get()
        {
            return context.Posts.ToList();
        }
       */
        // GET api/<PostsController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            var result = await campusService.GetById(id);
            return Ok(result);
        }

        // POST api/<PostsController>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCampusModel model)
        {
            var result = await campusService.Create(model);

            return Created(result.IdPost.ToString(), null);
        }

        // PUT api/<PostsController>/5
        [HttpPut]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] CreateModelPost model)
        {
            await campusService.Update(id, model);
            return NoContent();
        }

        // DELETE api/<PostsController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            await campusService.Delete(id);
            return NoContent();
        }

    }
}
