using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Entities.Authentication
{
	public sealed class Users : Entity
	{
		public Users()
		{
		}

		public Users(string username, string email, Guid idTypeUsers,string passwordHash) : base()
		{
			Username = username;
			Email = email;
			PasswordHash = passwordHash;
			IdTypeUsers = idTypeUsers;
			Posts = new List<Posts>();
			Comments = new List<Comments>();
			Reviews = new List<Review>();
			//Notifications = new List<Notifications>();
		}
		[Required, MaxLength(40), MinLength(8)]
		public string Username { get; set; }

		[Required, DataType(DataType.EmailAddress), MaxLength(150)]
		public string Email { get;  set; }

		[Required, DataType(DataType.Password)]
		public string PasswordHash { get; private set; }

		[Required]
		public Guid IdTypeUsers { get; private set; }

		public ICollection<Posts> Posts { get; private set; }
		

		public TypesUsers TypesUsers { get; set; }

		public ICollection<Comments> Comments { get; private set; }
		

		//public ICollection<Notifications> Notifications { get; private set; }

		public ICollection<Review> Reviews { get; private set; }


	}
}

