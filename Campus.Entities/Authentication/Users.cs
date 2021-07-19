using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Entities
{
	public sealed class Users : Entity
	{
		public Users(string userName, string email, bool idTypeUsers,Guid? idStudents,string passwordHash) : base()
		{
			UserName = userName;
			Email = email;
			PasswordHash = passwordHash;
			IdTypeUsers = idTypeUsers;
			IdStudents = idStudents;
			Posts = new List<Posts>();
			Comments = new List<Comments>();
			CafeteriaPost = new List<CafeteriaPost>();
		}
		[Required, MaxLength(40), MinLength(8)]
		public string UserName { get; private set; }

		[Required, DataType(DataType.EmailAddress), MaxLength(150)]
		public string Email { get; private set; }

		[Required, DataType(DataType.Password)]
		public string PasswordHash { get; private set; }

		[Required]
		public bool IdTypeUsers { get; private set; }

		[AllowNull]
		public Guid? IdStudents { get; private set; }

		public Students Student { get; private set; }
		public ICollection<Posts> Posts { get; private set; }

		public ICollection<TypesUsers> TypesUsers { get; private set; }

		public ICollection<Comments> Comments { get; private set; }

		public ICollection<CafeteriaPost> CafeteriaPost { get; private set; }

	
	}
}

