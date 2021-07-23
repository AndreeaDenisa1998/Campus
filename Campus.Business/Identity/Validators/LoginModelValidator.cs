using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Business.Identity.Models;
using FluentValidation;

namespace Campus.Business.Identity.Validators
{
	public class LoginModelValidator : AbstractValidator<LoginModelRequest>
	{
		public LoginModelValidator()
		{
			RuleFor(x => x.Username)
				.NotNull()
				.MaximumLength(200);

			RuleFor(x => x.Password)
				.NotNull()
				.MinimumLength(10)
				.MaximumLength(50);
		}
	}
}
