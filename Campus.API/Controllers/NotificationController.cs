using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Campus.Business.Campus.Models.Comments;
using Campus.Business.Campus.Models.Notifications;
using Campus.Business.Campus.Services;
using Campus.Business.Campus.Services.NotificationS;

namespace Campus.API.Controllers
{
    [Route("api/v1/Notification")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService NotificationService;
        public NotificationController(INotificationService NotificationService)
        {
            this.NotificationService = NotificationService;
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            var result = await NotificationService.GetById(id);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateNotificationModel model)
        {
            var result = await NotificationService.Create(model);
            return Created(result.Id.ToString(), null);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            await NotificationService.Delete(id);
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] CreateNotificationModel model)
        {
            await NotificationService.Update(id, model);
            return NoContent();
        }
    }
}
