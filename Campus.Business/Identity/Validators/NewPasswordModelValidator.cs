using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Business.Identity.Models;
using FluentValidation;

namespace Campus.Business.Identity.Validators
{
	public class NewPasswordModelValidator : AbstractValidator<NewPasswordModelRequest>
	{
		public NewPasswordModelValidator()
		{
			RuleFor(x => x.NewPassword)
				.MinimumLength(10)
				.NotNull()
				.MaximumLength(50);
		}
	}
}
