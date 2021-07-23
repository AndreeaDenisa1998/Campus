using System.Collections.Generic;
using Campus.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Campus.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RolesController : ControllerBase
	{
		private readonly CampusContext _context;
		public RolesController(CampusContext context)
		{
			_context = context;
		}

		[HttpGet]
		public IEnumerable<IdentityRole> Get()
		{
			return _context.Roles.AsEnumerable();
		}

		[HttpPost]
		public void Post([FromBody] string roleName)
		{
			var roleToAdd = new IdentityRole
			{
				Name = roleName,
				NormalizedName = roleName.ToUpper()
			};

			_context.Roles.Add(roleToAdd);

			_context.SaveChanges();
		}

		[HttpDelete("{id}")]
		public void Delete(string id)
		{
			var roleToDelete = _context.Roles.First(r => r.Id.Equals(id));

			_context.Roles.Remove(roleToDelete);

			_context.SaveChanges();
		}

	}
}
