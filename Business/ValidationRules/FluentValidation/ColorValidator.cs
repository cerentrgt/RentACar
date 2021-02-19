using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator:AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(s => s.ColorId).NotEmpty();
            RuleFor(s=>s.ColorName).NotEmpty();
            RuleFor(s => s.ColorName).MinimumLength(2);
        }
    }
}
