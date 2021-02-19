using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(z => z.CompanyName).MinimumLength(3).MaximumLength(8);
            RuleFor(z => z.UserId).NotEmpty();
            RuleFor(z => z.CompanyName).NotEmpty();
        }
    }
}
