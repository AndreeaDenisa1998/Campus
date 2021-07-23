using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Business.Identity.Models;
using FluentValidation;

namespace Campus.Business.Identity.Validators
{
	public class UserRegisterModelValidator:AbstractValidator<RegisterModel>
	{
		public UserRegisterModelValidator()
		{
			RuleFor(s => s.Username)
				.NotNull()
				.NotEmpty()
				.MinimumLength(6)
				.MaximumLength(50);
			RuleFor(s => s.Email)
				.NotNull()
				.EmailAddress()
				.MaximumLength(200);
			RuleFor(s => s.Password)
				.NotNull()
				.MinimumLength(10)
				.MaximumLength(50);

		}
	}
}
