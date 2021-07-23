using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Business.Identity.Models
{
	public sealed class LoginModelResponse
	{
		public LoginModelResponse(string username, string email)
		{
			Username = username;
			Email = email;
		}
		[Required(ErrorMessage = "User Name is required")]
		public string Username { get; private set; }

		[EmailAddress(ErrorMessage = "Email is required")]
		public string Email { get; private set; }
	}
}
