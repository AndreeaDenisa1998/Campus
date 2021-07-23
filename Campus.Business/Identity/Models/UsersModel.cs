using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Business.Identity.Models
{
	public sealed class UsersModel
	{
		public Guid IdUsers { get; private set; }
		public string Username { get; private set; }

		public string Email { get; private set; }

		public string Type { get; private set; }

		public Guid IdTypeUsers{ get; private set; }


		public static UsersModel Create(Guid idUsers, string username, string email, string type, Guid idTypeUsers)
		{
			return new UsersModel()
			{
				IdUsers = idUsers,
				IdTypeUsers = idTypeUsers,
				Username = username,
				Email = email,
				Type = type,
				
			};
		}

	}

}
