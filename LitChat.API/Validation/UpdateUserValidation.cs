﻿using FluentValidation;
using LitChat.API.Models;

namespace LitChat.API.Validation
{
    public class UpdateUserValidation : AbstractValidator<UpdateAccountViewModel>
    {
        public UpdateUserValidation()
        {
            RuleFor(x => x.Profile.FirstName).NotEmpty().MinimumLength(2).WithMessage("Name must be at least 2 characters");
            RuleFor(x => x.Profile.LastName).NotEmpty().MinimumLength(2).WithMessage("Last name must be at least 2 characters");
            RuleFor(x => x.Profile.Description).MaximumLength(100);
        }
    }
}
