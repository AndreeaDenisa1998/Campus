﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Business.Identity.Models
{
	public sealed class RegisterModel
	{
		[Required(ErrorMessage = "User Name is required")]
		public string Username { get; set; }

		[EmailAddress]
		public string Email { get; set; }

		[Required(ErrorMessage = "Password is required")]
		public string Password { get; set; }
	}
}