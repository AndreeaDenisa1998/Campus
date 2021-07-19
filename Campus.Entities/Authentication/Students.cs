using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Entities
{
	public class Students:Entity
	{
		public Students(string firstName, string lastName, int registrationNumber) : base()
		{
			FirstName = firstName;
			LastName = lastName;
			RegistrationNumber = registrationNumber;
		}

		[Required, MaxLength(30)]
		public string FirstName { get; private set; }

		[Required,MaxLength(15)]
		public string LastName { get; private set; }

		[Required,MinLength(4)]
		public int RegistrationNumber { get; private set; }

		public ICollection<Posts> Posts { get; private set; }

		public ICollection<TypesUsers> TypesUsers { get; private set; }

		public ICollection<Comments> Comments { get; private set; }

		public ICollection<CafeteriaPost> CafeteriaPost { get; private set; }

		public ICollection<Review> Reviews { get; private set; }

	}
}
