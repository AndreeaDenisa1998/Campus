using System;
using System.Threading.Tasks;
using Campus.Business.Campus.Services;
using Campus.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace Campus.API.Controllers
{
    [Route("api/[TypePostsController]")]
    [ApiController]
    public class TypesPostsController : ControllerBase
    {
        private readonly ICampusService campusService;
        public TypesPostsController(ICampusService campusService)
        {
            this.campusService = campusService;
        }

       
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] Guid Id)
        {
            var result = await campusService.GetById(id);
            return Ok(result);
        }

      
    }
}