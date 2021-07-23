using Campus.Entities;
using Campus.Persistence;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Campus.Business.Campus.Models.Comments;
using Microsoft.IdentityModel.Tokens;
using Campus.Business.Campus.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Campus.api.Controllers
{
    [Route("api/v1/Comments")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentService commentService;
        public CommentsController(ICommentService commentService)
        {
            this.commentService = commentService;
        }

        [HttpGet("{id}")]

    public async Task<IActionResult> Get([FromRoute] Guid id)
    {
        var result = await commentService.GetById(id);
            return Ok(result);
    }
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateModelComment model)
    {
        var result = await commentService.Create(model);
        return Created(result.Id.ToString(), null);
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        await commentService.Delete(id);
        return NoContent();
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] CreateModelComment model)
    {
        await commentService.Update(id, model);
        return NoContent();
    }
    }
}
