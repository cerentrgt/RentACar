using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.FirstName).MinimumLength(2).MaximumLength(8);
            RuleFor(u => u.Password).NotEmpty();
            RuleFor(u => u.Password).MinimumLength(8).MaximumLength(12).WithMessage("Password'unuz en az 8 karakter en cok 12 karakter olmalı.");
            RuleFor(u => u.EMail).NotEmpty();
            RuleFor(u => u.LastName).NotEmpty();

        }
    }
}
